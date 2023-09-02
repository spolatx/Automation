using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.WinForm.Forms.HastaKabulForms
{
    public partial class HastaKabulForm : Form
    {
        public HastaKabulForm()
        {
            InitializeComponent();
        }

        private void HastaKabulForm_Load(object sender, EventArgs e)
        {

        }

        private void btnHastaKabulClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHastaKabulBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHastaKayit_Click(object sender, EventArgs e)
        {

        }

        private void btnHastaPoliklinikKayit_Click(object sender, EventArgs e)
        {

        }

        private void btnHastaTcSorgula_Click(object sender, EventArgs e)
        {

        }
    }
}
