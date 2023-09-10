namespace HospitalAutomation.WinForm.Forms.YoneticiForms
{
    partial class YoneticiPolikliniklerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiPolikliniklerForm));
            btnYoneticiPolikliniklerExit = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            cmbYoneticiDoktorlar = new ComboBox();
            txtYoneticiKlinikAdı = new TextBox();
            label9 = new Label();
            label3 = new Label();
            btnYoneticiPoliklinikGuncelle = new Button();
            btnYoneticiPoliklinikEkle = new Button();
            btnYoneticiPoliklinikSil = new Button();
            btnYoneticiPoliklinikTemizle = new Button();
            cmbYoneticiDoktorEkle = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnYoneticiPolikliniklerExit
            // 
            btnYoneticiPolikliniklerExit.BackColor = Color.Transparent;
            btnYoneticiPolikliniklerExit.FlatAppearance.BorderSize = 0;
            btnYoneticiPolikliniklerExit.FlatStyle = FlatStyle.Flat;
            btnYoneticiPolikliniklerExit.ForeColor = Color.White;
            btnYoneticiPolikliniklerExit.Image = (Image)resources.GetObject("btnYoneticiPolikliniklerExit.Image");
            btnYoneticiPolikliniklerExit.Location = new Point(449, 9);
            btnYoneticiPolikliniklerExit.Name = "btnYoneticiPolikliniklerExit";
            btnYoneticiPolikliniklerExit.Size = new Size(30, 30);
            btnYoneticiPolikliniklerExit.TabIndex = 20;
            btnYoneticiPolikliniklerExit.UseVisualStyleBackColor = false;
            btnYoneticiPolikliniklerExit.Click += btnYoneticiPolikliniklerExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 32);
            label1.TabIndex = 30;
            label1.Text = "Poliklinik Bilgileri";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(467, 150);
            dataGridView1.TabIndex = 31;
            // 
            // cmbYoneticiDoktorlar
            // 
            cmbYoneticiDoktorlar.FormattingEnabled = true;
            cmbYoneticiDoktorlar.Location = new Point(133, 252);
            cmbYoneticiDoktorlar.Name = "cmbYoneticiDoktorlar";
            cmbYoneticiDoktorlar.Size = new Size(172, 29);
            cmbYoneticiDoktorlar.TabIndex = 206;
            // 
            // txtYoneticiKlinikAdı
            // 
            txtYoneticiKlinikAdı.Location = new Point(133, 219);
            txtYoneticiKlinikAdı.Name = "txtYoneticiKlinikAdı";
            txtYoneticiKlinikAdı.Size = new Size(172, 27);
            txtYoneticiKlinikAdı.TabIndex = 204;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 255);
            label9.Name = "label9";
            label9.Size = new Size(89, 21);
            label9.TabIndex = 201;
            label9.Text = "Doktorlar :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 219);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 196;
            label3.Text = "Klinik Adı :";
            // 
            // btnYoneticiPoliklinikGuncelle
            // 
            btnYoneticiPoliklinikGuncelle.BackColor = Color.Khaki;
            btnYoneticiPoliklinikGuncelle.FlatAppearance.BorderSize = 0;
            btnYoneticiPoliklinikGuncelle.FlatStyle = FlatStyle.Flat;
            btnYoneticiPoliklinikGuncelle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYoneticiPoliklinikGuncelle.ForeColor = Color.White;
            btnYoneticiPoliklinikGuncelle.Location = new Point(173, 369);
            btnYoneticiPoliklinikGuncelle.Name = "btnYoneticiPoliklinikGuncelle";
            btnYoneticiPoliklinikGuncelle.Size = new Size(98, 39);
            btnYoneticiPoliklinikGuncelle.TabIndex = 208;
            btnYoneticiPoliklinikGuncelle.Text = "Güncelle";
            btnYoneticiPoliklinikGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnYoneticiPoliklinikEkle
            // 
            btnYoneticiPoliklinikEkle.BackColor = Color.PaleGreen;
            btnYoneticiPoliklinikEkle.FlatAppearance.BorderSize = 0;
            btnYoneticiPoliklinikEkle.FlatStyle = FlatStyle.Flat;
            btnYoneticiPoliklinikEkle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYoneticiPoliklinikEkle.ForeColor = Color.White;
            btnYoneticiPoliklinikEkle.Location = new Point(277, 369);
            btnYoneticiPoliklinikEkle.Name = "btnYoneticiPoliklinikEkle";
            btnYoneticiPoliklinikEkle.Size = new Size(98, 39);
            btnYoneticiPoliklinikEkle.TabIndex = 209;
            btnYoneticiPoliklinikEkle.Text = "Ekle";
            btnYoneticiPoliklinikEkle.UseVisualStyleBackColor = false;
            // 
            // btnYoneticiPoliklinikSil
            // 
            btnYoneticiPoliklinikSil.BackColor = Color.Maroon;
            btnYoneticiPoliklinikSil.FlatAppearance.BorderSize = 0;
            btnYoneticiPoliklinikSil.FlatStyle = FlatStyle.Flat;
            btnYoneticiPoliklinikSil.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYoneticiPoliklinikSil.ForeColor = Color.White;
            btnYoneticiPoliklinikSil.Location = new Point(381, 369);
            btnYoneticiPoliklinikSil.Name = "btnYoneticiPoliklinikSil";
            btnYoneticiPoliklinikSil.Size = new Size(98, 39);
            btnYoneticiPoliklinikSil.TabIndex = 210;
            btnYoneticiPoliklinikSil.Text = "Sil";
            btnYoneticiPoliklinikSil.UseVisualStyleBackColor = false;
            // 
            // btnYoneticiPoliklinikTemizle
            // 
            btnYoneticiPoliklinikTemizle.BackColor = Color.DarkGray;
            btnYoneticiPoliklinikTemizle.FlatAppearance.BorderSize = 0;
            btnYoneticiPoliklinikTemizle.FlatStyle = FlatStyle.Flat;
            btnYoneticiPoliklinikTemizle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYoneticiPoliklinikTemizle.ForeColor = Color.White;
            btnYoneticiPoliklinikTemizle.Location = new Point(13, 369);
            btnYoneticiPoliklinikTemizle.Name = "btnYoneticiPoliklinikTemizle";
            btnYoneticiPoliklinikTemizle.Size = new Size(98, 39);
            btnYoneticiPoliklinikTemizle.TabIndex = 207;
            btnYoneticiPoliklinikTemizle.Text = "Temizle";
            btnYoneticiPoliklinikTemizle.UseVisualStyleBackColor = false;
            // 
            // cmbYoneticiDoktorEkle
            // 
            cmbYoneticiDoktorEkle.FormattingEnabled = true;
            cmbYoneticiDoktorEkle.Location = new Point(133, 287);
            cmbYoneticiDoktorEkle.Name = "cmbYoneticiDoktorEkle";
            cmbYoneticiDoktorEkle.Size = new Size(172, 29);
            cmbYoneticiDoktorEkle.TabIndex = 212;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 290);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 211;
            label2.Text = "Doktor Ekle :";
            // 
            // YoneticiPolikliniklerForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(496, 424);
            Controls.Add(cmbYoneticiDoktorEkle);
            Controls.Add(label2);
            Controls.Add(btnYoneticiPoliklinikSil);
            Controls.Add(btnYoneticiPoliklinikEkle);
            Controls.Add(btnYoneticiPoliklinikGuncelle);
            Controls.Add(btnYoneticiPoliklinikTemizle);
            Controls.Add(cmbYoneticiDoktorlar);
            Controls.Add(txtYoneticiKlinikAdı);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnYoneticiPolikliniklerExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "YoneticiPolikliniklerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiPolikliniklerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYoneticiPolikliniklerExit;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox cmbYoneticiDoktorlar;
        private TextBox txtYoneticiKlinikAdı;
        private Label label9;
        private Label label3;
        private Button btnYoneticiPoliklinikGuncelle;
        private Button btnYoneticiPoliklinikEkle;
        private Button btnYoneticiPoliklinikSil;
        private Button btnYoneticiPoliklinikTemizle;
        private ComboBox cmbYoneticiDoktorEkle;
        private Label label2;
    }
}