namespace HospitalAutomation.WinForm.Forms.YoneticiForms
{
    partial class YoneticiNavigationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiNavigationForm));
            btnPoliklinikler = new Button();
            label2 = new Label();
            label1 = new Label();
            btnYoneticiNavigationExit = new Button();
            btnYonetici = new Button();
            btnDoktorlar = new Button();
            btnHastalar = new Button();
            SuspendLayout();
            // 
            // btnPoliklinikler
            // 
            btnPoliklinikler.BackColor = Color.Maroon;
            btnPoliklinikler.FlatAppearance.BorderSize = 0;
            btnPoliklinikler.FlatStyle = FlatStyle.Flat;
            btnPoliklinikler.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPoliklinikler.ForeColor = Color.White;
            btnPoliklinikler.Image = (Image)resources.GetObject("btnPoliklinikler.Image");
            btnPoliklinikler.ImageAlign = ContentAlignment.TopCenter;
            btnPoliklinikler.Location = new Point(524, 102);
            btnPoliklinikler.Name = "btnPoliklinikler";
            btnPoliklinikler.Size = new Size(128, 80);
            btnPoliklinikler.TabIndex = 29;
            btnPoliklinikler.Text = "Poliklinikler";
            btnPoliklinikler.TextAlign = ContentAlignment.BottomCenter;
            btnPoliklinikler.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 66);
            label2.Name = "label2";
            label2.Size = new Size(252, 21);
            label2.TabIndex = 28;
            label2.Text = "Yapmak istediğiniz işlemi seçiniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(273, 8);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 27;
            label1.Text = "Yönetici Paneli";
            // 
            // btnYoneticiNavigationExit
            // 
            btnYoneticiNavigationExit.BackColor = Color.Transparent;
            btnYoneticiNavigationExit.FlatAppearance.BorderSize = 0;
            btnYoneticiNavigationExit.FlatStyle = FlatStyle.Flat;
            btnYoneticiNavigationExit.ForeColor = Color.White;
            btnYoneticiNavigationExit.Image = (Image)resources.GetObject("btnYoneticiNavigationExit.Image");
            btnYoneticiNavigationExit.Location = new Point(678, 12);
            btnYoneticiNavigationExit.Name = "btnYoneticiNavigationExit";
            btnYoneticiNavigationExit.Size = new Size(30, 30);
            btnYoneticiNavigationExit.TabIndex = 26;
            btnYoneticiNavigationExit.UseVisualStyleBackColor = false;
            btnYoneticiNavigationExit.Click += btnYoneticiNavigationExit_Click;
            // 
            // btnYonetici
            // 
            btnYonetici.BackColor = Color.Maroon;
            btnYonetici.FlatAppearance.BorderSize = 0;
            btnYonetici.FlatStyle = FlatStyle.Flat;
            btnYonetici.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYonetici.ForeColor = Color.White;
            btnYonetici.Image = (Image)resources.GetObject("btnYonetici.Image");
            btnYonetici.ImageAlign = ContentAlignment.TopCenter;
            btnYonetici.Location = new Point(122, 102);
            btnYonetici.Name = "btnYonetici";
            btnYonetici.Size = new Size(128, 80);
            btnYonetici.TabIndex = 23;
            btnYonetici.Text = "Yönetici";
            btnYonetici.TextAlign = ContentAlignment.BottomCenter;
            btnYonetici.UseVisualStyleBackColor = false;
            // 
            // btnDoktorlar
            // 
            btnDoktorlar.BackColor = Color.Maroon;
            btnDoktorlar.FlatAppearance.BorderSize = 0;
            btnDoktorlar.FlatStyle = FlatStyle.Flat;
            btnDoktorlar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoktorlar.ForeColor = Color.White;
            btnDoktorlar.Image = (Image)resources.GetObject("btnDoktorlar.Image");
            btnDoktorlar.ImageAlign = ContentAlignment.TopCenter;
            btnDoktorlar.Location = new Point(390, 102);
            btnDoktorlar.Name = "btnDoktorlar";
            btnDoktorlar.Size = new Size(128, 80);
            btnDoktorlar.TabIndex = 25;
            btnDoktorlar.Text = "Doktorlar";
            btnDoktorlar.TextAlign = ContentAlignment.BottomCenter;
            btnDoktorlar.UseVisualStyleBackColor = false;
            // 
            // btnHastalar
            // 
            btnHastalar.BackColor = Color.Maroon;
            btnHastalar.FlatAppearance.BorderSize = 0;
            btnHastalar.FlatStyle = FlatStyle.Flat;
            btnHastalar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHastalar.ForeColor = Color.White;
            btnHastalar.Image = (Image)resources.GetObject("btnHastalar.Image");
            btnHastalar.ImageAlign = ContentAlignment.TopCenter;
            btnHastalar.Location = new Point(256, 102);
            btnHastalar.Name = "btnHastalar";
            btnHastalar.Size = new Size(128, 80);
            btnHastalar.TabIndex = 24;
            btnHastalar.Text = "Hastalar";
            btnHastalar.TextAlign = ContentAlignment.BottomCenter;
            btnHastalar.UseVisualStyleBackColor = false;
            // 
            // YoneticiNavigationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(720, 220);
            Controls.Add(btnPoliklinikler);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnYoneticiNavigationExit);
            Controls.Add(btnYonetici);
            Controls.Add(btnDoktorlar);
            Controls.Add(btnHastalar);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "YoneticiNavigationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiNavigationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPoliklinikler;
        private Label label2;
        private Label label1;
        private Button btnYoneticiNavigationExit;
        private Button btnYonetici;
        private Button btnDoktorlar;
        private Button btnHastalar;
    }
}