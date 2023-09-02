namespace HospitalAutomation.WinForm.Forms.LaboratuvarForms
{
    partial class LaboratuvarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaboratuvarForm));
            btnTahlilSec = new Button();
            btnBekleyenHastaClose = new Button();
            dgvIstenilenTestler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvIstenilenTestler).BeginInit();
            SuspendLayout();
            // 
            // btnTahlilSec
            // 
            btnTahlilSec.BackColor = Color.Maroon;
            btnTahlilSec.FlatAppearance.BorderSize = 0;
            btnTahlilSec.FlatStyle = FlatStyle.Flat;
            btnTahlilSec.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTahlilSec.ForeColor = Color.White;
            btnTahlilSec.Location = new Point(12, 12);
            btnTahlilSec.Name = "btnTahlilSec";
            btnTahlilSec.Size = new Size(152, 39);
            btnTahlilSec.TabIndex = 69;
            btnTahlilSec.Text = "Talil Seç";
            btnTahlilSec.UseVisualStyleBackColor = false;
            btnTahlilSec.Click += btnTahlilSec_Click;
            // 
            // btnBekleyenHastaClose
            // 
            btnBekleyenHastaClose.BackColor = Color.Transparent;
            btnBekleyenHastaClose.FlatAppearance.BorderSize = 0;
            btnBekleyenHastaClose.FlatStyle = FlatStyle.Flat;
            btnBekleyenHastaClose.ForeColor = Color.White;
            btnBekleyenHastaClose.Image = (Image)resources.GetObject("btnBekleyenHastaClose.Image");
            btnBekleyenHastaClose.Location = new Point(996, 12);
            btnBekleyenHastaClose.Name = "btnBekleyenHastaClose";
            btnBekleyenHastaClose.Size = new Size(30, 30);
            btnBekleyenHastaClose.TabIndex = 68;
            btnBekleyenHastaClose.UseVisualStyleBackColor = false;
            btnBekleyenHastaClose.Click += btnBekleyenHastaClose_Click;
            // 
            // dgvIstenilenTestler
            // 
            dgvIstenilenTestler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIstenilenTestler.Location = new Point(12, 61);
            dgvIstenilenTestler.Name = "dgvIstenilenTestler";
            dgvIstenilenTestler.RowTemplate.Height = 25;
            dgvIstenilenTestler.Size = new Size(1014, 377);
            dgvIstenilenTestler.TabIndex = 67;
            // 
            // LaboratuvarForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1038, 450);
            Controls.Add(btnTahlilSec);
            Controls.Add(btnBekleyenHastaClose);
            Controls.Add(dgvIstenilenTestler);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LaboratuvarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LaboratuvarForm";
            ((System.ComponentModel.ISupportInitialize)dgvIstenilenTestler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTahlilSec;
        private Button btnBekleyenHastaClose;
        private DataGridView dgvIstenilenTestler;
    }
}