using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace epood
{
    public partial class Form1 : Form
    {
        private SqlCommand? _command;
        private SqlConnection _connect = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tahma\Source\Repos\epood\ShopDB.mdf;Integrated Security=True");
        private SqlDataAdapter? _adapterProduct;

        private SqlDataAdapter? adapter_toode;
        private SqlDataAdapter? adapter_kategooria;
        private int Id;
        private string? extension;
        private byte[]? imageData;
        private Form? popupForm;

        // 🔧 Исправлено: объявлены корректные диалоги
        private OpenFileDialog? openFileDialog;
        private SaveFileDialog? saveFileDialog;

        public Form1()
        {
            InitializeComponent();
            UpdateCategories();
            NaitaAndmed();
            NaitaKategooriad();
        }

        private void UpdateCategories()
        {
            try
            {
                _connect.Open();
                _adapterProduct = new SqlDataAdapter("SELECT Id, Kategooria_nim FROM KatTabel", _connect);
                DataTable dt = new();
                _adapterProduct.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    object? katObj = item["Kategooria_nim"];
                    if (katObj != null)
                    {
                        string kat = katObj.ToString() ?? string.Empty;
                        if (!KategooriadBox.Items.Contains(kat))
                            KategooriadBox.Items.Add(kat);
                        else
                        {
                            _command = new SqlCommand("DELETE FROM KatTabel WHERE Id=@id", _connect);
                            _command.Parameters.AddWithValue("@id", item["Id"]);
                            _command.ExecuteNonQuery();
                        }
                    }
                }
            }
            finally
            {
                if (_connect.State == ConnectionState.Open)
                    _connect.Close();
            }
        }

        public void NaitaAndmed()
        {
            try
            {
                _connect.Open();

                DataTable dt_toode = new DataTable();

                string sql = "SELECT Toodetabel.Id, Toodetabel.Toodenimetus, Toodetabel.Kogus, " +
                             "Toodetabel.Hind, Toodetabel.Pilt, Kategooriatabel.Kategooria_nimetus " +
                             "FROM Toodetabel INNER JOIN Kategooriatabel ON Toodetabel.Kategooriad = Kategooriatabel.Id";

                adapter_toode = new SqlDataAdapter(sql, _connect);
                adapter_toode.Fill(dt_toode);

                DataGridView.Columns.Clear();
                DataGridView.DataSource = dt_toode;

                HashSet<string> keys = new HashSet<string>();
                foreach (DataRow row in dt_toode.Rows)
                {
                    string kat_n = row["Kategooria_nimetus"]?.ToString() ?? string.Empty;
                    if (!keys.Contains(kat_n))
                        keys.Add(kat_n);
                }
            }
            catch
            {
                // ignore
            }
            finally
            {
                if (_connect.State == ConnectionState.Open)
                    _connect.Close();
            }
        }

        private void LisaKat_Click(object sender, EventArgs e)
        {
            if (KategooriadBox.SelectedItem == null) return;

            try
            {
                _connect.Open();
                string kat_val = KategooriadBox.SelectedItem.ToString() ?? string.Empty;
                using SqlCommand command = new SqlCommand("INSERT INTO KatTabel (Kategooria_nim) VALUES (@kat)", _connect);
                command.Parameters.AddWithValue("@kat", kat_val);
                command.ExecuteNonQuery();
                KategooriadBox.Items.Clear();
                NaitaKategooriad();
            }
            finally
            {
                if (_connect.State == ConnectionState.Open)
                    _connect.Close();
            }
        }

        private void KustutaKat_Click(object sender, EventArgs e)
        {
            if (KategooriadBox.SelectedItem != null)
            {
                _connect.Open();
                string value = KategooriadBox.SelectedItem.ToString() ?? string.Empty;
                _command = new SqlCommand("DELETE FROM KatTabel WHERE Kategooria_nim=@cat", _connect);
                _command.Parameters.AddWithValue("@cat", value);
                _command.ExecuteNonQuery();
                _connect.Close();
                KategooriadBox.Items.Clear();
                UpdateCategories();
            }
        }

        public void NaitaKategooriad()
        {
            try
            {
                _connect.Open();
                adapter_kategooria = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooriatabel", _connect);
                DataTable dt_kat = new DataTable();
                adapter_kategooria.Fill(dt_kat);

                KategooriadBox.Items.Clear();
                foreach (DataRow r in dt_kat.Rows)
                {
                    KategooriadBox.Items.Add(r["Kategooria_nimetus"]?.ToString() ?? string.Empty);
                }
            }
            finally
            {
                if (_connect.State == ConnectionState.Open)
                    _connect.Close();
            }
        }

        private void Otsi_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\opilane\Pictures";
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image Files|*.jpeg;*.bmp;*.png;*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ToodeBox.Text))
            {
                FileInfo openInfo = new FileInfo(openFileDialog.FileName);

                saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Path.GetFullPath(@"..\..\Images");
                saveFileDialog.FileName = ToodeBox.Text + openInfo.Extension;
                saveFileDialog.Filter = "Images|*" + openInfo.Extension;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openFileDialog.FileName, saveFileDialog.FileName, true);
                    PictureBox.Image = Image.FromFile(saveFileDialog.FileName);
                }
            }
        }

        private void Lisa_Click(object sender, EventArgs e)
        {
            if (ToodeBox.Text.Trim() != string.Empty &&
                KogusBox.Text.Trim() != string.Empty &&
                HindBox.Text.Trim() != string.Empty &&
                KategooriadBox.SelectedItem != null)
            {
                try
                {
                    _connect.Open();

                    using (SqlCommand command = new SqlCommand("SELECT Id FROM Kategooriatabel WHERE Kategooria_nimetus = @kat", _connect))
                    {
                        command.Parameters.AddWithValue("@kat", KategooriadBox.Text);
                        object? scalar = command.ExecuteScalar();
                        Id = (scalar != null && int.TryParse(scalar.ToString(), out int val)) ? val : 0;
                    }

                    using (SqlCommand command = new SqlCommand("INSERT INTO Toodetabel (Toodenimetus, Kogus, Hind, Pilt, Bpilt, Kategooriad) " +
                                                               "VALUES (@toode, @kogus, @hind, @pilt, @bpilt, @kat)", _connect))
                    {
                        command.Parameters.AddWithValue("@toode", ToodeBox.Text);
                        command.Parameters.AddWithValue("@kogus", KogusBox.Text);
                        command.Parameters.AddWithValue("@hind", HindBox.Text);

                        if (openFileDialog != null && !string.IsNullOrEmpty(openFileDialog.FileName))
                        {
                            extension = Path.GetExtension(openFileDialog.FileName);
                            command.Parameters.AddWithValue("@pilt", ToodeBox.Text + extension);
                            imageData = File.ReadAllBytes(openFileDialog.FileName);
                            command.Parameters.AddWithValue("@bpilt", imageData);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@pilt", DBNull.Value);
                            command.Parameters.AddWithValue("@bpilt", DBNull.Value);
                        }

                        command.Parameters.AddWithValue("@kat", Id);
                        command.ExecuteNonQuery();
                    }

                    _connect.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga");
                    if (_connect.State == ConnectionState.Open)
                        _connect.Close();
                }
            }
        }

        private void Loopilt(Image image, int r)
        {
            popupForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.Manual,
                Size = new Size(200, 200)
            };

            PictureBox pictureBox = new PictureBox
            {
                Image = image,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            popupForm.Controls.Add(pictureBox);

            if (DataGridView != null && r >= 0 && r < DataGridView.Rows.Count)
            {
                Rectangle cellRectangle = DataGridView.GetCellDisplayRectangle(4, r, true);
                Point popupLocation = DataGridView.PointToScreen(cellRectangle.Location);
                popupForm.Location = new Point(popupLocation.X + cellRectangle.Width, popupLocation.Y);
                popupForm.Show();
            }
        }
    }
}
