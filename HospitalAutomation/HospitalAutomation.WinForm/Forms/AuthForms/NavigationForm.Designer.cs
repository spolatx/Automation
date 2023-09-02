namespace HospitalAutomation.WinForm.Forms.AuthForms
{
    partial class NavigationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationForm));
            btnYonetici = new Button();
            btnDoktor = new Button();
            btnHastaKabul = new Button();
            btnHasta = new Button();
            btnNavigationClose = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
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
            btnYonetici.Location = new Point(371, 104);
            btnYonetici.Name = "btnYonetici";
            btnYonetici.Size = new Size(128, 80);
            btnYonetici.TabIndex = 2;
            btnYonetici.Text = "Yönetici";
            btnYonetici.TextAlign = ContentAlignment.BottomCenter;
            btnYonetici.UseVisualStyleBackColor = false;
            btnYonetici.Click += btnYonetici_Click;
            // 
            // btnDoktor
            // 
            btnDoktor.BackColor = Color.Maroon;
            btnDoktor.FlatAppearance.BorderSize = 0;
            btnDoktor.FlatStyle = FlatStyle.Flat;
            btnDoktor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoktor.ForeColor = Color.White;
            btnDoktor.Image = (Image)resources.GetObject("btnDoktor.Image");
            btnDoktor.ImageAlign = ContentAlignment.TopCenter;
            btnDoktor.Location = new Point(237, 104);
            btnDoktor.Name = "btnDoktor";
            btnDoktor.Size = new Size(128, 80);
            btnDoktor.TabIndex = 1;
            btnDoktor.Text = "Doktor";
            btnDoktor.TextAlign = ContentAlignment.BottomCenter;
            btnDoktor.UseVisualStyleBackColor = false;
            btnDoktor.Click += btnDoktor_Click;
            // 
            // btnHastaKabul
            // 
            btnHastaKabul.BackColor = Color.Maroon;
            btnHastaKabul.FlatAppearance.BorderSize = 0;
            btnHastaKabul.FlatStyle = FlatStyle.Flat;
            btnHastaKabul.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHastaKabul.ForeColor = Color.White;
            btnHastaKabul.Image = (Image)resources.GetObject("btnHastaKabul.Image");
            btnHastaKabul.ImageAlign = ContentAlignment.TopCenter;
            btnHastaKabul.Location = new Point(505, 104);
            btnHastaKabul.Name = "btnHastaKabul";
            btnHastaKabul.Size = new Size(128, 80);
            btnHastaKabul.TabIndex = 3;
            btnHastaKabul.Text = "Hasta Kabul";
            btnHastaKabul.TextAlign = ContentAlignment.BottomCenter;
            btnHastaKabul.UseVisualStyleBackColor = false;
            btnHastaKabul.Click += btnHastaKabul_Click;
            // 
            // btnHasta
            // 
            btnHasta.BackColor = Color.Maroon;
            btnHasta.FlatAppearance.BorderSize = 0;
            btnHasta.FlatStyle = FlatStyle.Flat;
            btnHasta.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHasta.ForeColor = Color.White;
            btnHasta.Image = (Image)resources.GetObject("btnHasta.Image");
            btnHasta.ImageAlign = ContentAlignment.TopCenter;
            btnHasta.Location = new Point(103, 104);
            btnHasta.Name = "btnHasta";
            btnHasta.Size = new Size(128, 80);
            btnHasta.TabIndex = 0;
            btnHasta.Text = "Hasta";
            btnHasta.TextAlign = ContentAlignment.BottomCenter;
            btnHasta.UseVisualStyleBackColor = false;
            btnHasta.Click += btnHasta_Click;
            // 
            // btnNavigationClose
            // 
            btnNavigationClose.BackColor = Color.Transparent;
            btnNavigationClose.FlatAppearance.BorderSize = 0;
            btnNavigationClose.FlatStyle = FlatStyle.Flat;
            btnNavigationClose.ForeColor = Color.White;
            btnNavigationClose.Image = (Image)resources.GetObject("btnNavigationClose.Image");
            btnNavigationClose.Location = new Point(12, 12);
            btnNavigationClose.Name = "btnNavigationClose";
            btnNavigationClose.Size = new Size(30, 30);
            btnNavigationClose.TabIndex = 12;
            btnNavigationClose.UseVisualStyleBackColor = false;
            btnNavigationClose.Click += btnNavigationClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(134, 12);
            label1.Name = "label1";
            label1.Size = new Size(478, 32);
            label1.TabIndex = 13;
            label1.Text = "Hastane Uygulamasına Hoşgeldiniz.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 71);
            label2.Name = "label2";
            label2.Size = new Size(252, 21);
            label2.TabIndex = 14;
            label2.Text = "Yapmak istediğiniz işlemi seçiniz";
            // 
            // NavigationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(722, 219);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNavigationClose);
            Controls.Add(btnHasta);
            Controls.Add(btnHastaKabul);
            Controls.Add(btnDoktor);
            Controls.Add(btnYonetici);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NavigationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NavigationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYonetici;
        private Button btnDoktor;
        private Button btnHastaKabul;
        private Button btnHasta;
        private Button btnNavigationClose;
        private Label label1;
        private Label label2;
    }
}