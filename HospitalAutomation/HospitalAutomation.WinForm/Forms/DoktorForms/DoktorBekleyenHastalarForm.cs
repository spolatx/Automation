using HospitalAutomation.Business;
using HospitalAutomation.Business.Interfaces;
using HospitalAutomation.Data.Interfaces;
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
    public partial class DoktorBekleyenHastalarForm : Form
    {
        IHastalarService hastalarService;
        public DoktorBekleyenHastalarForm()
        {
            var dependencyContainer = new BusinessServiceRegistration();
            hastalarService = dependencyContainer.GetHastalarServiceInstance();
            InitializeComponent();
        }

        private void btnBekleyenHastaClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBekleyenHastaSec_Click(object sender, EventArgs e)
        {
            DoktorMuayeneForm doktorMuayeneForm = new DoktorMuayeneForm();
            doktorMuayeneForm.tc = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            doktorMuayeneForm.ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            doktorMuayeneForm.soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            doktorMuayeneForm.cinsiyet = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            doktorMuayeneForm.kangrubu = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            doktorMuayeneForm.dogumyeri = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            doktorMuayeneForm.dogumtarihi = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            doktorMuayeneForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadHastalar()
        {
            var hastaList = hastalarService.GetHastalarList();
            dataGridView1.DataSource = hastaList;

        }

        private void DoktorBekleyenHastalarForm_Load(object sender, EventArgs e)
        {
            LoadHastalar();
        }
    }
}
