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
            dgvReceteler = new DataGridView();
            btnReceteYazdir = new Button();
            mtxtDoktorTcKimlikNo = new MaskedTextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReceteler).BeginInit();
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
            // dgvReceteler
            // 
            dgvReceteler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceteler.Location = new Point(12, 60);
            dgvReceteler.Name = "dgvReceteler";
            dgvReceteler.RowTemplate.Height = 25;
            dgvReceteler.Size = new Size(776, 193);
            dgvReceteler.TabIndex = 29;
            // 
            // btnReceteYazdir
            // 
            btnReceteYazdir.BackColor = Color.Maroon;
            btnReceteYazdir.FlatAppearance.BorderSize = 0;
            btnReceteYazdir.FlatStyle = FlatStyle.Flat;
            btnReceteYazdir.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReceteYazdir.ForeColor = Color.White;
            btnReceteYazdir.Location = new Point(580, 259);
            btnReceteYazdir.Name = "btnReceteYazdir";
            btnReceteYazdir.Size = new Size(208, 39);
            btnReceteYazdir.TabIndex = 73;
            btnReceteYazdir.Text = "Yazdır";
            btnReceteYazdir.UseVisualStyleBackColor = false;
            // 
            // mtxtDoktorTcKimlikNo
            // 
            mtxtDoktorTcKimlikNo.Location = new Point(85, 27);
            mtxtDoktorTcKimlikNo.Mask = "00000000000";
            mtxtDoktorTcKimlikNo.Name = "mtxtDoktorTcKimlikNo";
            mtxtDoktorTcKimlikNo.ReadOnly = true;
            mtxtDoktorTcKimlikNo.Size = new Size(170, 27);
            mtxtDoktorTcKimlikNo.TabIndex = 94;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 30);
            label4.Name = "label4";
            label4.Size = new Size(39, 21);
            label4.TabIndex = 95;
            label4.Text = "TC :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(326, 8);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 97;
            label1.Text = "Reçetelerim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 269);
            label2.Name = "label2";
            label2.Size = new Size(386, 19);
            label2.TabIndex = 98;
            label2.Text = "*Yazdırmak istediğiniz reçetenin üzerine tıklayınız";
            // 
            // HastaRecetelerimForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 310);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mtxtDoktorTcKimlikNo);
            Controls.Add(label4);
            Controls.Add(btnReceteYazdir);
            Controls.Add(dgvReceteler);
            Controls.Add(btnHastaRecetelerimExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HastaRecetelerimForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaRecetelerimForm";
            ((System.ComponentModel.ISupportInitialize)dgvReceteler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHastaRecetelerimExit;
        private DataGridView dgvReceteler;
        private Button btnReceteYazdir;
        private MaskedTextBox mtxtDoktorTcKimlikNo;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}