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
            hastalarService=dependencyContainer.GetHastalarServiceInstance();
            InitializeComponent();
        }

        private void btnBekleyenHastaClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBekleyenHastaSec_Click(object sender, EventArgs e)
        {
            DoktorMuayeneForm doktorMuayeneForm = new DoktorMuayeneForm();
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
