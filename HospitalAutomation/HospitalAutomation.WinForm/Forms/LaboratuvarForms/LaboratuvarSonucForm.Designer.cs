namespace HospitalAutomation.WinForm.Forms.LaboratuvarForms
{
    partial class LaboratuvarSonucForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaboratuvarSonucForm));
            btnTahlilSec = new Button();
            btnBekleyenHastaClose = new Button();
            dgvIstenilenTestler = new DataGridView();
            txtTahlilSecilenTest = new MaskedTextBox();
            label4 = new Label();
            btnTahlilGonder = new Button();
            label11 = new Label();
            txtTahlilSonuc = new TextBox();
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
            btnTahlilSec.Location = new Point(443, 171);
            btnTahlilSec.Name = "btnTahlilSec";
            btnTahlilSec.Size = new Size(152, 39);
            btnTahlilSec.TabIndex = 72;
            btnTahlilSec.Text = "Seç";
            btnTahlilSec.UseVisualStyleBackColor = false;
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
            btnBekleyenHastaClose.TabIndex = 71;
            btnBekleyenHastaClose.UseVisualStyleBackColor = false;
            btnBekleyenHastaClose.Click += btnBekleyenHastaClose_Click;
            // 
            // dgvIstenilenTestler
            // 
            dgvIstenilenTestler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIstenilenTestler.Location = new Point(12, 61);
            dgvIstenilenTestler.Name = "dgvIstenilenTestler";
            dgvIstenilenTestler.RowTemplate.Height = 25;
            dgvIstenilenTestler.Size = new Size(583, 104);
            dgvIstenilenTestler.TabIndex = 70;
            // 
            // txtTahlilSecilenTest
            // 
            txtTahlilSecilenTest.Location = new Point(749, 61);
            txtTahlilSecilenTest.Mask = "00000000000";
            txtTahlilSecilenTest.Name = "txtTahlilSecilenTest";
            txtTahlilSecilenTest.ReadOnly = true;
            txtTahlilSecilenTest.Size = new Size(277, 27);
            txtTahlilSecilenTest.TabIndex = 99;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(636, 64);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 100;
            label4.Text = "Seçilen Test :";
            // 
            // btnTahlilGonder
            // 
            btnTahlilGonder.BackColor = Color.Maroon;
            btnTahlilGonder.FlatAppearance.BorderSize = 0;
            btnTahlilGonder.FlatStyle = FlatStyle.Flat;
            btnTahlilGonder.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTahlilGonder.ForeColor = Color.White;
            btnTahlilGonder.Location = new Point(850, 370);
            btnTahlilGonder.Name = "btnTahlilGonder";
            btnTahlilGonder.Size = new Size(176, 39);
            btnTahlilGonder.TabIndex = 103;
            btnTahlilGonder.Text = "Gönder";
            btnTahlilGonder.UseVisualStyleBackColor = false;
            btnTahlilGonder.Click += button3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(632, 97);
            label11.Name = "label11";
            label11.Size = new Size(111, 21);
            label11.TabIndex = 102;
            label11.Text = "Test Sonucu :";
            // 
            // txtTahlilSonuc
            // 
            txtTahlilSonuc.Location = new Point(749, 94);
            txtTahlilSonuc.Multiline = true;
            txtTahlilSonuc.Name = "txtTahlilSonuc";
            txtTahlilSonuc.Size = new Size(277, 268);
            txtTahlilSonuc.TabIndex = 101;
            // 
            // LaboratuvarSonucForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1038, 421);
            Controls.Add(btnTahlilGonder);
            Controls.Add(label11);
            Controls.Add(txtTahlilSonuc);
            Controls.Add(txtTahlilSecilenTest);
            Controls.Add(label4);
            Controls.Add(btnTahlilSec);
            Controls.Add(btnBekleyenHastaClose);
            Controls.Add(dgvIstenilenTestler);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LaboratuvarSonucForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LaboratuvarSonucForm";
            ((System.ComponentModel.ISupportInitialize)dgvIstenilenTestler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTahlilSec;
        private Button btnBekleyenHastaClose;
        private DataGridView dgvIstenilenTestler;
        private MaskedTextBox txtTahlilSecilenTest;
        private Label label4;
        private Button btnTahlilGonder;
        private Label label11;
        private TextBox txtTahlilSonuc;
    }
}