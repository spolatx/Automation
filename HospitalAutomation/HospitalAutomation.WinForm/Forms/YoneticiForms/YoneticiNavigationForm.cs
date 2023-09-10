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
    public partial class YoneticiNavigationForm : Form
    {
        public YoneticiNavigationForm()
        {
            InitializeComponent();
        }

        private void btnYoneticiNavigationExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
