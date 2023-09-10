using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.WinForm.Forms.HastaForms
{
    public partial class HastaRandevularımForm : Form
    {
        public HastaRandevularımForm()
        {
            InitializeComponent();
        }

        
        private void btnRandevularClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
