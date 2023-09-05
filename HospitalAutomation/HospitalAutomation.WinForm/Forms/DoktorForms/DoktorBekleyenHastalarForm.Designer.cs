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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorBekleyenHastalarForm));
            btnBekleyenHastaClose = new Button();
            btnBekleyenHastaSec = new Button();
            dataGridView1 = new DataGridView();
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hastaAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hastaSoyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sicilNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cepTelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ısTelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tcKimlikNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dogumTarihiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinsiyetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            meslekDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kanGrubuIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sehirIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ılceIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dogumYeriIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hastalarBindingSource = new BindingSource(components);
            genderRepositoryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hastalarBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genderRepositoryBindingSource).BeginInit();
            SuspendLayout();
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
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, hastaAdDataGridViewTextBoxColumn, hastaSoyadDataGridViewTextBoxColumn, sicilNoDataGridViewTextBoxColumn, cepTelDataGridViewTextBoxColumn, ısTelDataGridViewTextBoxColumn, tcKimlikNoDataGridViewTextBoxColumn, dogumTarihiDataGridViewTextBoxColumn, cinsiyetDataGridViewTextBoxColumn, meslekDataGridViewTextBoxColumn, kanGrubuIdDataGridViewTextBoxColumn, sehirIdDataGridViewTextBoxColumn, ılceIdDataGridViewTextBoxColumn, dogumYeriIdDataGridViewTextBoxColumn });
            dataGridView1.DataSource = hastalarBindingSource;
            dataGridView1.Location = new Point(12, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1014, 377);
            dataGridView1.TabIndex = 0;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // hastaAdDataGridViewTextBoxColumn
            // 
            hastaAdDataGridViewTextBoxColumn.DataPropertyName = "HastaAd";
            hastaAdDataGridViewTextBoxColumn.HeaderText = "HastaAd";
            hastaAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            hastaAdDataGridViewTextBoxColumn.Name = "hastaAdDataGridViewTextBoxColumn";
            hastaAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // hastaSoyadDataGridViewTextBoxColumn
            // 
            hastaSoyadDataGridViewTextBoxColumn.DataPropertyName = "HastaSoyad";
            hastaSoyadDataGridViewTextBoxColumn.HeaderText = "HastaSoyad";
            hastaSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            hastaSoyadDataGridViewTextBoxColumn.Name = "hastaSoyadDataGridViewTextBoxColumn";
            hastaSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // sicilNoDataGridViewTextBoxColumn
            // 
            sicilNoDataGridViewTextBoxColumn.DataPropertyName = "SicilNo";
            sicilNoDataGridViewTextBoxColumn.HeaderText = "SicilNo";
            sicilNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            sicilNoDataGridViewTextBoxColumn.Name = "sicilNoDataGridViewTextBoxColumn";
            sicilNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cepTelDataGridViewTextBoxColumn
            // 
            cepTelDataGridViewTextBoxColumn.DataPropertyName = "CepTel";
            cepTelDataGridViewTextBoxColumn.HeaderText = "CepTel";
            cepTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            cepTelDataGridViewTextBoxColumn.Name = "cepTelDataGridViewTextBoxColumn";
            cepTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // ısTelDataGridViewTextBoxColumn
            // 
            ısTelDataGridViewTextBoxColumn.DataPropertyName = "IsTel";
            ısTelDataGridViewTextBoxColumn.HeaderText = "IsTel";
            ısTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            ısTelDataGridViewTextBoxColumn.Name = "ısTelDataGridViewTextBoxColumn";
            ısTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // tcKimlikNoDataGridViewTextBoxColumn
            // 
            tcKimlikNoDataGridViewTextBoxColumn.DataPropertyName = "TcKimlikNo";
            tcKimlikNoDataGridViewTextBoxColumn.HeaderText = "TcKimlikNo";
            tcKimlikNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tcKimlikNoDataGridViewTextBoxColumn.Name = "tcKimlikNoDataGridViewTextBoxColumn";
            tcKimlikNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            dogumTarihiDataGridViewTextBoxColumn.HeaderText = "DogumTarihi";
            dogumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            dogumTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            cinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // meslekDataGridViewTextBoxColumn
            // 
            meslekDataGridViewTextBoxColumn.DataPropertyName = "Meslek";
            meslekDataGridViewTextBoxColumn.HeaderText = "Meslek";
            meslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            meslekDataGridViewTextBoxColumn.Name = "meslekDataGridViewTextBoxColumn";
            meslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // kanGrubuIdDataGridViewTextBoxColumn
            // 
            kanGrubuIdDataGridViewTextBoxColumn.DataPropertyName = "KanGrubuId";
            kanGrubuIdDataGridViewTextBoxColumn.HeaderText = "KanGrubuId";
            kanGrubuIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            kanGrubuIdDataGridViewTextBoxColumn.Name = "kanGrubuIdDataGridViewTextBoxColumn";
            kanGrubuIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // sehirIdDataGridViewTextBoxColumn
            // 
            sehirIdDataGridViewTextBoxColumn.DataPropertyName = "SehirId";
            sehirIdDataGridViewTextBoxColumn.HeaderText = "SehirId";
            sehirIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            sehirIdDataGridViewTextBoxColumn.Name = "sehirIdDataGridViewTextBoxColumn";
            sehirIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ılceIdDataGridViewTextBoxColumn
            // 
            ılceIdDataGridViewTextBoxColumn.DataPropertyName = "IlceId";
            ılceIdDataGridViewTextBoxColumn.HeaderText = "IlceId";
            ılceIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            ılceIdDataGridViewTextBoxColumn.Name = "ılceIdDataGridViewTextBoxColumn";
            ılceIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogumYeriIdDataGridViewTextBoxColumn
            // 
            dogumYeriIdDataGridViewTextBoxColumn.DataPropertyName = "DogumYeriId";
            dogumYeriIdDataGridViewTextBoxColumn.HeaderText = "DogumYeriId";
            dogumYeriIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            dogumYeriIdDataGridViewTextBoxColumn.Name = "dogumYeriIdDataGridViewTextBoxColumn";
            dogumYeriIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // hastalarBindingSource
            // 
            hastalarBindingSource.DataSource = typeof(Entities.Hastalar);
            // 
            // genderRepositoryBindingSource
            // 
            genderRepositoryBindingSource.DataSource = typeof(Data.Repositories.GenderRepository);
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
            ((System.ComponentModel.ISupportInitialize)hastalarBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)genderRepositoryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBekleyenHastaClose;
        private Button btnBekleyenHastaSec;
        private BindingSource genderManagerBindingSource;
        private DataGridViewTextBoxColumn Column1;
        private BindingSource genderManagerBindingSource1;
        private BindingSource genderRepositoryBindingSource;
        private BindingSource hastalarBindingSource;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hastaAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hastaSoyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sicilNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cepTelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ısTelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tcKimlikNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn meslekDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kanGrubuIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sehirIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ılceIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dogumYeriIdDataGridViewTextBoxColumn;
    }
}