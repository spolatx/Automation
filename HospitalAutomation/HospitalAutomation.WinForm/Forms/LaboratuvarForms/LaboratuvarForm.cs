using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.WinForm.Forms.LaboratuvarForms
{
    public partial class LaboratuvarForm : Form
    {
        public LaboratuvarForm()
        {
            InitializeComponent();
        }

        private void btnBekleyenHastaClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTahlilSec_Click(object sender, EventArgs e)
        {
            LaboratuvarSonucForm laboratuvarSonucForm=new LaboratuvarSonucForm();
            laboratuvarSonucForm.ShowDialog();
        }
    }
}
