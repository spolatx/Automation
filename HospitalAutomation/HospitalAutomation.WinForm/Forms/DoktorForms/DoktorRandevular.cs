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
    public partial class DoktorRandevular : Form
    {
        public DoktorRandevular()
        {
            InitializeComponent();
        }

        private void btnRandevularClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRandevuSec_Click(object sender, EventArgs e)
        {
            DoktorMuayeneForm doktorMuayeneForm = new DoktorMuayeneForm();
            doktorMuayeneForm.ShowDialog();
        }
    }
}
