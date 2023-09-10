using HospitalAutomation.Business.Interfaces;
using HospitalAutomation.Data;
using HospitalAutomation.Data.Interfaces;
using HospitalAutomation.Dtos;
using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business.Managers
{
    public class HastaKabulManager:IHastaKabulService
    {
        private readonly IHastaKabulListRepository hastaKabulListRepository;
        public HastaKabulManager()
        {
            var container = new DataServiceRegistration();
            hastaKabulListRepository=container.GetHastaKabulListRepositoryInstance();
        }
        public void CreateHastaKabul(RegisterHastalarDto registerHastalarDto)
        {
            hastaKabulListRepository.GetHastalar(new Entities.HastaKabul
            {
                TcNo=registerHastalarDto.TcNo,
                Ad=registerHastalarDto.Ad,
                Soyad=registerHastalarDto.Soyad,
                CinsiyetId=registerHastalarDto.CinsiyetId,
                KanGrubuId=registerHastalarDto.KanGrubuId,
                DogumYeriId=registerHastalarDto.DogumYeriId,
                DogumTarihi=registerHastalarDto.DogumTarihi,
                CepTel=registerHastalarDto.CepTel,
                Istel=registerHastalarDto.Istel,
                IlId=registerHastalarDto.IlId,
                IlceId=registerHastalarDto.IlceId,
                PoliklinikId=registerHastalarDto.PoliklinikId,
                DoktorId=registerHastalarDto.DoktorId
            });

        }
        public List<RegisterHastalarDto> HastaSorgula(string tcno)
        {
            List<RegisterHastalarDto> registerHastalarDtoList = new List<RegisterHastalarDto>();
            RegisterHastalarDto registerHastalarDto = new RegisterHastalarDto();
            List<HastaKabul> hastaKabul = new List<HastaKabul>();

            hastaKabul = hastaKabulListRepository.HastaSorgula(tcno);



            registerHastalarDto.TcNo = hastaKabul[0].TcNo;
            registerHastalarDto.Ad = hastaKabul[0].Ad;
            registerHastalarDto.Soyad = hastaKabul[0].Soyad;
            registerHastalarDto.CinsiyetId = hastaKabul[0].CinsiyetId;
            registerHastalarDto.KanGrubuId = hastaKabul[0].KanGrubuId;
            registerHastalarDto.DogumYeriId = hastaKabul[0].DogumYeriId;
            registerHastalarDto.DogumTarihi = hastaKabul[0].DogumTarihi;
            registerHastalarDto.CepTel = hastaKabul[0].CepTel;
            registerHastalarDto.Istel = hastaKabul[0].Istel;
            registerHastalarDto.IlId = hastaKabul[0].IlId;
            registerHastalarDto.IlceId = hastaKabul[0].IlceId;
            registerHastalarDto.PoliklinikId = hastaKabul[0].PoliklinikId;
            registerHastalarDto.DoktorId = hastaKabul[0].DoktorId;

            registerHastalarDtoList.Add(registerHastalarDto);
            return registerHastalarDtoList;

        }

    }
}
