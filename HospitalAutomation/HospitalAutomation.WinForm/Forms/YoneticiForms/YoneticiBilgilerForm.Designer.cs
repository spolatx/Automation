namespace HospitalAutomation.WinForm.Forms.YoneticiForms
{
    partial class YoneticiBilgilerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiBilgilerForm));
            btnYoneticiBilgileriExit = new Button();
            SuspendLayout();
            // 
            // btnYoneticiBilgileriExit
            // 
            btnYoneticiBilgileriExit.BackColor = Color.Transparent;
            btnYoneticiBilgileriExit.FlatAppearance.BorderSize = 0;
            btnYoneticiBilgileriExit.FlatStyle = FlatStyle.Flat;
            btnYoneticiBilgileriExit.ForeColor = Color.White;
            btnYoneticiBilgileriExit.Image = (Image)resources.GetObject("btnYoneticiBilgileriExit.Image");
            btnYoneticiBilgileriExit.Location = new Point(758, 12);
            btnYoneticiBilgileriExit.Name = "btnYoneticiBilgileriExit";
            btnYoneticiBilgileriExit.Size = new Size(30, 30);
            btnYoneticiBilgileriExit.TabIndex = 20;
            btnYoneticiBilgileriExit.UseVisualStyleBackColor = false;
            btnYoneticiBilgileriExit.Click += btnYoneticiBilgileriExit_Click;
            // 
            // YoneticiBilgilerForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnYoneticiBilgileriExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "YoneticiBilgilerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiBilgilerForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnYoneticiBilgileriExit;
    }
}