namespace HospitalAutomation.WinForm.Forms.DoktorForms
{
    partial class DoktorMuayeneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorMuayeneForm));
            mtxtDoktorMuayeneHastaTcKimlikNo = new MaskedTextBox();
            txtDoktorMuayeneHastaAd = new TextBox();
            txtDoktorMuayeneHastaSoyad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label13 = new Label();
            label9 = new Label();
            label1 = new Label();
            btnDoktorMuayeneClose = new Button();
            txtDoktorMuayeneHastaId = new TextBox();
            label17 = new Label();
            txtDoktorMuayeneCinsiyet = new TextBox();
            txtDoktorMuayeneKanGrubu = new TextBox();
            txtDoktorMuayeneDogumYeri = new TextBox();
            txtDoktorMuayeneDogumTarihi = new TextBox();
            txtDoktorMuayenePoliklinik = new TextBox();
            txtDoktorMuayeneDoktorAdı = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnTahliliste = new Button();
            btnTanıKoy = new Button();
            tabDoktorMuayene = new TabControl();
            tabDoktorMuayeneTahlil = new TabPage();
            btnTahlilGonder = new Button();
            label14 = new Label();
            lstMuayeneistenenTahliller = new ListBox();
            btnTahlilEkle = new Button();
            cmbMuayeneTahliller = new ComboBox();
            label15 = new Label();
            tabDoktorMuayeneTanı = new TabPage();
            textBox2 = new TextBox();
            label12 = new Label();
            button3 = new Button();
            label11 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox1 = new TextBox();
            tabDoktorMuayene.SuspendLayout();
            tabDoktorMuayeneTahlil.SuspendLayout();
            tabDoktorMuayeneTanı.SuspendLayout();
            SuspendLayout();
            // 
            // mtxtDoktorMuayeneHastaTcKimlikNo
            // 
            mtxtDoktorMuayeneHastaTcKimlikNo.Location = new Point(171, 127);
            mtxtDoktorMuayeneHastaTcKimlikNo.Mask = "00000000000";
            mtxtDoktorMuayeneHastaTcKimlikNo.Name = "mtxtDoktorMuayeneHastaTcKimlikNo";
            mtxtDoktorMuayeneHastaTcKimlikNo.ReadOnly = true;
            mtxtDoktorMuayeneHastaTcKimlikNo.Size = new Size(277, 32);
            mtxtDoktorMuayeneHastaTcKimlikNo.TabIndex = 1;
            // 
            // txtDoktorMuayeneHastaAd
            // 
            txtDoktorMuayeneHastaAd.Location = new Point(171, 160);
            txtDoktorMuayeneHastaAd.Name = "txtDoktorMuayeneHastaAd";
            txtDoktorMuayeneHastaAd.ReadOnly = true;
            txtDoktorMuayeneHastaAd.Size = new Size(277, 32);
            txtDoktorMuayeneHastaAd.TabIndex = 2;
            // 
            // txtDoktorMuayeneHastaSoyad
            // 
            txtDoktorMuayeneHastaSoyad.Location = new Point(171, 193);
            txtDoktorMuayeneHastaSoyad.Name = "txtDoktorMuayeneHastaSoyad";
            txtDoktorMuayeneHastaSoyad.ReadOnly = true;
            txtDoktorMuayeneHastaSoyad.Size = new Size(277, 32);
            txtDoktorMuayeneHastaSoyad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 163);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 96;
            label2.Text = "Ad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 196);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 97;
            label3.Text = "Soyad :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 130);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 98;
            label4.Text = "TC :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 229);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 99;
            label5.Text = "Cinsiyeti :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 264);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 100;
            label6.Text = "Kan Grubu :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(35, 299);
            label13.Name = "label13";
            label13.Size = new Size(134, 23);
            label13.TabIndex = 107;
            label13.Text = "Doğum Yeri :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 336);
            label9.Name = "label9";
            label9.Size = new Size(145, 23);
            label9.TabIndex = 103;
            label9.Text = "Doğum Tarihi :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(481, 8);
            label1.Name = "label1";
            label1.Size = new Size(174, 40);
            label1.TabIndex = 81;
            label1.Text = "Muayene";
            // 
            // btnDoktorMuayeneClose
            // 
            btnDoktorMuayeneClose.BackColor = Color.Transparent;
            btnDoktorMuayeneClose.FlatAppearance.BorderSize = 0;
            btnDoktorMuayeneClose.FlatStyle = FlatStyle.Flat;
            btnDoktorMuayeneClose.ForeColor = Color.White;
            btnDoktorMuayeneClose.Image = (Image)resources.GetObject("btnDoktorMuayeneClose.Image");
            btnDoktorMuayeneClose.Location = new Point(1065, 12);
            btnDoktorMuayeneClose.Name = "btnDoktorMuayeneClose";
            btnDoktorMuayeneClose.Size = new Size(30, 30);
            btnDoktorMuayeneClose.TabIndex = 80;
            btnDoktorMuayeneClose.UseVisualStyleBackColor = false;
            btnDoktorMuayeneClose.Click += btnDoktorMuayeneClose_Click;
            // 
            // txtDoktorMuayeneHastaId
            // 
            txtDoktorMuayeneHastaId.Location = new Point(171, 94);
            txtDoktorMuayeneHastaId.Name = "txtDoktorMuayeneHastaId";
            txtDoktorMuayeneHastaId.ReadOnly = true;
            txtDoktorMuayeneHastaId.Size = new Size(77, 32);
            txtDoktorMuayeneHastaId.TabIndex = 0;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(59, 97);
            label17.Name = "label17";
            label17.Size = new Size(104, 23);
            label17.TabIndex = 110;
            label17.Text = "Hasta ID :";
            // 
            // txtDoktorMuayeneCinsiyet
            // 
            txtDoktorMuayeneCinsiyet.Location = new Point(171, 226);
            txtDoktorMuayeneCinsiyet.Name = "txtDoktorMuayeneCinsiyet";
            txtDoktorMuayeneCinsiyet.ReadOnly = true;
            txtDoktorMuayeneCinsiyet.Size = new Size(277, 32);
            txtDoktorMuayeneCinsiyet.TabIndex = 4;
            // 
            // txtDoktorMuayeneKanGrubu
            // 
            txtDoktorMuayeneKanGrubu.Location = new Point(171, 261);
            txtDoktorMuayeneKanGrubu.Name = "txtDoktorMuayeneKanGrubu";
            txtDoktorMuayeneKanGrubu.ReadOnly = true;
            txtDoktorMuayeneKanGrubu.Size = new Size(277, 32);
            txtDoktorMuayeneKanGrubu.TabIndex = 112;
            // 
            // txtDoktorMuayeneDogumYeri
            // 
            txtDoktorMuayeneDogumYeri.Location = new Point(171, 296);
            txtDoktorMuayeneDogumYeri.Name = "txtDoktorMuayeneDogumYeri";
            txtDoktorMuayeneDogumYeri.ReadOnly = true;
            txtDoktorMuayeneDogumYeri.Size = new Size(277, 32);
            txtDoktorMuayeneDogumYeri.TabIndex = 113;
            // 
            // txtDoktorMuayeneDogumTarihi
            // 
            txtDoktorMuayeneDogumTarihi.Location = new Point(171, 333);
            txtDoktorMuayeneDogumTarihi.Name = "txtDoktorMuayeneDogumTarihi";
            txtDoktorMuayeneDogumTarihi.ReadOnly = true;
            txtDoktorMuayeneDogumTarihi.Size = new Size(277, 32);
            txtDoktorMuayeneDogumTarihi.TabIndex = 114;
            // 
            // txtDoktorMuayenePoliklinik
            // 
            txtDoktorMuayenePoliklinik.Location = new Point(171, 457);
            txtDoktorMuayenePoliklinik.Name = "txtDoktorMuayenePoliklinik";
            txtDoktorMuayenePoliklinik.ReadOnly = true;
            txtDoktorMuayenePoliklinik.Size = new Size(277, 32);
            txtDoktorMuayenePoliklinik.TabIndex = 118;
            // 
            // txtDoktorMuayeneDoktorAdı
            // 
            txtDoktorMuayeneDoktorAdı.Location = new Point(171, 420);
            txtDoktorMuayeneDoktorAdı.Name = "txtDoktorMuayeneDoktorAdı";
            txtDoktorMuayeneDoktorAdı.ReadOnly = true;
            txtDoktorMuayeneDoktorAdı.Size = new Size(277, 32);
            txtDoktorMuayeneDoktorAdı.TabIndex = 117;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 423);
            label7.Name = "label7";
            label7.Size = new Size(85, 23);
            label7.TabIndex = 116;
            label7.Text = "Doktor :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 460);
            label8.Name = "label8";
            label8.Size = new Size(97, 23);
            label8.TabIndex = 115;
            label8.Text = "Poliklinik :";
            // 
            // btnTahliliste
            // 
            btnTahliliste.BackColor = Color.Maroon;
            btnTahliliste.FlatAppearance.BorderSize = 0;
            btnTahliliste.FlatStyle = FlatStyle.Flat;
            btnTahliliste.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTahliliste.ForeColor = Color.White;
            btnTahliliste.Location = new Point(42, 513);
            btnTahliliste.Name = "btnTahliliste";
            btnTahliliste.Size = new Size(196, 39);
            btnTahliliste.TabIndex = 119;
            btnTahliliste.Text = "Tahlil İste";
            btnTahliliste.UseVisualStyleBackColor = false;
            // 
            // btnTanıKoy
            // 
            btnTanıKoy.BackColor = Color.Maroon;
            btnTanıKoy.FlatAppearance.BorderSize = 0;
            btnTanıKoy.FlatStyle = FlatStyle.Flat;
            btnTanıKoy.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTanıKoy.ForeColor = Color.White;
            btnTanıKoy.Location = new Point(252, 513);
            btnTanıKoy.Name = "btnTanıKoy";
            btnTanıKoy.Size = new Size(196, 39);
            btnTanıKoy.TabIndex = 120;
            btnTanıKoy.Text = "Tanı Koy";
            btnTanıKoy.UseVisualStyleBackColor = false;
            // 
            // tabDoktorMuayene
            // 
            tabDoktorMuayene.Controls.Add(tabDoktorMuayeneTahlil);
            tabDoktorMuayene.Controls.Add(tabDoktorMuayeneTanı);
            tabDoktorMuayene.Location = new Point(454, 48);
            tabDoktorMuayene.Name = "tabDoktorMuayene";
            tabDoktorMuayene.SelectedIndex = 0;
            tabDoktorMuayene.Size = new Size(641, 511);
            tabDoktorMuayene.TabIndex = 121;
            // 
            // tabDoktorMuayeneTahlil
            // 
            tabDoktorMuayeneTahlil.Controls.Add(btnTahlilGonder);
            tabDoktorMuayeneTahlil.Controls.Add(label14);
            tabDoktorMuayeneTahlil.Controls.Add(lstMuayeneistenenTahliller);
            tabDoktorMuayeneTahlil.Controls.Add(btnTahlilEkle);
            tabDoktorMuayeneTahlil.Controls.Add(cmbMuayeneTahliller);
            tabDoktorMuayeneTahlil.Controls.Add(label15);
            tabDoktorMuayeneTahlil.Location = new Point(4, 32);
            tabDoktorMuayeneTahlil.Name = "tabDoktorMuayeneTahlil";
            tabDoktorMuayeneTahlil.Padding = new Padding(3);
            tabDoktorMuayeneTahlil.Size = new Size(633, 475);
            tabDoktorMuayeneTahlil.TabIndex = 0;
            tabDoktorMuayeneTahlil.Text = "Tahlil";
            tabDoktorMuayeneTahlil.UseVisualStyleBackColor = true;
            // 
            // btnTahlilGonder
            // 
            btnTahlilGonder.BackColor = Color.Maroon;
            btnTahlilGonder.FlatAppearance.BorderSize = 0;
            btnTahlilGonder.FlatStyle = FlatStyle.Flat;
            btnTahlilGonder.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTahlilGonder.ForeColor = Color.White;
            btnTahlilGonder.Location = new Point(451, 432);
            btnTahlilGonder.Name = "btnTahlilGonder";
            btnTahlilGonder.Size = new Size(176, 39);
            btnTahlilGonder.TabIndex = 75;
            btnTahlilGonder.Text = "Gönder";
            btnTahlilGonder.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(485, 22);
            label14.Name = "label14";
            label14.Size = new Size(165, 23);
            label14.TabIndex = 74;
            label14.Text = "İstenilen Tahliller";
            // 
            // lstMuayeneistenenTahliller
            // 
            lstMuayeneistenenTahliller.FormattingEnabled = true;
            lstMuayeneistenenTahliller.ItemHeight = 23;
            lstMuayeneistenenTahliller.Location = new Point(312, 59);
            lstMuayeneistenenTahliller.Name = "lstMuayeneistenenTahliller";
            lstMuayeneistenenTahliller.Size = new Size(315, 280);
            lstMuayeneistenenTahliller.TabIndex = 73;
            // 
            // btnTahlilEkle
            // 
            btnTahlilEkle.BackColor = Color.Maroon;
            btnTahlilEkle.FlatAppearance.BorderSize = 0;
            btnTahlilEkle.FlatStyle = FlatStyle.Flat;
            btnTahlilEkle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTahlilEkle.ForeColor = Color.White;
            btnTahlilEkle.Location = new Point(210, 11);
            btnTahlilEkle.Name = "btnTahlilEkle";
            btnTahlilEkle.Size = new Size(98, 42);
            btnTahlilEkle.TabIndex = 71;
            btnTahlilEkle.Text = "Tahlil Ekle";
            btnTahlilEkle.UseVisualStyleBackColor = false;
            // 
            // cmbMuayeneTahliller
            // 
            cmbMuayeneTahliller.FormattingEnabled = true;
            cmbMuayeneTahliller.Location = new Point(23, 59);
            cmbMuayeneTahliller.Name = "cmbMuayeneTahliller";
            cmbMuayeneTahliller.Size = new Size(283, 31);
            cmbMuayeneTahliller.TabIndex = 70;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(23, 22);
            label15.Name = "label15";
            label15.Size = new Size(81, 23);
            label15.TabIndex = 72;
            label15.Text = "Tahliller";
            // 
            // tabDoktorMuayeneTanı
            // 
            tabDoktorMuayeneTanı.Controls.Add(textBox2);
            tabDoktorMuayeneTanı.Controls.Add(label12);
            tabDoktorMuayeneTanı.Controls.Add(button3);
            tabDoktorMuayeneTanı.Controls.Add(label11);
            tabDoktorMuayeneTanı.Controls.Add(textBox9);
            tabDoktorMuayeneTanı.Controls.Add(label10);
            tabDoktorMuayeneTanı.Controls.Add(textBox1);
            tabDoktorMuayeneTanı.Location = new Point(4, 29);
            tabDoktorMuayeneTanı.Name = "tabDoktorMuayeneTanı";
            tabDoktorMuayeneTanı.Padding = new Padding(3);
            tabDoktorMuayeneTanı.Size = new Size(633, 478);
            tabDoktorMuayeneTanı.TabIndex = 1;
            tabDoktorMuayeneTanı.Text = "Tanı";
            tabDoktorMuayeneTanı.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(476, 441);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(149, 32);
            textBox2.TabIndex = 122;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(318, 444);
            label12.Name = "label12";
            label12.Size = new Size(191, 23);
            label12.TabIndex = 76;
            label12.Text = "Reçete Numarası :";
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(449, 382);
            button3.Name = "button3";
            button3.Size = new Size(176, 39);
            button3.TabIndex = 75;
            button3.Text = "Gönder";
            button3.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(336, 25);
            label11.Name = "label11";
            label11.Size = new Size(81, 23);
            label11.TabIndex = 74;
            label11.Text = "Reçete";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(336, 49);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(289, 317);
            textBox9.TabIndex = 73;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 25);
            label10.Name = "label10";
            label10.Size = new Size(49, 23);
            label10.TabIndex = 72;
            label10.Text = "Tanı";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 320);
            textBox1.TabIndex = 71;
            // 
            // DoktorMuayeneForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1107, 571);
            Controls.Add(tabDoktorMuayene);
            Controls.Add(btnTanıKoy);
            Controls.Add(btnTahliliste);
            Controls.Add(txtDoktorMuayenePoliklinik);
            Controls.Add(txtDoktorMuayeneDoktorAdı);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtDoktorMuayeneDogumTarihi);
            Controls.Add(txtDoktorMuayeneDogumYeri);
            Controls.Add(txtDoktorMuayeneKanGrubu);
            Controls.Add(txtDoktorMuayeneCinsiyet);
            Controls.Add(txtDoktorMuayeneHastaId);
            Controls.Add(label17);
            Controls.Add(mtxtDoktorMuayeneHastaTcKimlikNo);
            Controls.Add(txtDoktorMuayeneHastaAd);
            Controls.Add(txtDoktorMuayeneHastaSoyad);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(btnDoktorMuayeneClose);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoktorMuayeneForm";
            Text = "DoktorMuayeneForm";
            Load += DoktorMuayeneForm_Load;
            tabDoktorMuayene.ResumeLayout(false);
            tabDoktorMuayeneTahlil.ResumeLayout(false);
            tabDoktorMuayeneTahlil.PerformLayout();
            tabDoktorMuayeneTanı.ResumeLayout(false);
            tabDoktorMuayeneTanı.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox mtxtDoktorMuayeneHastaTcKimlikNo;
        private TextBox txtDoktorMuayeneHastaAd;
        private TextBox txtDoktorMuayeneHastaSoyad;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label13;
        private Label label9;
        private Label label1;
        private Button btnDoktorMuayeneClose;
        private TextBox txtDoktorMuayeneHastaId;
        private Label label17;
        private TextBox txtDoktorMuayeneCinsiyet;
        private TextBox txtDoktorMuayeneKanGrubu;
        private TextBox txtDoktorMuayeneDogumYeri;
        private TextBox txtDoktorMuayeneDogumTarihi;
        private TextBox txtDoktorMuayenePoliklinik;
        private TextBox txtDoktorMuayeneDoktorAdı;
        private Label label7;
        private Label label8;
        private Button btnTahliliste;
        private Button btnTanıKoy;
        private TabControl tabDoktorMuayene;
        private TabPage tabDoktorMuayeneTahlil;
        private TabPage tabDoktorMuayeneTanı;
        private Button btnTahlilGonder;
        private Label label14;
        private ListBox lstMuayeneistenenTahliller;
        private Button btnTahlilEkle;
        private ComboBox cmbMuayeneTahliller;
        private Label label15;
        private TextBox textBox2;
        private Label label12;
        private Button button3;
        private Label label11;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox1;
    }
}