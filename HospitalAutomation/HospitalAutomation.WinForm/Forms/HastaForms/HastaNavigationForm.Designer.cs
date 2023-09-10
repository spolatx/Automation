namespace HospitalAutomation.WinForm.Forms.HastaForms
{
    partial class HastaNavigationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaNavigationForm));
            btnHastaRecetelerim = new Button();
            label2 = new Label();
            label1 = new Label();
            btnHastaNavigationExit = new Button();
            btnHastaKullanici = new Button();
            btnHastaRandevuAl = new Button();
            btnHastaRandevular = new Button();
            SuspendLayout();
            // 
            // btnHastaRecetelerim
            // 
            btnHastaRecetelerim.BackColor = Color.Maroon;
            btnHastaRecetelerim.FlatAppearance.BorderSize = 0;
            btnHastaRecetelerim.FlatStyle = FlatStyle.Flat;
            btnHastaRecetelerim.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnHastaRecetelerim.ForeColor = Color.White;
            btnHastaRecetelerim.Image = (Image)resources.GetObject("btnHastaRecetelerim.Image");
            btnHastaRecetelerim.ImageAlign = ContentAlignment.TopCenter;
            btnHastaRecetelerim.Location = new Point(524, 102);
            btnHastaRecetelerim.Name = "btnHastaRecetelerim";
            btnHastaRecetelerim.Size = new Size(128, 80);
            btnHastaRecetelerim.TabIndex = 29;
            btnHastaRecetelerim.Text = "Reçetelerim";
            btnHastaRecetelerim.TextAlign = ContentAlignment.BottomCenter;
            btnHastaRecetelerim.UseVisualStyleBackColor = false;
            btnHastaRecetelerim.Click += btnHastaRecetelerim_Click;
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
            label1.Size = new Size(174, 32);
            label1.TabIndex = 27;
            label1.Text = "Hasta Paneli";
            // 
            // btnHastaNavigationExit
            // 
            btnHastaNavigationExit.BackColor = Color.Transparent;
            btnHastaNavigationExit.FlatAppearance.BorderSize = 0;
            btnHastaNavigationExit.FlatStyle = FlatStyle.Flat;
            btnHastaNavigationExit.ForeColor = Color.White;
            btnHastaNavigationExit.Image = (Image)resources.GetObject("btnHastaNavigationExit.Image");
            btnHastaNavigationExit.Location = new Point(678, 12);
            btnHastaNavigationExit.Name = "btnHastaNavigationExit";
            btnHastaNavigationExit.Size = new Size(30, 30);
            btnHastaNavigationExit.TabIndex = 26;
            btnHastaNavigationExit.UseVisualStyleBackColor = false;
            btnHastaNavigationExit.Click += btnHastaNavigationExit_Click;
            // 
            // btnHastaKullanici
            // 
            btnHastaKullanici.BackColor = Color.Maroon;
            btnHastaKullanici.FlatAppearance.BorderSize = 0;
            btnHastaKullanici.FlatStyle = FlatStyle.Flat;
            btnHastaKullanici.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHastaKullanici.ForeColor = Color.White;
            btnHastaKullanici.Image = (Image)resources.GetObject("btnHastaKullanici.Image");
            btnHastaKullanici.ImageAlign = ContentAlignment.TopCenter;
            btnHastaKullanici.Location = new Point(122, 102);
            btnHastaKullanici.Name = "btnHastaKullanici";
            btnHastaKullanici.Size = new Size(128, 80);
            btnHastaKullanici.TabIndex = 23;
            btnHastaKullanici.Text = "Kullanıcı";
            btnHastaKullanici.TextAlign = ContentAlignment.BottomCenter;
            btnHastaKullanici.UseVisualStyleBackColor = false;
            btnHastaKullanici.Click += btnHastaKullanici_Click;
            // 
            // btnHastaRandevuAl
            // 
            btnHastaRandevuAl.BackColor = Color.Maroon;
            btnHastaRandevuAl.FlatAppearance.BorderSize = 0;
            btnHastaRandevuAl.FlatStyle = FlatStyle.Flat;
            btnHastaRandevuAl.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnHastaRandevuAl.ForeColor = Color.White;
            btnHastaRandevuAl.Image = (Image)resources.GetObject("btnHastaRandevuAl.Image");
            btnHastaRandevuAl.ImageAlign = ContentAlignment.TopCenter;
            btnHastaRandevuAl.Location = new Point(390, 102);
            btnHastaRandevuAl.Name = "btnHastaRandevuAl";
            btnHastaRandevuAl.Size = new Size(128, 80);
            btnHastaRandevuAl.TabIndex = 25;
            btnHastaRandevuAl.Text = "Randevu Al";
            btnHastaRandevuAl.TextAlign = ContentAlignment.BottomCenter;
            btnHastaRandevuAl.UseVisualStyleBackColor = false;
            btnHastaRandevuAl.Click += btnHastaRandevuAl_Click;
            // 
            // btnHastaRandevular
            // 
            btnHastaRandevular.BackColor = Color.Maroon;
            btnHastaRandevular.FlatAppearance.BorderSize = 0;
            btnHastaRandevular.FlatStyle = FlatStyle.Flat;
            btnHastaRandevular.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHastaRandevular.ForeColor = Color.White;
            btnHastaRandevular.Image = (Image)resources.GetObject("btnHastaRandevular.Image");
            btnHastaRandevular.ImageAlign = ContentAlignment.TopCenter;
            btnHastaRandevular.Location = new Point(256, 102);
            btnHastaRandevular.Name = "btnHastaRandevular";
            btnHastaRandevular.Size = new Size(128, 80);
            btnHastaRandevular.TabIndex = 24;
            btnHastaRandevular.Text = "Randevularım";
            btnHastaRandevular.TextAlign = ContentAlignment.BottomCenter;
            btnHastaRandevular.UseVisualStyleBackColor = false;
            btnHastaRandevular.Click += btnHastaRandevular_Click;
            // 
            // HastaNavigationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(720, 220);
            Controls.Add(btnHastaRecetelerim);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHastaNavigationExit);
            Controls.Add(btnHastaKullanici);
            Controls.Add(btnHastaRandevuAl);
            Controls.Add(btnHastaRandevular);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HastaNavigationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciNavigationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHastaRecetelerim;
        private Label label2;
        private Label label1;
        private Button btnHastaNavigationExit;
        private Button btnHastaKullanici;
        private Button btnHastaRandevuAl;
        private Button btnHastaRandevular;
    }
}