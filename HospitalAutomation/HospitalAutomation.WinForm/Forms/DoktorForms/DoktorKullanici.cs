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
    public partial class DoktorKullanici : Form
    {
        public DoktorKullanici()
        {
            InitializeComponent();
        }

        private void DoktorKullanici_Load(object sender, EventArgs e)
        {

        }

        private void btnBekleyenHastaClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
