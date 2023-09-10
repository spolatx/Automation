namespace HospitalAutomation.WinForm.Forms.HastaForms
{
    partial class HastaRandevularımForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaRandevularımForm));
            btnHastaRandevularimExit = new Button();
            SuspendLayout();
            // 
            // btnHastaRandevularimExit
            // 
            btnHastaRandevularimExit.BackColor = Color.Transparent;
            btnHastaRandevularimExit.FlatAppearance.BorderSize = 0;
            btnHastaRandevularimExit.FlatStyle = FlatStyle.Flat;
            btnHastaRandevularimExit.ForeColor = Color.White;
            btnHastaRandevularimExit.Image = (Image)resources.GetObject("btnHastaRandevularimExit.Image");
            btnHastaRandevularimExit.Location = new Point(1101, 12);
            btnHastaRandevularimExit.Name = "btnHastaRandevularimExit";
            btnHastaRandevularimExit.Size = new Size(30, 30);
            btnHastaRandevularimExit.TabIndex = 28;
            btnHastaRandevularimExit.UseVisualStyleBackColor = false;
            btnHastaRandevularimExit.Click += btnHastaRandevularimExit_Click;
            // 
            // HastaRandevularımForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1143, 630);
            Controls.Add(btnHastaRandevularimExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "HastaRandevularımForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaRandevularımForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHastaRandevularimExit;
    }
}