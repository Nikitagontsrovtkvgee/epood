namespace epood
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ToodeBox = new TextBox();
            KogusBox = new TextBox();
            HindBox = new TextBox();
            KategooriadBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LisaKat = new Button();
            KustutaKat = new Button();
            TextBox26 = new TextBox();
            PictureBox = new PictureBox();
            DataGridView = new DataGridView();
            Lisa = new Button();
            Uuenda = new Button();
            Kustuta = new Button();
            Puhasta = new Button();
            Maksta = new Button();
            Pood = new Button();
            Valin = new Button();
            Otsi = new Button();
            Ostan = new Button();
            Saada = new Button();
            Label35 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // ToodeBox
            // 
            ToodeBox.Location = new Point(95, 22);
            ToodeBox.Name = "ToodeBox";
            ToodeBox.Size = new Size(130, 31);
            ToodeBox.TabIndex = 0;
            ToodeBox.Text = "Kirjuta";
            // 
            // KogusBox
            // 
            KogusBox.Location = new Point(95, 57);
            KogusBox.Name = "KogusBox";
            KogusBox.Size = new Size(130, 31);
            KogusBox.TabIndex = 1;
            KogusBox.Text = "Kirjuta";
            // 
            // HindBox
            // 
            HindBox.Location = new Point(95, 92);
            HindBox.Name = "HindBox";
            HindBox.Size = new Size(130, 31);
            HindBox.TabIndex = 2;
            HindBox.Text = "Kirjuta";
            // 
            // KategooriadBox
            // 
            KategooriadBox.DropDownWidth = 130;
            KategooriadBox.ItemHeight = 25;
            KategooriadBox.Location = new Point(95, 127);
            KategooriadBox.Name = "KategooriadBox";
            KategooriadBox.Size = new Size(130, 33);
            KategooriadBox.TabIndex = 3;
            KategooriadBox.Text = "Vali";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 4;
            label1.Text = "Toode:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 5;
            label2.Text = "Kogus:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 95);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 6;
            label3.Text = "Hind:";
            // 
            // LisaKat
            // 
            LisaKat.Location = new Point(20, 174);
            LisaKat.Name = "LisaKat";
            LisaKat.Size = new Size(110, 34);
            LisaKat.TabIndex = 8;
            LisaKat.Text = "Lisa kategooriat";
            LisaKat.Click += LisaKat_Click;
            // 
            // KustutaKat
            // 
            KustutaKat.Location = new Point(136, 176);
            KustutaKat.Name = "KustutaKat";
            KustutaKat.Size = new Size(120, 32);
            KustutaKat.TabIndex = 9;
            KustutaKat.Text = "Kustuta kategooriat";
            KustutaKat.Click += KustutaKat_Click;
            // 
            // TextBox26
            // 
            TextBox26.Location = new Point(541, 223);
            TextBox26.Name = "TextBox26";
            TextBox26.Size = new Size(128, 31);
            TextBox26.TabIndex = 20;
            TextBox26.Text = "TextBox26";
            // 
            // PictureBox
            // 
            PictureBox.BackColor = Color.WhiteSmoke;
            PictureBox.Location = new Point(288, 20);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(380, 156);
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 21;
            PictureBox.TabStop = false;
            PictureBox.Text = "PictureBox25";
            // 
            // DataGridView
            // 
            DataGridView.BackgroundColor = Color.Gainsboro;
            DataGridView.ColumnHeadersHeight = 34;
            DataGridView.Location = new Point(20, 260);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 62;
            DataGridView.Size = new Size(650, 150);
            DataGridView.TabIndex = 22;
            DataGridView.Text = "DataGridView27";
            // 
            // Lisa
            // 
            Lisa.Location = new Point(20, 212);
            Lisa.Name = "Lisa";
            Lisa.Size = new Size(75, 42);
            Lisa.TabIndex = 23;
            Lisa.Text = "Lisa";
            // 
            // Uuenda
            // 
            Uuenda.Location = new Point(100, 212);
            Uuenda.Name = "Uuenda";
            Uuenda.Size = new Size(75, 42);
            Uuenda.TabIndex = 24;
            Uuenda.Text = "Uuenda";
            // 
            // Kustuta
            // 
            Kustuta.Location = new Point(180, 212);
            Kustuta.Name = "Kustuta";
            Kustuta.Size = new Size(75, 42);
            Kustuta.TabIndex = 25;
            Kustuta.Text = "Kustuta";
            // 
            // Puhasta
            // 
            Puhasta.Location = new Point(292, 218);
            Puhasta.Name = "Puhasta";
            Puhasta.Size = new Size(75, 36);
            Puhasta.TabIndex = 26;
            Puhasta.Text = "Puhasta";
            // 
            // Maksta
            // 
            Maksta.Location = new Point(376, 218);
            Maksta.Name = "Maksta";
            Maksta.Size = new Size(75, 42);
            Maksta.TabIndex = 29;
            Maksta.Text = "Maksta";
            // 
            // Pood
            // 
            Pood.Location = new Point(460, 218);
            Pood.Name = "Pood";
            Pood.Size = new Size(75, 42);
            Pood.TabIndex = 30;
            Pood.Text = "Pood";
            // 
            // Valin
            // 
            Valin.Location = new Point(376, 184);
            Valin.Name = "Valin";
            Valin.Size = new Size(75, 37);
            Valin.TabIndex = 31;
            Valin.Text = "Valin";
            // 
            // Otsi
            // 
            Otsi.Location = new Point(292, 184);
            Otsi.Name = "Otsi";
            Otsi.Size = new Size(75, 28);
            Otsi.TabIndex = 32;
            Otsi.Text = "Otsi fail";
            Otsi.Click += Otsi_Click;
            // 
            // Ostan
            // 
            Ostan.Location = new Point(460, 184);
            Ostan.Name = "Ostan";
            Ostan.Size = new Size(75, 37);
            Ostan.TabIndex = 33;
            Ostan.Text = "Ostan";
            // 
            // Saada
            // 
            Saada.Location = new Point(540, 184);
            Saada.Name = "Saada";
            Saada.Size = new Size(124, 37);
            Saada.TabIndex = 34;
            Saada.Text = "Saada arve";
            // 
            // Label35
            // 
            Label35.AutoSize = true;
            Label35.Location = new Point(20, 130);
            Label35.Name = "Label35";
            Label35.Size = new Size(102, 25);
            Label35.TabIndex = 35;
            Label35.Text = "Kategooria:";
            // 
            // Form1
            // 
            ClientSize = new Size(871, 474);
            Controls.Add(ToodeBox);
            Controls.Add(KogusBox);
            Controls.Add(HindBox);
            Controls.Add(KategooriadBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(LisaKat);
            Controls.Add(KustutaKat);
            Controls.Add(TextBox26);
            Controls.Add(PictureBox);
            Controls.Add(DataGridView);
            Controls.Add(Lisa);
            Controls.Add(Uuenda);
            Controls.Add(Kustuta);
            Controls.Add(Puhasta);
            Controls.Add(Maksta);
            Controls.Add(Pood);
            Controls.Add(Valin);
            Controls.Add(Otsi);
            Controls.Add(Ostan);
            Controls.Add(Saada);
            Controls.Add(Label35);
            Name = "Form1";
            Text = "Pood";
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox ToodeBox;
        private System.Windows.Forms.TextBox KogusBox;
        private System.Windows.Forms.TextBox HindBox;
        private System.Windows.Forms.ComboBox KategooriadBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LisaKat;
        private System.Windows.Forms.Button KustutaKat;
        private System.Windows.Forms.TextBox TextBox26;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button Lisa;
        private System.Windows.Forms.Button Uuenda;
        private System.Windows.Forms.Button Kustuta;
        private System.Windows.Forms.Button Puhasta;
        private System.Windows.Forms.Button Maksta;
        private System.Windows.Forms.Button Pood;
        private System.Windows.Forms.Button Valin;
        private System.Windows.Forms.Button Otsi;
        private System.Windows.Forms.Button Ostan;
        private System.Windows.Forms.Button Saada;
        private System.Windows.Forms.Label Label35;
    }
}