namespace HospitalAutomation.WinForm.Forms.HastaKabulForms
{
    partial class HastaKabulForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKabulForm));
            btnHastaKabulClose = new Button();
            label1 = new Label();
            btnHastaTcSorgula = new Button();
            groupBox1 = new GroupBox();
            label18 = new Label();
            btnHastaPoliklinikKayit = new Button();
            cmbHastaDoktor = new ComboBox();
            label16 = new Label();
            cmbHastaPoliklinik = new ComboBox();
            label15 = new Label();
            btnHastaKayit = new Button();
            mtxtHastaTcKimlikNo = new MaskedTextBox();
            cmbHastaIl = new ComboBox();
            txtHastaAd = new TextBox();
            txtHastaSoyad = new TextBox();
            txtHastaMeslek = new TextBox();
            cmbHastailce = new ComboBox();
            label2 = new Label();
            cmbHastaCinsiyet = new ComboBox();
            mtxtHastaIsTelefonu = new MaskedTextBox();
            label3 = new Label();
            mtxtHastaCepTelefonu = new MaskedTextBox();
            label4 = new Label();
            dtpHastaDogumTarihi = new DateTimePicker();
            label5 = new Label();
            cmbHastaDogumYeri = new ComboBox();
            label6 = new Label();
            cmbHastaKanGrubu = new ComboBox();
            label7 = new Label();
            label13 = new Label();
            label8 = new Label();
            label12 = new Label();
            label9 = new Label();
            label11 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHastaKabulClose
            // 
            btnHastaKabulClose.BackColor = Color.Transparent;
            btnHastaKabulClose.FlatAppearance.BorderSize = 0;
            btnHastaKabulClose.FlatStyle = FlatStyle.Flat;
            btnHastaKabulClose.ForeColor = Color.White;
            btnHastaKabulClose.Image = (Image)resources.GetObject("btnHastaKabulClose.Image");
            btnHastaKabulClose.Location = new Point(1065, 12);
            btnHastaKabulClose.Name = "btnHastaKabulClose";
            btnHastaKabulClose.Size = new Size(30, 30);
            btnHastaKabulClose.TabIndex = 6;
            btnHastaKabulClose.UseVisualStyleBackColor = false;
            btnHastaKabulClose.Click += btnHastaKabulClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(405, 12);
            label1.Name = "label1";
            label1.Size = new Size(337, 40);
            label1.TabIndex = 14;
            label1.Text = "Hasta Kabul Sayfası";
            // 
            // btnHastaTcSorgula
            // 
            btnHastaTcSorgula.BackColor = Color.Maroon;
            btnHastaTcSorgula.FlatAppearance.BorderSize = 0;
            btnHastaTcSorgula.FlatStyle = FlatStyle.Flat;
            btnHastaTcSorgula.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHastaTcSorgula.ForeColor = Color.White;
            btnHastaTcSorgula.Location = new Point(468, 94);
            btnHastaTcSorgula.Name = "btnHastaTcSorgula";
            btnHastaTcSorgula.Size = new Size(97, 27);
            btnHastaTcSorgula.TabIndex = 53;
            btnHastaTcSorgula.Text = "Sorgula";
            btnHastaTcSorgula.UseVisualStyleBackColor = false;
            btnHastaTcSorgula.Click += btnHastaTcSorgula_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(btnHastaPoliklinikKayit);
            groupBox1.Controls.Add(cmbHastaDoktor);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(cmbHastaPoliklinik);
            groupBox1.Controls.Add(label15);
            groupBox1.Location = new Point(613, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 400);
            groupBox1.TabIndex = 78;
            groupBox1.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(158, 36);
            label18.Name = "label18";
            label18.Size = new Size(174, 40);
            label18.TabIndex = 50;
            label18.Text = "Muayene";
            // 
            // btnHastaPoliklinikKayit
            // 
            btnHastaPoliklinikKayit.BackColor = Color.Maroon;
            btnHastaPoliklinikKayit.FlatAppearance.BorderSize = 0;
            btnHastaPoliklinikKayit.FlatStyle = FlatStyle.Flat;
            btnHastaPoliklinikKayit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHastaPoliklinikKayit.ForeColor = Color.White;
            btnHastaPoliklinikKayit.Location = new Point(259, 200);
            btnHastaPoliklinikKayit.Name = "btnHastaPoliklinikKayit";
            btnHastaPoliklinikKayit.Size = new Size(176, 39);
            btnHastaPoliklinikKayit.TabIndex = 16;
            btnHastaPoliklinikKayit.Text = "Muayene Kayıt Et";
            btnHastaPoliklinikKayit.UseVisualStyleBackColor = false;
            btnHastaPoliklinikKayit.Click += btnHastaPoliklinikKayit_Click;
            // 
            // cmbHastaDoktor
            // 
            cmbHastaDoktor.FormattingEnabled = true;
            cmbHastaDoktor.Location = new Point(158, 152);
            cmbHastaDoktor.Name = "cmbHastaDoktor";
            cmbHastaDoktor.Size = new Size(277, 31);
            cmbHastaDoktor.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(39, 155);
            label16.Name = "label16";
            label16.Size = new Size(85, 23);
            label16.TabIndex = 47;
            label16.Text = "Doktor :";
            // 
            // cmbHastaPoliklinik
            // 
            cmbHastaPoliklinik.FormattingEnabled = true;
            cmbHastaPoliklinik.Location = new Point(158, 117);
            cmbHastaPoliklinik.Name = "cmbHastaPoliklinik";
            cmbHastaPoliklinik.Size = new Size(277, 31);
            cmbHastaPoliklinik.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(31, 120);
            label15.Name = "label15";
            label15.Size = new Size(97, 23);
            label15.TabIndex = 45;
            label15.Text = "Poliklinik :";
            // 
            // btnHastaKayit
            // 
            btnHastaKayit.BackColor = Color.Maroon;
            btnHastaKayit.FlatAppearance.BorderSize = 0;
            btnHastaKayit.FlatStyle = FlatStyle.Flat;
            btnHastaKayit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHastaKayit.ForeColor = Color.White;
            btnHastaKayit.Location = new Point(297, 520);
            btnHastaKayit.Name = "btnHastaKayit";
            btnHastaKayit.Size = new Size(152, 39);
            btnHastaKayit.TabIndex = 65;
            btnHastaKayit.Text = "Hasta Kayıt Et";
            btnHastaKayit.UseVisualStyleBackColor = false;
            btnHastaKayit.Click += btnHastaKayit_Click;
            // 
            // mtxtHastaTcKimlikNo
            // 
            mtxtHastaTcKimlikNo.Location = new Point(172, 94);
            mtxtHastaTcKimlikNo.Mask = "00000000000";
            mtxtHastaTcKimlikNo.Name = "mtxtHastaTcKimlikNo";
            mtxtHastaTcKimlikNo.Size = new Size(277, 32);
            mtxtHastaTcKimlikNo.TabIndex = 52;
            // 
            // cmbHastaIl
            // 
            cmbHastaIl.FormattingEnabled = true;
            cmbHastaIl.Location = new Point(172, 430);
            cmbHastaIl.Name = "cmbHastaIl";
            cmbHastaIl.Size = new Size(277, 31);
            cmbHastaIl.TabIndex = 63;
            cmbHastaIl.SelectedIndexChanged += cmbHastaIl_SelectedIndexChanged;
            // 
            // txtHastaAd
            // 
            txtHastaAd.Location = new Point(172, 127);
            txtHastaAd.Name = "txtHastaAd";
            txtHastaAd.Size = new Size(277, 32);
            txtHastaAd.TabIndex = 54;
            // 
            // txtHastaSoyad
            // 
            txtHastaSoyad.Location = new Point(172, 160);
            txtHastaSoyad.Name = "txtHastaSoyad";
            txtHastaSoyad.Size = new Size(277, 32);
            txtHastaSoyad.TabIndex = 55;
            // 
            // txtHastaMeslek
            // 
            txtHastaMeslek.Location = new Point(172, 397);
            txtHastaMeslek.Name = "txtHastaMeslek";
            txtHastaMeslek.Size = new Size(277, 32);
            txtHastaMeslek.TabIndex = 62;
            // 
            // cmbHastailce
            // 
            cmbHastailce.FormattingEnabled = true;
            cmbHastailce.Location = new Point(172, 465);
            cmbHastailce.Name = "cmbHastailce";
            cmbHastailce.Size = new Size(277, 31);
            cmbHastailce.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 130);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 66;
            label2.Text = "Ad :";
            // 
            // cmbHastaCinsiyet
            // 
            cmbHastaCinsiyet.FormattingEnabled = true;
            cmbHastaCinsiyet.Location = new Point(172, 193);
            cmbHastaCinsiyet.Name = "cmbHastaCinsiyet";
            cmbHastaCinsiyet.Size = new Size(277, 31);
            cmbHastaCinsiyet.TabIndex = 56;
            cmbHastaCinsiyet.SelectedIndexChanged += cmbHastaCinsiyet_SelectedIndexChanged;
            // 
            // mtxtHastaIsTelefonu
            // 
            mtxtHastaIsTelefonu.Location = new Point(172, 364);
            mtxtHastaIsTelefonu.Mask = "(999) 000-0000";
            mtxtHastaIsTelefonu.Name = "mtxtHastaIsTelefonu";
            mtxtHastaIsTelefonu.Size = new Size(277, 32);
            mtxtHastaIsTelefonu.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 163);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 67;
            label3.Text = "Soyad :";
            // 
            // mtxtHastaCepTelefonu
            // 
            mtxtHastaCepTelefonu.Location = new Point(172, 331);
            mtxtHastaCepTelefonu.Mask = "(999) 000-0000";
            mtxtHastaCepTelefonu.Name = "mtxtHastaCepTelefonu";
            mtxtHastaCepTelefonu.Size = new Size(277, 32);
            mtxtHastaCepTelefonu.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 97);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 68;
            label4.Text = "TC :";
            // 
            // dtpHastaDogumTarihi
            // 
            dtpHastaDogumTarihi.Location = new Point(172, 298);
            dtpHastaDogumTarihi.Name = "dtpHastaDogumTarihi";
            dtpHastaDogumTarihi.Size = new Size(277, 32);
            dtpHastaDogumTarihi.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 196);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 69;
            label5.Text = "Cinsiyeti :";
            // 
            // cmbHastaDogumYeri
            // 
            cmbHastaDogumYeri.FormattingEnabled = true;
            cmbHastaDogumYeri.Location = new Point(172, 263);
            cmbHastaDogumYeri.Name = "cmbHastaDogumYeri";
            cmbHastaDogumYeri.Size = new Size(277, 31);
            cmbHastaDogumYeri.TabIndex = 58;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 231);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 70;
            label6.Text = "Kan Grubu :";
            // 
            // cmbHastaKanGrubu
            // 
            cmbHastaKanGrubu.FormattingEnabled = true;
            cmbHastaKanGrubu.Location = new Point(172, 228);
            cmbHastaKanGrubu.Name = "cmbHastaKanGrubu";
            cmbHastaKanGrubu.Size = new Size(277, 31);
            cmbHastaKanGrubu.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 334);
            label7.Name = "label7";
            label7.Size = new Size(96, 23);
            label7.TabIndex = 71;
            label7.Text = "Cep Tel :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(40, 266);
            label13.Name = "label13";
            label13.Size = new Size(134, 23);
            label13.TabIndex = 77;
            label13.Text = "Doğum Yeri :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(95, 367);
            label8.Name = "label8";
            label8.Size = new Size(66, 23);
            label8.TabIndex = 72;
            label8.Text = "İş Tel :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(103, 468);
            label12.Name = "label12";
            label12.Size = new Size(57, 23);
            label12.TabIndex = 76;
            label12.Text = "İlçe :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 303);
            label9.Name = "label9";
            label9.Size = new Size(145, 23);
            label9.TabIndex = 73;
            label9.Text = "Doğum Tarihi :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(123, 433);
            label11.Name = "label11";
            label11.Size = new Size(31, 23);
            label11.TabIndex = 75;
            label11.Text = "İl :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(79, 400);
            label10.Name = "label10";
            label10.Size = new Size(87, 23);
            label10.TabIndex = 74;
            label10.Text = "Meslek :";
            // 
            // HastaKabulForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1107, 596);
            Controls.Add(btnHastaTcSorgula);
            Controls.Add(groupBox1);
            Controls.Add(btnHastaKayit);
            Controls.Add(mtxtHastaTcKimlikNo);
            Controls.Add(cmbHastaIl);
            Controls.Add(txtHastaAd);
            Controls.Add(txtHastaSoyad);
            Controls.Add(txtHastaMeslek);
            Controls.Add(cmbHastailce);
            Controls.Add(label2);
            Controls.Add(cmbHastaCinsiyet);
            Controls.Add(mtxtHastaIsTelefonu);
            Controls.Add(label3);
            Controls.Add(mtxtHastaCepTelefonu);
            Controls.Add(label4);
            Controls.Add(dtpHastaDogumTarihi);
            Controls.Add(label5);
            Controls.Add(cmbHastaDogumYeri);
            Controls.Add(label6);
            Controls.Add(cmbHastaKanGrubu);
            Controls.Add(label7);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(btnHastaKabulClose);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HastaKabulForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaKabulForm";
            Load += HastaKabulForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnHastaKabulClose;
        private Label label1;
        private Button btnHastaTcSorgula;
        private GroupBox groupBox1;
        private Label label18;
        private Button btnHastaPoliklinikKayit;
        private ComboBox cmbHastaDoktor;
        private Label label16;
        private ComboBox cmbHastaPoliklinik;
        private Label label15;
        private Button btnHastaKayit;
        private MaskedTextBox mtxtHastaTcKimlikNo;
        private ComboBox cmbHastaIl;
        private TextBox txtHastaAd;
        private TextBox txtHastaSoyad;
        private TextBox txtHastaMeslek;
        private ComboBox cmbHastailce;
        private Label label2;
        private ComboBox cmbHastaCinsiyet;
        private MaskedTextBox mtxtHastaIsTelefonu;
        private Label label3;
        private MaskedTextBox mtxtHastaCepTelefonu;
        private Label label4;
        private DateTimePicker dtpHastaDogumTarihi;
        private Label label5;
        private ComboBox cmbHastaDogumYeri;
        private Label label6;
        private ComboBox cmbHastaKanGrubu;
        private Label label7;
        private Label label13;
        private Label label8;
        private Label label12;
        private Label label9;
        private Label label11;
        private Label label10;
    }
}