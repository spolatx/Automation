namespace HospitalAutomation.WinForm.Forms.DoktorForms
{
    partial class TahlilSonuclari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TahlilSonuclari));
            label1 = new Label();
            btnTahlilSonuclariClose = new Button();
            dataGridView1 = new DataGridView();
            btnTahlilHastaTcSorgula = new Button();
            mtxtTahlilHastaTcKimlikNo = new MaskedTextBox();
            label4 = new Label();
            btnTahlilGonder = new Button();
            label11 = new Label();
            txtTahlilRecete = new TextBox();
            label10 = new Label();
            txtTahlilTani = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(440, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 16;
            label1.Text = "Tahlil Sonuclari";
            // 
            // btnTahlilSonuclariClose
            // 
            btnTahlilSonuclariClose.BackColor = Color.Transparent;
            btnTahlilSonuclariClose.FlatAppearance.BorderSize = 0;
            btnTahlilSonuclariClose.FlatStyle = FlatStyle.Flat;
            btnTahlilSonuclariClose.ForeColor = Color.White;
            btnTahlilSonuclariClose.Image = (Image)resources.GetObject("btnTahlilSonuclariClose.Image");
            btnTahlilSonuclariClose.Location = new Point(1065, 12);
            btnTahlilSonuclariClose.Name = "btnTahlilSonuclariClose";
            btnTahlilSonuclariClose.Size = new Size(30, 30);
            btnTahlilSonuclariClose.TabIndex = 15;
            btnTahlilSonuclariClose.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1083, 240);
            dataGridView1.TabIndex = 17;
            // 
            // btnTahlilHastaTcSorgula
            // 
            btnTahlilHastaTcSorgula.BackColor = Color.Maroon;
            btnTahlilHastaTcSorgula.FlatAppearance.BorderSize = 0;
            btnTahlilHastaTcSorgula.FlatStyle = FlatStyle.Flat;
            btnTahlilHastaTcSorgula.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTahlilHastaTcSorgula.ForeColor = Color.White;
            btnTahlilHastaTcSorgula.Location = new Point(190, 55);
            btnTahlilHastaTcSorgula.Name = "btnTahlilHastaTcSorgula";
            btnTahlilHastaTcSorgula.Size = new Size(97, 27);
            btnTahlilHastaTcSorgula.TabIndex = 70;
            btnTahlilHastaTcSorgula.Text = "Sorgula";
            btnTahlilHastaTcSorgula.UseVisualStyleBackColor = false;
            // 
            // mtxtTahlilHastaTcKimlikNo
            // 
            mtxtTahlilHastaTcKimlikNo.Location = new Point(75, 55);
            mtxtTahlilHastaTcKimlikNo.Mask = "00000000000";
            mtxtTahlilHastaTcKimlikNo.Name = "mtxtTahlilHastaTcKimlikNo";
            mtxtTahlilHastaTcKimlikNo.Size = new Size(109, 27);
            mtxtTahlilHastaTcKimlikNo.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 58);
            label4.Name = "label4";
            label4.Size = new Size(39, 21);
            label4.TabIndex = 71;
            label4.Text = "TC :";
            // 
            // btnTahlilGonder
            // 
            btnTahlilGonder.BackColor = Color.Maroon;
            btnTahlilGonder.FlatAppearance.BorderSize = 0;
            btnTahlilGonder.FlatStyle = FlatStyle.Flat;
            btnTahlilGonder.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTahlilGonder.ForeColor = Color.White;
            btnTahlilGonder.Location = new Point(919, 539);
            btnTahlilGonder.Name = "btnTahlilGonder";
            btnTahlilGonder.Size = new Size(176, 32);
            btnTahlilGonder.TabIndex = 80;
            btnTahlilGonder.Text = "Gönder";
            btnTahlilGonder.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(577, 343);
            label11.Name = "label11";
            label11.Size = new Size(67, 21);
            label11.TabIndex = 79;
            label11.Text = "Reçete";
            // 
            // txtTahlilRecete
            // 
            txtTahlilRecete.Location = new Point(577, 378);
            txtTahlilRecete.Multiline = true;
            txtTahlilRecete.Name = "txtTahlilRecete";
            txtTahlilRecete.Size = new Size(289, 193);
            txtTahlilRecete.TabIndex = 78;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(264, 343);
            label10.Name = "label10";
            label10.Size = new Size(42, 21);
            label10.TabIndex = 77;
            label10.Text = "Tanı";
            // 
            // txtTahlilTani
            // 
            txtTahlilTani.Location = new Point(264, 378);
            txtTahlilTani.Multiline = true;
            txtTahlilTani.Name = "txtTahlilTani";
            txtTahlilTani.Size = new Size(289, 193);
            txtTahlilTani.TabIndex = 76;
            // 
            // TahlilSonuclari
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1107, 596);
            Controls.Add(btnTahlilGonder);
            Controls.Add(label11);
            Controls.Add(txtTahlilRecete);
            Controls.Add(label10);
            Controls.Add(txtTahlilTani);
            Controls.Add(btnTahlilHastaTcSorgula);
            Controls.Add(mtxtTahlilHastaTcKimlikNo);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnTahlilSonuclariClose);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TahlilSonuclari";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TahlilSonuclari";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTahlilSonuclariClose;
        private DataGridView dataGridView1;
        private Button btnTahlilHastaTcSorgula;
        private MaskedTextBox mtxtTahlilHastaTcKimlikNo;
        private Label label4;
        private Button btnTahlilGonder;
        private Label label11;
        private TextBox txtTahlilRecete;
        private Label label10;
        private TextBox txtTahlilTani;
    }
}