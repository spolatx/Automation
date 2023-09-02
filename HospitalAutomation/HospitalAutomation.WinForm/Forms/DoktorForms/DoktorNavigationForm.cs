using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.WinForm.Forms.DoktorForms
{
    public partial class DoktorNavigationForm : Form
    {
        public DoktorNavigationForm()
        {
            InitializeComponent();
        }

        private void btnDoktorBekleyenHasta_Click(object sender, EventArgs e)
        {
            DoktorBekleyenHastalarForm doktorBekleyenHastalarForm = new DoktorBekleyenHastalarForm();
            doktorBekleyenHastalarForm.ShowDialog();
        }

        private void btnDoktorNavigationClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
