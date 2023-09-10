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

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            YoneticiBilgilerForm yoneticiBilgilerForm=new YoneticiBilgilerForm();
            yoneticiBilgilerForm.ShowDialog();
        }

        private void btnHastalar_Click(object sender, EventArgs e)
        {
            YoneticiHastalarForm yoneticiHastalarForm=new YoneticiHastalarForm();
            yoneticiHastalarForm.ShowDialog();
        }

        private void btnDoktorlar_Click(object sender, EventArgs e)
        {
            YoneticiDoktorlarForm yoneticiDoktorlarForm=new YoneticiDoktorlarForm();
            yoneticiDoktorlarForm.ShowDialog();
        }

        private void btnPoliklinikler_Click(object sender, EventArgs e)
        {
            YoneticiPolikliniklerForm yoneticiPolikliniklerForm=new YoneticiPolikliniklerForm();
            yoneticiPolikliniklerForm.ShowDialog();
        }
    }
}
