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
    public partial class NavigationForm : Form
    {
        public NavigationForm()
        {
            InitializeComponent();
        }

        private void btnNavigationClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm((sender as Button).Text);
            loginForm.ShowDialog();

        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm((sender as Button).Text);
            loginForm.ShowDialog();
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm((sender as Button).Text);
            loginForm.ShowDialog();
        }

        private void btnHastaKabul_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm((sender as Button).Text);
            loginForm.ShowDialog();
        }
    }
}
