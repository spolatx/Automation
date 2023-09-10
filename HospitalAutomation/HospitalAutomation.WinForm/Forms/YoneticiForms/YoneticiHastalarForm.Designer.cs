namespace HospitalAutomation.WinForm.Forms.YoneticiForms
{
    partial class YoneticiHastalarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiHastalarForm));
            btnYoneticiHastaExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnYoneticiHastaExit
            // 
            btnYoneticiHastaExit.BackColor = Color.Transparent;
            btnYoneticiHastaExit.FlatAppearance.BorderSize = 0;
            btnYoneticiHastaExit.FlatStyle = FlatStyle.Flat;
            btnYoneticiHastaExit.ForeColor = Color.White;
            btnYoneticiHastaExit.Image = (Image)resources.GetObject("btnYoneticiHastaExit.Image");
            btnYoneticiHastaExit.Location = new Point(758, 12);
            btnYoneticiHastaExit.Name = "btnYoneticiHastaExit";
            btnYoneticiHastaExit.Size = new Size(30, 30);
            btnYoneticiHastaExit.TabIndex = 20;
            btnYoneticiHastaExit.UseVisualStyleBackColor = false;
            btnYoneticiHastaExit.Click += btnYoneticiHastaExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(295, 12);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 30;
            label1.Text = "Hasta Bilgileri";
            // 
            // YoneticiHastalarForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnYoneticiHastaExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "YoneticiHastalarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiHastalarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYoneticiHastaExit;
        private Label label1;
    }
}