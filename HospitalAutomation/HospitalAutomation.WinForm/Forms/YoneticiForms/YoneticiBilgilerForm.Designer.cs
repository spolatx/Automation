namespace HospitalAutomation.WinForm.Forms.YoneticiForms
{
    partial class YoneticiBilgilerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiBilgilerForm));
            btnYoneticiBilgileriExit = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button3 = new Button();
            groupBox1 = new GroupBox();
            btnYoneticiBilgileriSil = new Button();
            btnYoneticiBilgileriEkle = new Button();
            btnYoneticiBilgileriGuncelle = new Button();
            txtYoneticiYeniSifreTekrar = new TextBox();
            label8 = new Label();
            txtYoneticiYeniSifre = new TextBox();
            label7 = new Label();
            txtYoneticiSifre = new TextBox();
            label6 = new Label();
            txtYoneticiSoyad = new TextBox();
            label5 = new Label();
            txtYoneticiAd = new TextBox();
            label4 = new Label();
            txtYoneticiKullaniciAdi = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnYoneticiBilgileriExit
            // 
            btnYoneticiBilgileriExit.BackColor = Color.Transparent;
            btnYoneticiBilgileriExit.FlatAppearance.BorderSize = 0;
            btnYoneticiBilgileriExit.FlatStyle = FlatStyle.Flat;
            btnYoneticiBilgileriExit.ForeColor = Color.White;
            btnYoneticiBilgileriExit.Image = (Image)resources.GetObject("btnYoneticiBilgileriExit.Image");
            btnYoneticiBilgileriExit.Location = new Point(758, 12);
            btnYoneticiBilgileriExit.Name = "btnYoneticiBilgileriExit";
            btnYoneticiBilgileriExit.Size = new Size(30, 30);
            btnYoneticiBilgileriExit.TabIndex = 20;
            btnYoneticiBilgileriExit.UseVisualStyleBackColor = false;
            btnYoneticiBilgileriExit.Click += btnYoneticiBilgileriExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(276, 10);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 28;
            label1.Text = "Yönetici Bilgileri";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(366, 362);
            dataGridView1.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(151, 19);
            label2.TabIndex = 30;
            label2.Text = "Mevcut Yöneticiler";
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(690, 76);
            button3.Name = "button3";
            button3.Size = new Size(98, 39);
            button3.TabIndex = 82;
            button3.Text = "Temizle";
            button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnYoneticiBilgileriSil);
            groupBox1.Controls.Add(btnYoneticiBilgileriEkle);
            groupBox1.Controls.Add(btnYoneticiBilgileriGuncelle);
            groupBox1.Controls.Add(txtYoneticiYeniSifreTekrar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtYoneticiYeniSifre);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtYoneticiSifre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtYoneticiSoyad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtYoneticiAd);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtYoneticiKullaniciAdi);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(394, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 316);
            groupBox1.TabIndex = 83;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnYoneticiBilgileriSil
            // 
            btnYoneticiBilgileriSil.BackColor = Color.Maroon;
            btnYoneticiBilgileriSil.FlatAppearance.BorderSize = 0;
            btnYoneticiBilgileriSil.FlatStyle = FlatStyle.Flat;
            btnYoneticiBilgileriSil.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYoneticiBilgileriSil.ForeColor = Color.White;
            btnYoneticiBilgileriSil.Location = new Point(292, 247);
            btnYoneticiBilgileriSil.Name = "btnYoneticiBilgileriSil";
            btnYoneticiBilgileriSil.Size = new Size(98, 39);
            btnYoneticiBilgileriSil.TabIndex = 96;
            btnYoneticiBilgileriSil.Text = "Sil";
            btnYoneticiBilgileriSil.UseVisualStyleBackColor = false;
            // 
            // btnYoneticiBilgileriEkle
            // 
            btnYoneticiBilgileriEkle.BackColor = Color.PaleGreen;
            btnYoneticiBilgileriEkle.FlatAppearance.BorderSize = 0;
            btnYoneticiBilgileriEkle.FlatStyle = FlatStyle.Flat;
            btnYoneticiBilgileriEkle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYoneticiBilgileriEkle.ForeColor = Color.White;
            btnYoneticiBilgileriEkle.Location = new Point(188, 247);
            btnYoneticiBilgileriEkle.Name = "btnYoneticiBilgileriEkle";
            btnYoneticiBilgileriEkle.Size = new Size(98, 39);
            btnYoneticiBilgileriEkle.TabIndex = 95;
            btnYoneticiBilgileriEkle.Text = "Ekle";
            btnYoneticiBilgileriEkle.UseVisualStyleBackColor = false;
            // 
            // btnYoneticiBilgileriGuncelle
            // 
            btnYoneticiBilgileriGuncelle.BackColor = Color.Khaki;
            btnYoneticiBilgileriGuncelle.FlatAppearance.BorderSize = 0;
            btnYoneticiBilgileriGuncelle.FlatStyle = FlatStyle.Flat;
            btnYoneticiBilgileriGuncelle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYoneticiBilgileriGuncelle.ForeColor = Color.White;
            btnYoneticiBilgileriGuncelle.Location = new Point(84, 247);
            btnYoneticiBilgileriGuncelle.Name = "btnYoneticiBilgileriGuncelle";
            btnYoneticiBilgileriGuncelle.Size = new Size(98, 39);
            btnYoneticiBilgileriGuncelle.TabIndex = 94;
            btnYoneticiBilgileriGuncelle.Text = "Güncelle";
            btnYoneticiBilgileriGuncelle.UseVisualStyleBackColor = false;
            // 
            // txtYoneticiYeniSifreTekrar
            // 
            txtYoneticiYeniSifreTekrar.Location = new Point(148, 196);
            txtYoneticiYeniSifreTekrar.Name = "txtYoneticiYeniSifreTekrar";
            txtYoneticiYeniSifreTekrar.Size = new Size(242, 27);
            txtYoneticiYeniSifreTekrar.TabIndex = 92;
            txtYoneticiYeniSifreTekrar.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 199);
            label8.Name = "label8";
            label8.Size = new Size(138, 21);
            label8.TabIndex = 93;
            label8.Text = "Yeni Şifre Tekrar :";
            // 
            // txtYoneticiYeniSifre
            // 
            txtYoneticiYeniSifre.Location = new Point(148, 163);
            txtYoneticiYeniSifre.Name = "txtYoneticiYeniSifre";
            txtYoneticiYeniSifre.Size = new Size(242, 27);
            txtYoneticiYeniSifre.TabIndex = 90;
            txtYoneticiYeniSifre.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 166);
            label7.Name = "label7";
            label7.Size = new Size(87, 21);
            label7.TabIndex = 91;
            label7.Text = "Yeni Şifre :";
            // 
            // txtYoneticiSifre
            // 
            txtYoneticiSifre.Location = new Point(148, 130);
            txtYoneticiSifre.Name = "txtYoneticiSifre";
            txtYoneticiSifre.Size = new Size(242, 27);
            txtYoneticiSifre.TabIndex = 88;
            txtYoneticiSifre.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 133);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 89;
            label6.Text = "Şifre :";
            // 
            // txtYoneticiSoyad
            // 
            txtYoneticiSoyad.Location = new Point(148, 97);
            txtYoneticiSoyad.Name = "txtYoneticiSoyad";
            txtYoneticiSoyad.Size = new Size(242, 27);
            txtYoneticiSoyad.TabIndex = 86;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 100);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 87;
            label5.Text = "Soyad :";
            // 
            // txtYoneticiAd
            // 
            txtYoneticiAd.Location = new Point(148, 64);
            txtYoneticiAd.Name = "txtYoneticiAd";
            txtYoneticiAd.Size = new Size(242, 27);
            txtYoneticiAd.TabIndex = 84;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 67);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 85;
            label4.Text = "Ad :";
            // 
            // txtYoneticiKullaniciAdi
            // 
            txtYoneticiKullaniciAdi.Location = new Point(148, 31);
            txtYoneticiKullaniciAdi.Name = "txtYoneticiKullaniciAdi";
            txtYoneticiKullaniciAdi.ReadOnly = true;
            txtYoneticiKullaniciAdi.Size = new Size(242, 27);
            txtYoneticiKullaniciAdi.TabIndex = 82;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 34);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 83;
            label3.Text = "Kullanıcı Adı :";
            // 
            // YoneticiBilgilerForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnYoneticiBilgileriExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "YoneticiBilgilerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiBilgilerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYoneticiBilgileriExit;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button3;
        private GroupBox groupBox1;
        private Button btnYoneticiBilgileriSil;
        private Button btnYoneticiBilgileriEkle;
        private Button btnYoneticiBilgileriGuncelle;
        private TextBox txtYoneticiYeniSifreTekrar;
        private Label label8;
        private TextBox txtYoneticiYeniSifre;
        private Label label7;
        private TextBox txtYoneticiSifre;
        private Label label6;
        private TextBox txtYoneticiSoyad;
        private Label label5;
        private TextBox txtYoneticiAd;
        private Label label4;
        private TextBox txtYoneticiKullaniciAdi;
        private Label label3;
    }
}