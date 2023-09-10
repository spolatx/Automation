using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.WinForm.Forms.YoneticiForms
{
    public partial class YoneticiBilgilerForm : Form
    {
        public YoneticiBilgilerForm()
        {
            InitializeComponent();
        }

        private void btnYoneticiBilgileriExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
