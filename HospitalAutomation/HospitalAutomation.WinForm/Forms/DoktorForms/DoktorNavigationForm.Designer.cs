namespace HospitalAutomation.WinForm.Forms.DoktorForms
{
    partial class DoktorNavigationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorNavigationForm));
            label2 = new Label();
            label1 = new Label();
            btnDoktorNavigationExit = new Button();
            btnDoktorKullanici = new Button();
            btnDoktorBekleyenHasta = new Button();
            btnDoktorRandevular = new Button();
            btnDoktorTahlilSonuclari = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 66);
            label2.Name = "label2";
            label2.Size = new Size(252, 21);
            label2.TabIndex = 21;
            label2.Text = "Yapmak istediğiniz işlemi seçiniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(273, 8);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 20;
            label1.Text = "Doktor Paneli";
            // 
            // btnDoktorNavigationExit
            // 
            btnDoktorNavigationExit.BackColor = Color.Transparent;
            btnDoktorNavigationExit.FlatAppearance.BorderSize = 0;
            btnDoktorNavigationExit.FlatStyle = FlatStyle.Flat;
            btnDoktorNavigationExit.ForeColor = Color.White;
            btnDoktorNavigationExit.Image = (Image)resources.GetObject("btnDoktorNavigationExit.Image");
            btnDoktorNavigationExit.Location = new Point(678, 12);
            btnDoktorNavigationExit.Name = "btnDoktorNavigationExit";
            btnDoktorNavigationExit.Size = new Size(30, 30);
            btnDoktorNavigationExit.TabIndex = 19;
            btnDoktorNavigationExit.UseVisualStyleBackColor = false;
            btnDoktorNavigationExit.Click += btnDoktorNavigationClose_Click;
            // 
            // btnDoktorKullanici
            // 
            btnDoktorKullanici.BackColor = Color.Maroon;
            btnDoktorKullanici.FlatAppearance.BorderSize = 0;
            btnDoktorKullanici.FlatStyle = FlatStyle.Flat;
            btnDoktorKullanici.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoktorKullanici.ForeColor = Color.White;
            btnDoktorKullanici.Image = (Image)resources.GetObject("btnDoktorKullanici.Image");
            btnDoktorKullanici.ImageAlign = ContentAlignment.TopCenter;
            btnDoktorKullanici.Location = new Point(122, 102);
            btnDoktorKullanici.Name = "btnDoktorKullanici";
            btnDoktorKullanici.Size = new Size(128, 80);
            btnDoktorKullanici.TabIndex = 15;
            btnDoktorKullanici.Text = "Kullanıcı";
            btnDoktorKullanici.TextAlign = ContentAlignment.BottomCenter;
            btnDoktorKullanici.UseVisualStyleBackColor = false;
            // 
            // btnDoktorBekleyenHasta
            // 
            btnDoktorBekleyenHasta.BackColor = Color.Maroon;
            btnDoktorBekleyenHasta.FlatAppearance.BorderSize = 0;
            btnDoktorBekleyenHasta.FlatStyle = FlatStyle.Flat;
            btnDoktorBekleyenHasta.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoktorBekleyenHasta.ForeColor = Color.White;
            btnDoktorBekleyenHasta.Image = (Image)resources.GetObject("btnDoktorBekleyenHasta.Image");
            btnDoktorBekleyenHasta.ImageAlign = ContentAlignment.TopCenter;
            btnDoktorBekleyenHasta.Location = new Point(390, 102);
            btnDoktorBekleyenHasta.Name = "btnDoktorBekleyenHasta";
            btnDoktorBekleyenHasta.Size = new Size(128, 80);
            btnDoktorBekleyenHasta.TabIndex = 18;
            btnDoktorBekleyenHasta.Text = "Bekleyen Hasta";
            btnDoktorBekleyenHasta.TextAlign = ContentAlignment.BottomCenter;
            btnDoktorBekleyenHasta.UseVisualStyleBackColor = false;
            btnDoktorBekleyenHasta.Click += btnDoktorBekleyenHasta_Click;
            // 
            // btnDoktorRandevular
            // 
            btnDoktorRandevular.BackColor = Color.Maroon;
            btnDoktorRandevular.FlatAppearance.BorderSize = 0;
            btnDoktorRandevular.FlatStyle = FlatStyle.Flat;
            btnDoktorRandevular.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoktorRandevular.ForeColor = Color.White;
            btnDoktorRandevular.Image = (Image)resources.GetObject("btnDoktorRandevular.Image");
            btnDoktorRandevular.ImageAlign = ContentAlignment.TopCenter;
            btnDoktorRandevular.Location = new Point(256, 102);
            btnDoktorRandevular.Name = "btnDoktorRandevular";
            btnDoktorRandevular.Size = new Size(128, 80);
            btnDoktorRandevular.TabIndex = 16;
            btnDoktorRandevular.Text = "Randevularım";
            btnDoktorRandevular.TextAlign = ContentAlignment.BottomCenter;
            btnDoktorRandevular.UseVisualStyleBackColor = false;
            btnDoktorRandevular.Click += btnDoktorRandevular_Click;
            // 
            // btnDoktorTahlilSonuclari
            // 
            btnDoktorTahlilSonuclari.BackColor = Color.Maroon;
            btnDoktorTahlilSonuclari.FlatAppearance.BorderSize = 0;
            btnDoktorTahlilSonuclari.FlatStyle = FlatStyle.Flat;
            btnDoktorTahlilSonuclari.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoktorTahlilSonuclari.ForeColor = Color.White;
            btnDoktorTahlilSonuclari.Image = (Image)resources.GetObject("btnDoktorTahlilSonuclari.Image");
            btnDoktorTahlilSonuclari.ImageAlign = ContentAlignment.TopCenter;
            btnDoktorTahlilSonuclari.Location = new Point(524, 102);
            btnDoktorTahlilSonuclari.Name = "btnDoktorTahlilSonuclari";
            btnDoktorTahlilSonuclari.Size = new Size(128, 80);
            btnDoktorTahlilSonuclari.TabIndex = 22;
            btnDoktorTahlilSonuclari.Text = "Tahlil Sonuçları";
            btnDoktorTahlilSonuclari.TextAlign = ContentAlignment.BottomCenter;
            btnDoktorTahlilSonuclari.UseVisualStyleBackColor = false;
            btnDoktorTahlilSonuclari.Click += btnDoktorTahlilSonuclari_Click;
            // 
            // DoktorNavigationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(720, 220);
            Controls.Add(btnDoktorTahlilSonuclari);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDoktorNavigationExit);
            Controls.Add(btnDoktorKullanici);
            Controls.Add(btnDoktorBekleyenHasta);
            Controls.Add(btnDoktorRandevular);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoktorNavigationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoktorNavigationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnDoktorNavigationExit;
        private Button btnDoktorKullanici;
        private Button btnDoktorBekleyenHasta;
        private Button btnDoktorRandevular;
        private Button btnDoktorTahlilSonuclari;
    }
}