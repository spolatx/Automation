using HospitalAutomation.Business;
using HospitalAutomation.Business.Interfaces;
using HospitalAutomation.Dtos;
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
        private readonly IGenderService genderService;
        private GenderListDto selectedGender;
        public HastaKabulForm()
        {
            var dependencyContainer = new BusinessServiceRegistration();
            genderService = dependencyContainer.GetGenderServiceInstance();
            InitializeComponent();
        }

        private void HastaKabulForm_Load(object sender, EventArgs e)
        {
            LoadGender();
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

        private void cmbHastaCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHastaCinsiyet.SelectedItem != null)
            {
                selectedGender = cmbHastaCinsiyet.SelectedItem as GenderListDto;
            }
        }
        private void LoadGender()
        {
            var genderList = genderService.GetGenderList();
            cmbHastaCinsiyet.DataSource = null;
            cmbHastaCinsiyet.DataSource = genderList;
            cmbHastaCinsiyet.DisplayMember = "Aciklama";
            cmbHastaCinsiyet.ValueMember = "Id";
        }
    }
}
