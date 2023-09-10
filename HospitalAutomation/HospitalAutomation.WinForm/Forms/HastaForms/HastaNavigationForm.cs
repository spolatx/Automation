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
    public partial class HastaNavigationForm : Form
    {
        public HastaNavigationForm()
        {
            InitializeComponent();
        }

        private void btnHastaNavigationExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHastaKullanici_Click(object sender, EventArgs e)
        {
            HastaKullaniciForm hastaKullaniciForm=new HastaKullaniciForm();
            hastaKullaniciForm.ShowDialog();
        }

        private void btnHastaRandevular_Click(object sender, EventArgs e)
        {
            HastaRandevularımForm hastaRandevularımForm=new HastaRandevularımForm();
            hastaRandevularımForm.ShowDialog();
        }

        private void btnHastaRandevuAl_Click(object sender, EventArgs e)
        {
            HastaRandevuAlForm hastaRandevuAlForm=new HastaRandevuAlForm();
            hastaRandevuAlForm.ShowDialog();
        }

        private void btnHastaRecetelerim_Click(object sender, EventArgs e)
        {
            HastaRecetelerimForm hastaRecetelerimForm=  new HastaRecetelerimForm();
            hastaRecetelerimForm.ShowDialog();
        }
    }
}
