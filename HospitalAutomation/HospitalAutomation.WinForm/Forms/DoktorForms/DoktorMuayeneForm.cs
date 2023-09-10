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
    public partial class DoktorMuayeneForm : Form
    {
        public DoktorMuayeneForm()
        {
            InitializeComponent();
        }

        public string tc, ad, soyad, cinsiyet, kangrubu, dogumyeri, dogumtarihi;
        private void DoktorMuayeneForm_Load(object sender, EventArgs e)
        {
            mtxtDoktorMuayeneHastaTcKimlikNo.Text = tc;
            txtDoktorMuayeneHastaAd.Text = ad;
            txtDoktorMuayeneHastaSoyad.Text = soyad;
            txtDoktorMuayeneKanGrubu.Text = kangrubu;
            txtDoktorMuayeneDogumYeri.Text = dogumyeri;
            txtDoktorMuayeneDogumTarihi.Text = dogumtarihi;
            txtDoktorMuayeneCinsiyet.Text = cinsiyet;
            txtDoktorMuayeneDogumYeri.Text = dogumyeri;



        }

        private void btnDoktorMuayeneClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
