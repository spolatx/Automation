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
            SuspendLayout();
            // 
            // btnHastaRandevuAlExit
            // 
            btnHastaRandevuAlExit.BackColor = Color.Transparent;
            btnHastaRandevuAlExit.FlatAppearance.BorderSize = 0;
            btnHastaRandevuAlExit.FlatStyle = FlatStyle.Flat;
            btnHastaRandevuAlExit.ForeColor = Color.White;
            btnHastaRandevuAlExit.Image = (Image)resources.GetObject("btnHastaRandevuAlExit.Image");
            btnHastaRandevuAlExit.Location = new Point(758, 12);
            btnHastaRandevuAlExit.Name = "btnHastaRandevuAlExit";
            btnHastaRandevuAlExit.Size = new Size(30, 30);
            btnHastaRandevuAlExit.TabIndex = 28;
            btnHastaRandevuAlExit.UseVisualStyleBackColor = false;
            btnHastaRandevuAlExit.Click += btnHastaRandevuAlExit_Click;
            // 
            // HastaRandevuAlForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHastaRandevuAlExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HastaRandevuAlForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaRandevuAlForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHastaRandevuAlExit;
    }
}