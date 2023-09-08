using HospitalAutomation.Business;
using HospitalAutomation.Business.Interfaces;
using HospitalAutomation.Dtos;
using HospitalAutomation.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAutomation.Data.Helpers;

namespace HospitalAutomation.WinForm.Forms.HastaKabulForms
{

    public partial class HastaKabulForm : Form
    {
        private readonly IHastaKabulService hastaKabulService;
        private readonly IIlService ilService;
        private readonly IDoktorService doktorService;
        private readonly IPoliklinikService poliklinikService;
        private readonly IKanGrubuService kanGrubuService;
        private readonly IGenderService genderService;
        //private readonly IIlceService ilceService;

        private GenderListDto selectedGender;
        public HastaKabulForm()
        {
            var dependencyContainer = new BusinessServiceRegistration();
            genderService = dependencyContainer.GetGenderServiceInstance();
            kanGrubuService = dependencyContainer.GetKanGrubuServiceInstance();
            poliklinikService = dependencyContainer.GetPoliklinikServiceInstance();
            doktorService = dependencyContainer.GetDoktorServiceInstance();
            ilService = dependencyContainer.GetIlServiceInstance();
            hastaKabulService=dependencyContainer.GetHastaKabulServiceInstance();
            //ilceService = dependencyContainer.GetIlceServiceInstance();
            InitializeComponent();
        }

        private void HastaKabulForm_Load(object sender, EventArgs e)
        {
            LoadGender();
            LoadKanGrubu();
            LoadPoliklinik();
            LoadDoktor();
            LoadIl();
            //LoadIlce();
        }

        private void btnHastaKabulClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            hastaKabulService.CreateHastaKabul(new Dtos.RegisterHastalarDto
            {
                TcNo=mtxtHastaTcKimlikNo.Text,
                Ad=txtHastaAd.Text,
                Soyad=txtHastaSoyad.Text,
                CinsiyetId=cmbHastaCinsiyet.SelectedIndex+1,
                KanGrubuId=cmbHastaKanGrubu.SelectedIndex+1,
                DogumYeriId=cmbHastaDogumYeri.SelectedIndex + 1,
                DogumTarihi=dtpHastaDogumTarihi.Value,
                CepTel=mtxtHastaCepTelefonu.Text,
                Istel=mtxtHastaIsTelefonu.Text,
                IlId=cmbHastaIl.SelectedIndex + 1,
                IlceId=cmbHastailce.SelectedIndex + 1,
                PoliklinikId=cmbHastaPoliklinik.SelectedIndex + 1,
                DoktorId=cmbHastaDoktor.SelectedIndex + 1
            });
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
        private void LoadKanGrubu()
        {
            var kanGrubuList = kanGrubuService.GetKanGrubuList();
            cmbHastaKanGrubu.DataSource = null;
            cmbHastaKanGrubu.DataSource = kanGrubuList;
            cmbHastaKanGrubu.DisplayMember = "KanGrubuAdi";
            cmbHastaKanGrubu.ValueMember = "ID";
        }
        private void LoadPoliklinik()
        {
            var poliklinikList = poliklinikService.GetPoliklinikList();
            cmbHastaPoliklinik.DataSource = null;
            cmbHastaPoliklinik.DataSource = poliklinikList;
            cmbHastaPoliklinik.DisplayMember = "PoliklinikAdi";
            cmbHastaPoliklinik.ValueMember = "ID";
        }
        private void LoadDoktor()
        {
            var doktorList = doktorService.GetDoktorList();
            cmbHastaDoktor.DataSource = null;
            cmbHastaDoktor.DataSource = doktorList;
            cmbHastaDoktor.DisplayMember = "Ad";
            cmbHastaDoktor.ValueMember = "ID";
        }
        private void LoadIl()
        {
            //İl comboboxına iller getirildi
            var ilList = ilService.GetIlList();
            cmbHastaIl.DataSource = null;
            cmbHastaIl.DataSource = ilList;
            cmbHastaIl.DisplayMember = "sehiradi";
            cmbHastaIl.ValueMember = "Id";
            //Doğum Yeri Combobaxına iller getirildi.
            var dogumIl = ilService.GetIlList();
            cmbHastaDogumYeri.DataSource = null;
            cmbHastaDogumYeri.DataSource = dogumIl;
            cmbHastaDogumYeri.DisplayMember = "sehiradi";
            cmbHastaDogumYeri.ValueMember="Id";
        }
        //private void LoadIlce()
        //{

        //    var ilceList = ilceService.GetIlceList();
        //    cmbHastailce.DataSource = null;
        //    cmbHastailce.DataSource = ilceList;
        //    cmbHastailce.DisplayMember = "IlceAdi";
        //    cmbHastailce.ValueMember = "Id";
        //}

        private void cmbHastaIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHastailce.Items.Clear();
            var connection = new DbConnectionHelper().Connection;
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from ilceler where sehirid=@p1";
            command.Connection = connection;
            connection.Open();
            command.Parameters.AddWithValue("@p1", cmbHastaIl.SelectedIndex + 1);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbHastailce.Items.Add(reader.GetString(1));
            }
            connection.Close();
            reader.Close();


        }

      
    }
}
