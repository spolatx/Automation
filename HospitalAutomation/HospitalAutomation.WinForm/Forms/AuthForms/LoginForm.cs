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
        public LoginForm(string girisBilgisi)
        {
            InitializeComponent();
            this.lblGirisBilgisi.Text = girisBilgisi + " Girişi";
        }

        private void btnLoginFormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginFormBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
