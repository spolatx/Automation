namespace HospitalAutomation.WinForm.Forms.AuthForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            lblGirisBilgisi = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLoginFormClose = new Button();
            lblinfo = new Label();
            btnLoginFormBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(619, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 383);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblGirisBilgisi
            // 
            lblGirisBilgisi.AutoSize = true;
            lblGirisBilgisi.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblGirisBilgisi.Location = new Point(97, 79);
            lblGirisBilgisi.Name = "lblGirisBilgisi";
            lblGirisBilgisi.Size = new Size(183, 36);
            lblGirisBilgisi.TabIndex = 1;
            lblGirisBilgisi.Text = "Giriş Yapınız";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(214, 149);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(277, 27);
            txtUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Maroon;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(339, 265);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(152, 39);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 152);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Adı :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(214, 194);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(277, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 197);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 4;
            label3.Text = "Şifre :";
            // 
            // btnLoginFormClose
            // 
            btnLoginFormClose.BackColor = Color.Transparent;
            btnLoginFormClose.FlatAppearance.BorderSize = 0;
            btnLoginFormClose.FlatStyle = FlatStyle.Flat;
            btnLoginFormClose.ForeColor = Color.White;
            btnLoginFormClose.Image = (Image)resources.GetObject("btnLoginFormClose.Image");
            btnLoginFormClose.Location = new Point(583, 12);
            btnLoginFormClose.Name = "btnLoginFormClose";
            btnLoginFormClose.Size = new Size(30, 30);
            btnLoginFormClose.TabIndex = 5;
            btnLoginFormClose.UseVisualStyleBackColor = false;
            btnLoginFormClose.Click += btnLoginFormClose_Click;
            // 
            // lblinfo
            // 
            lblinfo.AutoSize = true;
            lblinfo.ForeColor = Color.Red;
            lblinfo.Location = new Point(214, 233);
            lblinfo.Name = "lblinfo";
            lblinfo.Size = new Size(172, 21);
            lblinfo.TabIndex = 6;
            lblinfo.Text = "Kullanıcı Bilgilendirme";
            lblinfo.Visible = false;
            // 
            // btnLoginFormBack
            // 
            btnLoginFormBack.BackColor = Color.Transparent;
            btnLoginFormBack.FlatAppearance.BorderSize = 0;
            btnLoginFormBack.FlatStyle = FlatStyle.Flat;
            btnLoginFormBack.ForeColor = Color.White;
            btnLoginFormBack.Image = (Image)resources.GetObject("btnLoginFormBack.Image");
            btnLoginFormBack.Location = new Point(12, 12);
            btnLoginFormBack.Name = "btnLoginFormBack";
            btnLoginFormBack.Size = new Size(30, 30);
            btnLoginFormBack.TabIndex = 4;
            btnLoginFormBack.UseVisualStyleBackColor = false;
            btnLoginFormBack.Click += btnLoginFormBack_Click;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(999, 383);
            Controls.Add(btnLoginFormBack);
            Controls.Add(lblinfo);
            Controls.Add(btnLoginFormClose);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblGirisBilgisi);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblGirisBilgisi;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLoginFormClose;
        private Label lblinfo;
        private Button btnLoginFormBack;
    }
}