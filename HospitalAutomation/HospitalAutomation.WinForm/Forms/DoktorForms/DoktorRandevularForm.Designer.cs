namespace HospitalAutomation.WinForm.Forms.DoktorForms
{
    partial class DoktorRandevularForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorRandevularForm));
            btnRandevuSec = new Button();
            btnRandevularClose = new Button();
            dgvRandevular = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRandevular).BeginInit();
            SuspendLayout();
            // 
            // btnRandevuSec
            // 
            btnRandevuSec.BackColor = Color.Maroon;
            btnRandevuSec.FlatAppearance.BorderSize = 0;
            btnRandevuSec.FlatStyle = FlatStyle.Flat;
            btnRandevuSec.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRandevuSec.ForeColor = Color.White;
            btnRandevuSec.Location = new Point(12, 12);
            btnRandevuSec.Name = "btnRandevuSec";
            btnRandevuSec.Size = new Size(71, 39);
            btnRandevuSec.TabIndex = 72;
            btnRandevuSec.Text = "Seç";
            btnRandevuSec.UseVisualStyleBackColor = false;
            btnRandevuSec.Click += btnRandevuSec_Click;
            // 
            // btnRandevularClose
            // 
            btnRandevularClose.BackColor = Color.Transparent;
            btnRandevularClose.FlatAppearance.BorderSize = 0;
            btnRandevularClose.FlatStyle = FlatStyle.Flat;
            btnRandevularClose.ForeColor = Color.White;
            btnRandevularClose.Image = (Image)resources.GetObject("btnRandevularClose.Image");
            btnRandevularClose.Location = new Point(996, 12);
            btnRandevularClose.Name = "btnRandevularClose";
            btnRandevularClose.Size = new Size(30, 30);
            btnRandevularClose.TabIndex = 71;
            btnRandevularClose.UseVisualStyleBackColor = false;
            btnRandevularClose.Click += btnRandevularClose_Click;
            // 
            // dgvRandevular
            // 
            dgvRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRandevular.Location = new Point(12, 61);
            dgvRandevular.Name = "dgvRandevular";
            dgvRandevular.RowTemplate.Height = 25;
            dgvRandevular.Size = new Size(1014, 377);
            dgvRandevular.TabIndex = 70;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(142, 12);
            button1.Name = "button1";
            button1.Size = new Size(69, 39);
            button1.TabIndex = 73;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(427, 8);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 74;
            label1.Text = "Randevular";
            // 
            // DoktorRandevular
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1038, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnRandevuSec);
            Controls.Add(btnRandevularClose);
            Controls.Add(dgvRandevular);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoktorRandevular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoktorRandevular";
            ((System.ComponentModel.ISupportInitialize)dgvRandevular).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRandevuSec;
        private Button btnRandevularClose;
        private DataGridView dgvRandevular;
        private Button button1;
        private Label label1;
    }
}