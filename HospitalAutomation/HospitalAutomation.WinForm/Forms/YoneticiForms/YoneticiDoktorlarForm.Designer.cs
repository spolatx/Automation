namespace HospitalAutomation.WinForm.Forms.YoneticiForms
{
    partial class YoneticiDoktorlarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiDoktorlarForm));
            btnYoneticiDoktorExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnYoneticiDoktorExit
            // 
            btnYoneticiDoktorExit.BackColor = Color.Transparent;
            btnYoneticiDoktorExit.FlatAppearance.BorderSize = 0;
            btnYoneticiDoktorExit.FlatStyle = FlatStyle.Flat;
            btnYoneticiDoktorExit.ForeColor = Color.White;
            btnYoneticiDoktorExit.Image = (Image)resources.GetObject("btnYoneticiDoktorExit.Image");
            btnYoneticiDoktorExit.Location = new Point(758, 12);
            btnYoneticiDoktorExit.Name = "btnYoneticiDoktorExit";
            btnYoneticiDoktorExit.Size = new Size(30, 30);
            btnYoneticiDoktorExit.TabIndex = 20;
            btnYoneticiDoktorExit.UseVisualStyleBackColor = false;
            btnYoneticiDoktorExit.Click += btnYoneticiDoktorExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(279, 12);
            label1.Name = "label1";
            label1.Size = new Size(198, 32);
            label1.TabIndex = 29;
            label1.Text = "Doktor Bilgileri";
            // 
            // YoneticiDoktorlarForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnYoneticiDoktorExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "YoneticiDoktorlarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiDoktorlarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYoneticiDoktorExit;
        private Label label1;
    }
}