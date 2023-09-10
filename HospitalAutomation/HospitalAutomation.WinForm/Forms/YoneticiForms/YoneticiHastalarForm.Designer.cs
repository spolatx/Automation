namespace HospitalAutomation.WinForm.Forms.YoneticiForms
{
    partial class YoneticiHastalarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiHastalarForm));
            btnYoneticiHastaExit = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            this.mtxtYoneticiHastaBilgileriTc = new MaskedTextBox();
            label12 = new Label();
            this.btnmYoneticiHastaBilgileriTcAra = new Button();
            groupBox1 = new GroupBox();
            this.txtYoneticiHastaBilgileriSoyad = new TextBox();
            this.txtYoneticiHastaEskiParolaTekrar = new TextBox();
            label5 = new Label();
            this.txtYoneticiHastaYeniParola = new TextBox();
            label11 = new Label();
            this.txtYoneticiHastaEskiParola = new TextBox();
            label10 = new Label();
            this.txtYoneticiHastaEmail = new TextBox();
            label8 = new Label();
            this.txtYoneticiHastaKullaniciAdi = new TextBox();
            label2 = new Label();
            this.mtxtYoneticiHastaTcKimlikNo = new MaskedTextBox();
            this.txtYoneticiHastaAd = new TextBox();
            label3 = new Label();
            label4 = new Label();
            this.mtxtYoneticiHastaCepTelefonu = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            this.cmbYoneticiHastaCinsiyet = new ComboBox();
            this.dtpYoneticiHastaDogumTarihi = new DateTimePicker();
            label9 = new Label();
            this.cmbYoneticiHastaDogumYeri = new ComboBox();
            label13 = new Label();
            this.cmbYoneticiHastaKanGrubu = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            this.cmbYoneticiHastaIil = new ComboBox();
            cmbYoneticiHastailce = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            btnYoneticiHastaBilgileriSil = new Button();
            btnYoneticiHastaBilgileriEkle = new Button();
            btnYoneticiHastaBilgileriGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnYoneticiHastaExit
            // 
            btnYoneticiHastaExit.BackColor = Color.Transparent;
            btnYoneticiHastaExit.FlatAppearance.BorderSize = 0;
            btnYoneticiHastaExit.FlatStyle = FlatStyle.Flat;
            btnYoneticiHastaExit.ForeColor = Color.White;
            btnYoneticiHastaExit.Image = (Image)resources.GetObject("btnYoneticiHastaExit.Image");
            btnYoneticiHastaExit.Location = new Point(1012, 12);
            btnYoneticiHastaExit.Name = "btnYoneticiHastaExit";
            btnYoneticiHastaExit.Size = new Size(30, 30);
            btnYoneticiHastaExit.TabIndex = 20;
            btnYoneticiHastaExit.UseVisualStyleBackColor = false;
            btnYoneticiHastaExit.Click += btnYoneticiHastaExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(449, 8);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 30;
            label1.Text = "Hasta Bilgileri";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1030, 153);
            dataGridView1.TabIndex = 31;
            // 
            // mtxtYoneticiHastaBilgileriTc
            // 
            this.mtxtYoneticiHastaBilgileriTc.Location = new Point(85, 47);
            this.mtxtYoneticiHastaBilgileriTc.Mask = "00000000000";
            this.mtxtYoneticiHastaBilgileriTc.Name = "mtxtYoneticiHastaBilgileriTc";
            this.mtxtYoneticiHastaBilgileriTc.Size = new Size(107, 27);
            this.mtxtYoneticiHastaBilgileriTc.TabIndex = 160;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 50);
            label12.Name = "label12";
            label12.Size = new Size(39, 21);
            label12.TabIndex = 161;
            label12.Text = "TC :";
            // 
            // btnmYoneticiHastaBilgileriTcAra
            // 
            this.btnmYoneticiHastaBilgileriTcAra.BackColor = Color.Maroon;
            this.btnmYoneticiHastaBilgileriTcAra.FlatAppearance.BorderSize = 0;
            this.btnmYoneticiHastaBilgileriTcAra.FlatStyle = FlatStyle.Flat;
            this.btnmYoneticiHastaBilgileriTcAra.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnmYoneticiHastaBilgileriTcAra.ForeColor = Color.White;
            this.btnmYoneticiHastaBilgileriTcAra.Location = new Point(210, 47);
            this.btnmYoneticiHastaBilgileriTcAra.Name = "btnmYoneticiHastaBilgileriTcAra";
            this.btnmYoneticiHastaBilgileriTcAra.Size = new Size(112, 27);
            this.btnmYoneticiHastaBilgileriTcAra.TabIndex = 162;
            this.btnmYoneticiHastaBilgileriTcAra.Text = "Ara";
            this.btnmYoneticiHastaBilgileriTcAra.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.cmbYoneticiHastaIil);
            groupBox1.Controls.Add(cmbYoneticiHastailce);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(this.cmbYoneticiHastaCinsiyet);
            groupBox1.Controls.Add(this.dtpYoneticiHastaDogumTarihi);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(this.cmbYoneticiHastaDogumYeri);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(this.cmbYoneticiHastaKanGrubu);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(this.txtYoneticiHastaBilgileriSoyad);
            groupBox1.Controls.Add(this.txtYoneticiHastaEskiParolaTekrar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(this.txtYoneticiHastaYeniParola);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(this.txtYoneticiHastaEskiParola);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(this.txtYoneticiHastaEmail);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(this.txtYoneticiHastaKullaniciAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(this.mtxtYoneticiHastaTcKimlikNo);
            groupBox1.Controls.Add(this.txtYoneticiHastaAd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(this.mtxtYoneticiHastaCepTelefonu);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(12, 239);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1030, 342);
            groupBox1.TabIndex = 163;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtYoneticiHastaBilgileriSoyad
            // 
            this.txtYoneticiHastaBilgileriSoyad.Location = new Point(333, 131);
            this.txtYoneticiHastaBilgileriSoyad.Name = "txtYoneticiHastaBilgileriSoyad";
            this.txtYoneticiHastaBilgileriSoyad.Size = new Size(153, 27);
            this.txtYoneticiHastaBilgileriSoyad.TabIndex = 178;
            // 
            // txtYoneticiHastaEskiParolaTekrar
            // 
            this.txtYoneticiHastaEskiParolaTekrar.Location = new Point(726, 274);
            this.txtYoneticiHastaEskiParolaTekrar.Name = "txtYoneticiHastaEskiParolaTekrar";
            this.txtYoneticiHastaEskiParolaTekrar.Size = new Size(153, 27);
            this.txtYoneticiHastaEskiParolaTekrar.TabIndex = 177;
            this.txtYoneticiHastaEskiParolaTekrar.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(536, 277);
            label5.Name = "label5";
            label5.Size = new Size(156, 21);
            label5.TabIndex = 176;
            label5.Text = "Yeni Parola Tekrar :";
            // 
            // txtYoneticiHastaYeniParola
            // 
            this.txtYoneticiHastaYeniParola.Location = new Point(726, 241);
            this.txtYoneticiHastaYeniParola.Name = "txtYoneticiHastaYeniParola";
            this.txtYoneticiHastaYeniParola.Size = new Size(153, 27);
            this.txtYoneticiHastaYeniParola.TabIndex = 175;
            this.txtYoneticiHastaYeniParola.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(587, 244);
            label11.Name = "label11";
            label11.Size = new Size(105, 21);
            label11.TabIndex = 174;
            label11.Text = "Yeni Parola :";
            // 
            // txtYoneticiHastaEskiParola
            // 
            this.txtYoneticiHastaEskiParola.Location = new Point(726, 208);
            this.txtYoneticiHastaEskiParola.Name = "txtYoneticiHastaEskiParola";
            this.txtYoneticiHastaEskiParola.Size = new Size(153, 27);
            this.txtYoneticiHastaEskiParola.TabIndex = 173;
            this.txtYoneticiHastaEskiParola.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(595, 211);
            label10.Name = "label10";
            label10.Size = new Size(97, 21);
            label10.TabIndex = 172;
            label10.Text = "Eski Parola :";
            // 
            // txtYoneticiHastaEmail
            // 
            this.txtYoneticiHastaEmail.Location = new Point(726, 65);
            this.txtYoneticiHastaEmail.Name = "txtYoneticiHastaEmail";
            this.txtYoneticiHastaEmail.Size = new Size(153, 27);
            this.txtYoneticiHastaEmail.TabIndex = 171;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(628, 68);
            label8.Name = "label8";
            label8.Size = new Size(64, 21);
            label8.TabIndex = 170;
            label8.Text = "E-Mail :";
            // 
            // txtYoneticiHastaKullaniciAdi
            // 
            this.txtYoneticiHastaKullaniciAdi.Location = new Point(333, 32);
            this.txtYoneticiHastaKullaniciAdi.Name = "txtYoneticiHastaKullaniciAdi";
            this.txtYoneticiHastaKullaniciAdi.Size = new Size(153, 27);
            this.txtYoneticiHastaKullaniciAdi.TabIndex = 168;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 35);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 169;
            label2.Text = "Kullanıcı Adı :";
            // 
            // mtxtYoneticiHastaTcKimlikNo
            // 
            this.mtxtYoneticiHastaTcKimlikNo.Location = new Point(333, 65);
            this.mtxtYoneticiHastaTcKimlikNo.Mask = "00000000000";
            this.mtxtYoneticiHastaTcKimlikNo.Name = "mtxtYoneticiHastaTcKimlikNo";
            this.mtxtYoneticiHastaTcKimlikNo.Size = new Size(153, 27);
            this.mtxtYoneticiHastaTcKimlikNo.TabIndex = 160;
            // 
            // txtYoneticiHastaAd
            // 
            this.txtYoneticiHastaAd.Location = new Point(333, 98);
            this.txtYoneticiHastaAd.Name = "txtYoneticiHastaAd";
            this.txtYoneticiHastaAd.Size = new Size(153, 27);
            this.txtYoneticiHastaAd.TabIndex = 161;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 101);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 163;
            label3.Text = "Ad :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 134);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 164;
            label4.Text = "Soyad :";
            // 
            // mtxtYoneticiHastaCepTelefonu
            // 
            this.mtxtYoneticiHastaCepTelefonu.Location = new Point(726, 32);
            this.mtxtYoneticiHastaCepTelefonu.Mask = "(999) 000-0000";
            this.mtxtYoneticiHastaCepTelefonu.Name = "mtxtYoneticiHastaCepTelefonu";
            this.mtxtYoneticiHastaCepTelefonu.Size = new Size(153, 27);
            this.mtxtYoneticiHastaCepTelefonu.TabIndex = 162;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, 68);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 165;
            label6.Text = "TC :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(615, 35);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 166;
            label7.Text = "Cep Tel :";
            // 
            // cmbYoneticiHastaCinsiyet
            // 
            this.cmbYoneticiHastaCinsiyet.FormattingEnabled = true;
            this.cmbYoneticiHastaCinsiyet.Location = new Point(333, 170);
            this.cmbYoneticiHastaCinsiyet.Name = "cmbYoneticiHastaCinsiyet";
            this.cmbYoneticiHastaCinsiyet.Size = new Size(153, 29);
            this.cmbYoneticiHastaCinsiyet.TabIndex = 179;
            // 
            // dtpYoneticiHastaDogumTarihi
            // 
            this.dtpYoneticiHastaDogumTarihi.Location = new Point(333, 275);
            this.dtpYoneticiHastaDogumTarihi.Name = "dtpYoneticiHastaDogumTarihi";
            this.dtpYoneticiHastaDogumTarihi.Size = new Size(153, 27);
            this.dtpYoneticiHastaDogumTarihi.TabIndex = 182;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(229, 173);
            label9.Name = "label9";
            label9.Size = new Size(81, 21);
            label9.TabIndex = 183;
            label9.Text = "Cinsiyeti :";
            // 
            // cmbYoneticiHastaDogumYeri
            // 
            this.cmbYoneticiHastaDogumYeri.FormattingEnabled = true;
            this.cmbYoneticiHastaDogumYeri.Location = new Point(333, 240);
            this.cmbYoneticiHastaDogumYeri.Name = "cmbYoneticiHastaDogumYeri";
            this.cmbYoneticiHastaDogumYeri.Size = new Size(153, 29);
            this.cmbYoneticiHastaDogumYeri.TabIndex = 181;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(208, 208);
            label13.Name = "label13";
            label13.Size = new Size(102, 21);
            label13.TabIndex = 184;
            label13.Text = "Kan Grubu :";
            // 
            // cmbYoneticiHastaKanGrubu
            // 
            this.cmbYoneticiHastaKanGrubu.FormattingEnabled = true;
            this.cmbYoneticiHastaKanGrubu.Location = new Point(333, 205);
            this.cmbYoneticiHastaKanGrubu.Name = "cmbYoneticiHastaKanGrubu";
            this.cmbYoneticiHastaKanGrubu.Size = new Size(153, 29);
            this.cmbYoneticiHastaKanGrubu.TabIndex = 180;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(201, 243);
            label14.Name = "label14";
            label14.Size = new Size(109, 21);
            label14.TabIndex = 186;
            label14.Text = "Doğum Yeri :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(190, 280);
            label15.Name = "label15";
            label15.Size = new Size(120, 21);
            label15.TabIndex = 185;
            label15.Text = "Doğum Tarihi :";
            // 
            // cmbYoneticiHastaIil
            // 
            this.cmbYoneticiHastaIil.FormattingEnabled = true;
            this.cmbYoneticiHastaIil.Location = new Point(726, 98);
            this.cmbYoneticiHastaIil.Name = "cmbYoneticiHastaIil";
            this.cmbYoneticiHastaIil.Size = new Size(153, 29);
            this.cmbYoneticiHastaIil.TabIndex = 187;
            // 
            // cmbYoneticiHastailce
            // 
            cmbYoneticiHastailce.FormattingEnabled = true;
            cmbYoneticiHastailce.Location = new Point(726, 133);
            cmbYoneticiHastailce.Name = "cmbYoneticiHastailce";
            cmbYoneticiHastailce.Size = new Size(153, 29);
            cmbYoneticiHastailce.TabIndex = 188;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(646, 136);
            label16.Name = "label16";
            label16.Size = new Size(46, 21);
            label16.TabIndex = 190;
            label16.Text = "İlçe :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(666, 101);
            label17.Name = "label17";
            label17.Size = new Size(26, 21);
            label17.TabIndex = 189;
            label17.Text = "İl :";
            // 
            // btnYoneticiHastaBilgileriSil
            // 
            btnYoneticiHastaBilgileriSil.BackColor = Color.Maroon;
            btnYoneticiHastaBilgileriSil.FlatAppearance.BorderSize = 0;
            btnYoneticiHastaBilgileriSil.FlatStyle = FlatStyle.Flat;
            btnYoneticiHastaBilgileriSil.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYoneticiHastaBilgileriSil.ForeColor = Color.White;
            btnYoneticiHastaBilgileriSil.Location = new Point(641, 587);
            btnYoneticiHastaBilgileriSil.Name = "btnYoneticiHastaBilgileriSil";
            btnYoneticiHastaBilgileriSil.Size = new Size(98, 39);
            btnYoneticiHastaBilgileriSil.TabIndex = 166;
            btnYoneticiHastaBilgileriSil.Text = "Sil";
            btnYoneticiHastaBilgileriSil.UseVisualStyleBackColor = false;
            // 
            // btnYoneticiHastaBilgileriEkle
            // 
            btnYoneticiHastaBilgileriEkle.BackColor = Color.PaleGreen;
            btnYoneticiHastaBilgileriEkle.FlatAppearance.BorderSize = 0;
            btnYoneticiHastaBilgileriEkle.FlatStyle = FlatStyle.Flat;
            btnYoneticiHastaBilgileriEkle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYoneticiHastaBilgileriEkle.ForeColor = Color.White;
            btnYoneticiHastaBilgileriEkle.Location = new Point(537, 587);
            btnYoneticiHastaBilgileriEkle.Name = "btnYoneticiHastaBilgileriEkle";
            btnYoneticiHastaBilgileriEkle.Size = new Size(98, 39);
            btnYoneticiHastaBilgileriEkle.TabIndex = 165;
            btnYoneticiHastaBilgileriEkle.Text = "Ekle";
            btnYoneticiHastaBilgileriEkle.UseVisualStyleBackColor = false;
            // 
            // btnYoneticiHastaBilgileriGuncelle
            // 
            btnYoneticiHastaBilgileriGuncelle.BackColor = Color.Khaki;
            btnYoneticiHastaBilgileriGuncelle.FlatAppearance.BorderSize = 0;
            btnYoneticiHastaBilgileriGuncelle.FlatStyle = FlatStyle.Flat;
            btnYoneticiHastaBilgileriGuncelle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYoneticiHastaBilgileriGuncelle.ForeColor = Color.White;
            btnYoneticiHastaBilgileriGuncelle.Location = new Point(433, 587);
            btnYoneticiHastaBilgileriGuncelle.Name = "btnYoneticiHastaBilgileriGuncelle";
            btnYoneticiHastaBilgileriGuncelle.Size = new Size(98, 39);
            btnYoneticiHastaBilgileriGuncelle.TabIndex = 164;
            btnYoneticiHastaBilgileriGuncelle.Text = "Güncelle";
            btnYoneticiHastaBilgileriGuncelle.UseVisualStyleBackColor = false;
            // 
            // YoneticiHastalarForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1054, 638);
            Controls.Add(btnYoneticiHastaBilgileriSil);
            Controls.Add(btnYoneticiHastaBilgileriEkle);
            Controls.Add(btnYoneticiHastaBilgileriGuncelle);
            Controls.Add(groupBox1);
            Controls.Add(this.btnmYoneticiHastaBilgileriTcAra);
            Controls.Add(this.mtxtYoneticiHastaBilgileriTc);
            Controls.Add(label12);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnYoneticiHastaExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "YoneticiHastalarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiHastalarForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYoneticiHastaExit;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnHastaBilgileriGuncelle;
        private MaskedTextBox maskedTextBox1;
        private Label label12;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private TextBox txtHastaEskiParolaTekrar;
        private Label label5;
        private TextBox txtHastaYeniParola;
        private Label label11;
        private TextBox txtHastaEskiParola;
        private Label label10;
        private TextBox txtHastaEmail;
        private Label label8;
        private TextBox txtHastaKullaniciAdi;
        private Label label2;
        private MaskedTextBox mtxtHastaTcKimlikNo;
        private TextBox txtHastaAd;
        private Label label3;
        private Label label4;
        private MaskedTextBox mtxtHastaCepTelefonu;
        private Label label6;
        private Label label7;
        private ComboBox cmbHastaCinsiyet;
        private DateTimePicker dtpHastaDogumTarihi;
        private Label label9;
        private ComboBox cmbHastaDogumYeri;
        private Label label13;
        private ComboBox cmbHastaKanGrubu;
        private Label label14;
        private Label label15;
        private Button button2;
        private ComboBox cmbHastaIl;
        private ComboBox cmbYoneticiHastailce;
        private Label label16;
        private Label label17;
        private Button btnYoneticiHastaBilgileriSil;
        private Button btnYoneticiHastaBilgileriEkle;
        private Button btnYoneticiHastaBilgileriGuncelle;
    }
}