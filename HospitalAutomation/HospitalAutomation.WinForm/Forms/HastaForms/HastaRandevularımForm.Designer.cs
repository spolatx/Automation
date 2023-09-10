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
            label1 = new Label();
            btnRandevuSil = new Button();
            btnRandevularClose = new Button();
            dgvHastaRandevular = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHastaRandevular).BeginInit();
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(427, 10);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 79;
            label1.Text = "Randevular";
            // 
            // btnRandevuSil
            // 
            btnRandevuSil.BackColor = Color.Maroon;
            btnRandevuSil.FlatAppearance.BorderSize = 0;
            btnRandevuSil.FlatStyle = FlatStyle.Flat;
            btnRandevuSil.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRandevuSil.ForeColor = Color.White;
            btnRandevuSil.Location = new Point(12, 12);
            btnRandevuSil.Name = "btnRandevuSil";
            btnRandevuSil.Size = new Size(69, 39);
            btnRandevuSil.TabIndex = 78;
            btnRandevuSil.Text = "Sil";
            btnRandevuSil.UseVisualStyleBackColor = false;
            // 
            // btnRandevularClose
            // 
            btnRandevularClose.BackColor = Color.Transparent;
            btnRandevularClose.FlatAppearance.BorderSize = 0;
            btnRandevularClose.FlatStyle = FlatStyle.Flat;
            btnRandevularClose.ForeColor = Color.White;
            btnRandevularClose.Image = (Image)resources.GetObject("btnRandevularClose.Image");
            btnRandevularClose.Location = new Point(996, 14);
            btnRandevularClose.Name = "btnRandevularClose";
            btnRandevularClose.Size = new Size(30, 30);
            btnRandevularClose.TabIndex = 76;
            btnRandevularClose.UseVisualStyleBackColor = false;
            btnRandevularClose.Click += btnRandevularClose_Click;
            // 
            // dgvHastaRandevular
            // 
            dgvHastaRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHastaRandevular.Location = new Point(12, 63);
            dgvHastaRandevular.Name = "dgvHastaRandevular";
            dgvHastaRandevular.RowTemplate.Height = 25;
            dgvHastaRandevular.Size = new Size(1014, 159);
            dgvHastaRandevular.TabIndex = 75;
            // 
            // HastaRandevularımForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1038, 234);
            Controls.Add(label1);
            Controls.Add(btnRandevuSil);
            Controls.Add(btnRandevularClose);
            Controls.Add(dgvHastaRandevular);
            Controls.Add(btnHastaRandevularimExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "HastaRandevularımForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaRandevularımForm";
            ((System.ComponentModel.ISupportInitialize)dgvHastaRandevular).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHastaRandevularimExit;
        private Label label1;
        private Button btnRandevuSil;
        private Button btnRandevularClose;
        private DataGridView dgvHastaRandevular;
    }
}