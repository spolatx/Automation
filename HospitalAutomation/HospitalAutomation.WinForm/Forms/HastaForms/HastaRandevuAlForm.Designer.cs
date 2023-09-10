namespace HospitalAutomation.WinForm.Forms.HastaForms
{
    partial class HastaRandevuAlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaRandevuAlForm));
            btnHastaRandevuAlExit = new Button();
            txtHastaTC = new TextBox();
            cmbPoliklinik = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label1 = new Label();
            cmbDoktorlar = new ComboBox();
            label2 = new Label();
            dtpRandevuTarihi = new DateTimePicker();
            label9 = new Label();
            cmbRandevuSaati = new ComboBox();
            label4 = new Label();
            btnRandevuKayit = new Button();
            SuspendLayout();
            // 
            // btnHastaRandevuAlExit
            // 
            btnHastaRandevuAlExit.BackColor = Color.Transparent;
            btnHastaRandevuAlExit.FlatAppearance.BorderSize = 0;
            btnHastaRandevuAlExit.FlatStyle = FlatStyle.Flat;
            btnHastaRandevuAlExit.ForeColor = Color.White;
            btnHastaRandevuAlExit.Image = (Image)resources.GetObject("btnHastaRandevuAlExit.Image");
            btnHastaRandevuAlExit.Location = new Point(466, 12);
            btnHastaRandevuAlExit.Name = "btnHastaRandevuAlExit";
            btnHastaRandevuAlExit.Size = new Size(30, 30);
            btnHastaRandevuAlExit.TabIndex = 28;
            btnHastaRandevuAlExit.UseVisualStyleBackColor = false;
            btnHastaRandevuAlExit.Click += btnHastaRandevuAlExit_Click;
            // 
            // txtHastaTC
            // 
            txtHastaTC.Location = new Point(194, 76);
            txtHastaTC.Name = "txtHastaTC";
            txtHastaTC.ReadOnly = true;
            txtHastaTC.Size = new Size(277, 27);
            txtHastaTC.TabIndex = 70;
            // 
            // cmbPoliklinik
            // 
            cmbPoliklinik.FormattingEnabled = true;
            cmbPoliklinik.Location = new Point(194, 109);
            cmbPoliklinik.Name = "cmbPoliklinik";
            cmbPoliklinik.Size = new Size(277, 29);
            cmbPoliklinik.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 79);
            label3.Name = "label3";
            label3.Size = new Size(39, 21);
            label3.TabIndex = 72;
            label3.Text = "TC :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 112);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 73;
            label5.Text = "Poliklinik :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 10);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 74;
            label1.Text = "Randevu Al";
            // 
            // cmbDoktorlar
            // 
            cmbDoktorlar.FormattingEnabled = true;
            cmbDoktorlar.Location = new Point(194, 144);
            cmbDoktorlar.Name = "cmbDoktorlar";
            cmbDoktorlar.Size = new Size(277, 29);
            cmbDoktorlar.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 147);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 76;
            label2.Text = "Doktor :";
            // 
            // dtpRandevuTarihi
            // 
            dtpRandevuTarihi.Location = new Point(194, 179);
            dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            dtpRandevuTarihi.Size = new Size(277, 27);
            dtpRandevuTarihi.TabIndex = 77;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 184);
            label9.Name = "label9";
            label9.Size = new Size(134, 21);
            label9.TabIndex = 78;
            label9.Text = "Randevu Tarihi :";
            // 
            // cmbRandevuSaati
            // 
            cmbRandevuSaati.FormattingEnabled = true;
            cmbRandevuSaati.Location = new Point(194, 212);
            cmbRandevuSaati.Name = "cmbRandevuSaati";
            cmbRandevuSaati.Size = new Size(277, 29);
            cmbRandevuSaati.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 215);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 80;
            label4.Text = "Saat :";
            // 
            // btnRandevuKayit
            // 
            btnRandevuKayit.BackColor = Color.Maroon;
            btnRandevuKayit.FlatAppearance.BorderSize = 0;
            btnRandevuKayit.FlatStyle = FlatStyle.Flat;
            btnRandevuKayit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRandevuKayit.ForeColor = Color.White;
            btnRandevuKayit.Location = new Point(122, 282);
            btnRandevuKayit.Name = "btnRandevuKayit";
            btnRandevuKayit.Size = new Size(286, 39);
            btnRandevuKayit.TabIndex = 81;
            btnRandevuKayit.Text = "Randevu Al";
            btnRandevuKayit.UseVisualStyleBackColor = false;
            // 
            // HastaRandevuAlForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(508, 353);
            Controls.Add(btnRandevuKayit);
            Controls.Add(cmbRandevuSaati);
            Controls.Add(label4);
            Controls.Add(dtpRandevuTarihi);
            Controls.Add(label9);
            Controls.Add(cmbDoktorlar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHastaTC);
            Controls.Add(cmbPoliklinik);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(btnHastaRandevuAlExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HastaRandevuAlForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaRandevuAlForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHastaRandevuAlExit;
        private TextBox txtHastaTC;
        private ComboBox cmbPoliklinik;
        private Label label3;
        private Label label5;
        private Label label1;
        private ComboBox cmbDoktorlar;
        private Label label2;
        private DateTimePicker dtpRandevuTarihi;
        private Label label9;
        private ComboBox cmbRandevuSaati;
        private Label label4;
        private Button btnRandevuKayit;
    }
}