namespace HospitalAutomation.WinForm.Forms.DoktorForms
{
    partial class DoktorKullaniciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorKullaniciForm));
            btnDoktorBilgileriGuncelle = new Button();
            mtxtDoktorTcKimlikNo = new MaskedTextBox();
            txtDoktorAd = new TextBox();
            txtDoktorSoyad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            mtxtDoktorCepTelefonu = new MaskedTextBox();
            label4 = new Label();
            label7 = new Label();
            label9 = new Label();
            txtDoktorKullaniciAdi = new TextBox();
            label1 = new Label();
            txtDoktorDogumTarihi = new TextBox();
            label8 = new Label();
            txtDoktorEskiParola = new TextBox();
            label10 = new Label();
            txtDoktoryYeniParola = new TextBox();
            label11 = new Label();
            txtDoktorEmail = new TextBox();
            txtDoktorEskiParolaTekrar = new TextBox();
            label5 = new Label();
            btnDoktorBilgileriClose = new Button();
            SuspendLayout();
            // 
            // btnDoktorBilgileriGuncelle
            // 
            btnDoktorBilgileriGuncelle.BackColor = Color.Maroon;
            btnDoktorBilgileriGuncelle.FlatAppearance.BorderSize = 0;
            btnDoktorBilgileriGuncelle.FlatStyle = FlatStyle.Flat;
            btnDoktorBilgileriGuncelle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoktorBilgileriGuncelle.ForeColor = Color.White;
            btnDoktorBilgileriGuncelle.Location = new Point(342, 420);
            btnDoktorBilgileriGuncelle.Name = "btnDoktorBilgileriGuncelle";
            btnDoktorBilgileriGuncelle.Size = new Size(152, 39);
            btnDoktorBilgileriGuncelle.TabIndex = 90;
            btnDoktorBilgileriGuncelle.Text = "Guncelle";
            btnDoktorBilgileriGuncelle.UseVisualStyleBackColor = false;
            // 
            // mtxtDoktorTcKimlikNo
            // 
            mtxtDoktorTcKimlikNo.Location = new Point(217, 69);
            mtxtDoktorTcKimlikNo.Mask = "00000000000";
            mtxtDoktorTcKimlikNo.Name = "mtxtDoktorTcKimlikNo";
            mtxtDoktorTcKimlikNo.ReadOnly = true;
            mtxtDoktorTcKimlikNo.Size = new Size(277, 27);
            mtxtDoktorTcKimlikNo.TabIndex = 78;
            // 
            // txtDoktorAd
            // 
            txtDoktorAd.Location = new Point(217, 102);
            txtDoktorAd.Name = "txtDoktorAd";
            txtDoktorAd.ReadOnly = true;
            txtDoktorAd.Size = new Size(277, 27);
            txtDoktorAd.TabIndex = 79;
            // 
            // txtDoktorSoyad
            // 
            txtDoktorSoyad.Location = new Point(217, 135);
            txtDoktorSoyad.Name = "txtDoktorSoyad";
            txtDoktorSoyad.ReadOnly = true;
            txtDoktorSoyad.Size = new Size(277, 27);
            txtDoktorSoyad.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 105);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 91;
            label2.Text = "Ad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 138);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 92;
            label3.Text = "Soyad :";
            // 
            // mtxtDoktorCepTelefonu
            // 
            mtxtDoktorCepTelefonu.Location = new Point(217, 231);
            mtxtDoktorCepTelefonu.Mask = "(999) 000-0000";
            mtxtDoktorCepTelefonu.Name = "mtxtDoktorCepTelefonu";
            mtxtDoktorCepTelefonu.Size = new Size(277, 27);
            mtxtDoktorCepTelefonu.TabIndex = 85;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 72);
            label4.Name = "label4";
            label4.Size = new Size(39, 21);
            label4.TabIndex = 93;
            label4.Text = "TC :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 234);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 96;
            label7.Text = "Cep Tel :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(63, 171);
            label9.Name = "label9";
            label9.Size = new Size(120, 21);
            label9.TabIndex = 98;
            label9.Text = "Doğum Tarihi :";
            // 
            // txtDoktorKullaniciAdi
            // 
            txtDoktorKullaniciAdi.Location = new Point(217, 36);
            txtDoktorKullaniciAdi.Name = "txtDoktorKullaniciAdi";
            txtDoktorKullaniciAdi.ReadOnly = true;
            txtDoktorKullaniciAdi.Size = new Size(277, 27);
            txtDoktorKullaniciAdi.TabIndex = 103;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 39);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 104;
            label1.Text = "Kullanıcı Adı :";
            // 
            // txtDoktorDogumTarihi
            // 
            txtDoktorDogumTarihi.Location = new Point(217, 168);
            txtDoktorDogumTarihi.Name = "txtDoktorDogumTarihi";
            txtDoktorDogumTarihi.ReadOnly = true;
            txtDoktorDogumTarihi.Size = new Size(277, 27);
            txtDoktorDogumTarihi.TabIndex = 106;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(119, 267);
            label8.Name = "label8";
            label8.Size = new Size(64, 21);
            label8.TabIndex = 108;
            label8.Text = "E-Mail :";
            // 
            // txtDoktorEskiParola
            // 
            txtDoktorEskiParola.Location = new Point(217, 297);
            txtDoktorEskiParola.Name = "txtDoktorEskiParola";
            txtDoktorEskiParola.Size = new Size(277, 27);
            txtDoktorEskiParola.TabIndex = 111;
            txtDoktorEskiParola.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(86, 300);
            label10.Name = "label10";
            label10.Size = new Size(97, 21);
            label10.TabIndex = 110;
            label10.Text = "Eski Parola :";
            // 
            // txtDoktoryYeniParola
            // 
            txtDoktoryYeniParola.Location = new Point(217, 330);
            txtDoktoryYeniParola.Name = "txtDoktoryYeniParola";
            txtDoktoryYeniParola.Size = new Size(277, 27);
            txtDoktoryYeniParola.TabIndex = 113;
            txtDoktoryYeniParola.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(78, 333);
            label11.Name = "label11";
            label11.Size = new Size(105, 21);
            label11.TabIndex = 112;
            label11.Text = "Yeni Parola :";
            // 
            // txtDoktorEmail
            // 
            txtDoktorEmail.Location = new Point(217, 264);
            txtDoktorEmail.Name = "txtDoktorEmail";
            txtDoktorEmail.Size = new Size(277, 27);
            txtDoktorEmail.TabIndex = 109;
            // 
            // txtDoktorEskiParolaTekrar
            // 
            txtDoktorEskiParolaTekrar.Location = new Point(217, 363);
            txtDoktorEskiParolaTekrar.Name = "txtDoktorEskiParolaTekrar";
            txtDoktorEskiParolaTekrar.Size = new Size(277, 27);
            txtDoktorEskiParolaTekrar.TabIndex = 115;
            txtDoktorEskiParolaTekrar.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 366);
            label5.Name = "label5";
            label5.Size = new Size(156, 21);
            label5.TabIndex = 114;
            label5.Text = "Yeni Parola Tekrar :";
            // 
            // btnDoktorBilgileriClose
            // 
            btnDoktorBilgileriClose.BackColor = Color.Transparent;
            btnDoktorBilgileriClose.FlatAppearance.BorderSize = 0;
            btnDoktorBilgileriClose.FlatStyle = FlatStyle.Flat;
            btnDoktorBilgileriClose.ForeColor = Color.White;
            btnDoktorBilgileriClose.Image = (Image)resources.GetObject("btnDoktorBilgileriClose.Image");
            btnDoktorBilgileriClose.Location = new Point(538, 12);
            btnDoktorBilgileriClose.Name = "btnDoktorBilgileriClose";
            btnDoktorBilgileriClose.Size = new Size(30, 30);
            btnDoktorBilgileriClose.TabIndex = 116;
            btnDoktorBilgileriClose.UseVisualStyleBackColor = false;
            btnDoktorBilgileriClose.Click += btnBekleyenHastaClose_Click;
            // 
            // DoktorKullanici
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(580, 497);
            Controls.Add(btnDoktorBilgileriClose);
            Controls.Add(txtDoktorEskiParolaTekrar);
            Controls.Add(label5);
            Controls.Add(txtDoktoryYeniParola);
            Controls.Add(label11);
            Controls.Add(txtDoktorEskiParola);
            Controls.Add(label10);
            Controls.Add(txtDoktorEmail);
            Controls.Add(label8);
            Controls.Add(txtDoktorDogumTarihi);
            Controls.Add(txtDoktorKullaniciAdi);
            Controls.Add(label1);
            Controls.Add(btnDoktorBilgileriGuncelle);
            Controls.Add(mtxtDoktorTcKimlikNo);
            Controls.Add(txtDoktorAd);
            Controls.Add(txtDoktorSoyad);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(mtxtDoktorCepTelefonu);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label9);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoktorKullanici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoktorKullanici";
            Load += DoktorKullanici_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoktorBilgileriGuncelle;
        private MaskedTextBox mtxtDoktorTcKimlikNo;
        private TextBox txtDoktorAd;
        private TextBox txtDoktorSoyad;
        private Label label2;
        private Label label3;
        private MaskedTextBox mtxtDoktorCepTelefonu;
        private Label label4;
        private Label label7;
        private Label label9;
        private TextBox txtDoktorKullaniciAdi;
        private Label label1;
        private TextBox txtDoktorDogumTarihi;
        private Label label8;
        private TextBox txtDoktorEskiParola;
        private Label label10;
        private TextBox txtDoktoryYeniParola;
        private Label label11;
        private TextBox txtDoktorEmail;
        private TextBox txtDoktorEskiParolaTekrar;
        private Label label5;
        private Button btnDoktorBilgileriClose;
    }
}