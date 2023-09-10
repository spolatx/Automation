using HospitalAutomation.WinForm.Forms.DoktorForms;
using HospitalAutomation.WinForm.Forms.HastaForms;
using HospitalAutomation.WinForm.Forms.HastaKabulForms;
using HospitalAutomation.WinForm.Forms.LaboratuvarForms;
using HospitalAutomation.WinForm.Forms.YoneticiForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.WinForm.Forms.AuthForms
{
    public partial class LoginForm : Form
    {
        private readonly string girisBilgisi;
        public LoginForm(string girisBilgisi)
        {
            InitializeComponent();
            this.lblGirisBilgisi.Text = girisBilgisi + " Girişi";
            this.girisBilgisi = girisBilgisi;
        }

        private void btnLoginFormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginFormBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form secilenForm;

            if (girisBilgisi == "Hasta")
            {
                secilenForm = new HastaNavigationForm();
                secilenForm.ShowDialog();
            }
            else if (girisBilgisi == "Doktor")
            {
                secilenForm = new DoktorNavigationForm();
                secilenForm.ShowDialog();
            }
            else if (girisBilgisi == "Yönetici")
            {
                secilenForm = new YoneticiNavigationForm();
                secilenForm.ShowDialog();
            }
            else if (girisBilgisi == "Hasta Kabul")
            {
                secilenForm = new YoneticiNavigationForm();
                secilenForm.ShowDialog();
            }
            else if (girisBilgisi == "Laboratuvar")
            {
                secilenForm = new LaboratuvarForm();
                secilenForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Herhangi bir kullanıcı seçilmedi.");
            }


        }
    }
}
