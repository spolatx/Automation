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
    public partial class DoktorBekleyenHastalarForm : Form
    {
        public DoktorBekleyenHastalarForm()
        {
            InitializeComponent();
        }

        private void btnBekleyenHastaClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBekleyenHastaSec_Click(object sender, EventArgs e)
        {
            DoktorMuayeneForm doktorMuayeneForm = new DoktorMuayeneForm();
            doktorMuayeneForm.ShowDialog();
        }
    }
}
