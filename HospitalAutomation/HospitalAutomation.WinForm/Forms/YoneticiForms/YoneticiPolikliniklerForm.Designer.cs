﻿namespace HospitalAutomation.WinForm.Forms.YoneticiForms
{
    partial class YoneticiPolikliniklerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiPolikliniklerForm));
            btnYoneticiPolikliniklerExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnYoneticiPolikliniklerExit
            // 
            btnYoneticiPolikliniklerExit.BackColor = Color.Transparent;
            btnYoneticiPolikliniklerExit.FlatAppearance.BorderSize = 0;
            btnYoneticiPolikliniklerExit.FlatStyle = FlatStyle.Flat;
            btnYoneticiPolikliniklerExit.ForeColor = Color.White;
            btnYoneticiPolikliniklerExit.Image = (Image)resources.GetObject("btnYoneticiPolikliniklerExit.Image");
            btnYoneticiPolikliniklerExit.Location = new Point(758, 12);
            btnYoneticiPolikliniklerExit.Name = "btnYoneticiPolikliniklerExit";
            btnYoneticiPolikliniklerExit.Size = new Size(30, 30);
            btnYoneticiPolikliniklerExit.TabIndex = 20;
            btnYoneticiPolikliniklerExit.UseVisualStyleBackColor = false;
            btnYoneticiPolikliniklerExit.Click += btnYoneticiPolikliniklerExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(293, 12);
            label1.Name = "label1";
            label1.Size = new Size(222, 32);
            label1.TabIndex = 30;
            label1.Text = "Poliklinik Bilgileri";
            // 
            // YoneticiPolikliniklerForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnYoneticiPolikliniklerExit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "YoneticiPolikliniklerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiPolikliniklerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYoneticiPolikliniklerExit;
        private Label label1;
    }
}