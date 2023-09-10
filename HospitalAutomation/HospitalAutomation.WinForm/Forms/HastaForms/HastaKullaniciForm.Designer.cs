namespace HospitalAutomation.WinForm.Forms.HastaForms
{
    partial class HastaKullaniciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKullaniciForm));
            btnHastaKullaniciExit = new Button();
            SuspendLayout();
            // 
            // btnHastaKullaniciExit
            // 
            btnHastaKullaniciExit.BackColor = Color.Transparent;
            btnHastaKullaniciExit.FlatAppearance.BorderSize = 0;
            btnHastaKullaniciExit.FlatStyle = FlatStyle.Flat;
            btnHastaKullaniciExit.ForeColor = Color.White;
            btnHastaKullaniciExit.Image = (Image)resources.GetObject("btnHastaKullaniciExit.Image");
            btnHastaKullaniciExit.Location = new Point(758, 12);
            btnHastaKullaniciExit.Name = "btnHastaKullaniciExit";
            btnHastaKullaniciExit.Size = new Size(30, 30);
            btnHastaKullaniciExit.TabIndex = 27;
            btnHastaKullaniciExit.UseVisualStyleBackColor = false;
            btnHastaKullaniciExit.Click += btnHastaKullaniciExit_Click;
            // 
            // HastaKullaniciForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHastaKullaniciExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HastaKullaniciForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaKullanici";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHastaKullaniciExit;
    }
}