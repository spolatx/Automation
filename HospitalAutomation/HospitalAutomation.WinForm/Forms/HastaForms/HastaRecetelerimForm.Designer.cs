namespace HospitalAutomation.WinForm.Forms.HastaForms
{
    partial class HastaRecetelerimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaRecetelerimForm));
            btnHastaRecetelerimExit = new Button();
            SuspendLayout();
            // 
            // btnHastaRecetelerimExit
            // 
            btnHastaRecetelerimExit.BackColor = Color.Transparent;
            btnHastaRecetelerimExit.FlatAppearance.BorderSize = 0;
            btnHastaRecetelerimExit.FlatStyle = FlatStyle.Flat;
            btnHastaRecetelerimExit.ForeColor = Color.White;
            btnHastaRecetelerimExit.Image = (Image)resources.GetObject("btnHastaRecetelerimExit.Image");
            btnHastaRecetelerimExit.Location = new Point(758, 12);
            btnHastaRecetelerimExit.Name = "btnHastaRecetelerimExit";
            btnHastaRecetelerimExit.Size = new Size(30, 30);
            btnHastaRecetelerimExit.TabIndex = 28;
            btnHastaRecetelerimExit.UseVisualStyleBackColor = false;
            btnHastaRecetelerimExit.Click += btnHastaRecetelerimExit_Click;
            // 
            // HastaRecetelerimForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHastaRecetelerimExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HastaRecetelerimForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaRecetelerimForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHastaRecetelerimExit;
    }
}