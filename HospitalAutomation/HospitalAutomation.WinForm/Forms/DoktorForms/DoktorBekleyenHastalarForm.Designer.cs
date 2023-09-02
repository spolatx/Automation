namespace HospitalAutomation.WinForm.Forms.DoktorForms
{
    partial class DoktorBekleyenHastalarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorBekleyenHastalarForm));
            dataGridView1 = new DataGridView();
            btnBekleyenHastaClose = new Button();
            btnBekleyenHastaSec = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1014, 377);
            dataGridView1.TabIndex = 0;
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
            btnBekleyenHastaClose.TabIndex = 20;
            btnBekleyenHastaClose.UseVisualStyleBackColor = false;
            btnBekleyenHastaClose.Click += btnBekleyenHastaClose_Click;
            // 
            // btnBekleyenHastaSec
            // 
            btnBekleyenHastaSec.BackColor = Color.Maroon;
            btnBekleyenHastaSec.FlatAppearance.BorderSize = 0;
            btnBekleyenHastaSec.FlatStyle = FlatStyle.Flat;
            btnBekleyenHastaSec.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBekleyenHastaSec.ForeColor = Color.White;
            btnBekleyenHastaSec.Location = new Point(12, 8);
            btnBekleyenHastaSec.Name = "btnBekleyenHastaSec";
            btnBekleyenHastaSec.Size = new Size(152, 39);
            btnBekleyenHastaSec.TabIndex = 66;
            btnBekleyenHastaSec.Text = "Hasta Seç";
            btnBekleyenHastaSec.UseVisualStyleBackColor = false;
            btnBekleyenHastaSec.Click += btnBekleyenHastaSec_Click;
            // 
            // DoktorBekleyenHastalarForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1038, 450);
            Controls.Add(btnBekleyenHastaSec);
            Controls.Add(btnBekleyenHastaClose);
            Controls.Add(dataGridView1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoktorBekleyenHastalarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoktorBekleyenHastalarForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBekleyenHastaClose;
        private Button btnBekleyenHastaSec;
    }
}