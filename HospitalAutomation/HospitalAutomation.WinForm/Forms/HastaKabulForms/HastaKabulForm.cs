﻿using HospitalAutomation.Business;
using HospitalAutomation.Business.Interfaces;
using HospitalAutomation.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.WinForm.Forms.HastaKabulForms
{

    public partial class HastaKabulForm : Form
    {
        private readonly IDoktorService doktorService;
        private readonly IPoliklinikService poliklinikService;
        private readonly IKanGrubuService kanGrubuService;
        private readonly IGenderService genderService;
        private GenderListDto selectedGender;
        public HastaKabulForm()
        {
            var dependencyContainer = new BusinessServiceRegistration();
            genderService = dependencyContainer.GetGenderServiceInstance();
            kanGrubuService = dependencyContainer.GetKanGrubuServiceInstance();
            poliklinikService=dependencyContainer.GetPoliklinikServiceInstance();
            doktorService=dependencyContainer.GetDoktorServiceInstance();
            InitializeComponent();
        }

        private void HastaKabulForm_Load(object sender, EventArgs e)
        {
            LoadGender();
            LoadKanGrubu();
            LoadPoliklinik();
            LoadDoktor();
        }

        private void btnHastaKabulClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            cmbHastaPoliklinik.DataSource=null;
            cmbHastaPoliklinik.DataSource = poliklinikList;
            cmbHastaPoliklinik.DisplayMember = "PoliklinikAdi";
            cmbHastaPoliklinik.ValueMember= "ID";
        }
        private void LoadDoktor()
        {
            var doktorList=doktorService.GetDoktorList();
            cmbHastaDoktor.DataSource=null;
            cmbHastaDoktor.DataSource= doktorList;
            cmbHastaDoktor.DisplayMember = "Ad";
            cmbHastaDoktor.ValueMember = "ID";
        }
       

       
    }
}
