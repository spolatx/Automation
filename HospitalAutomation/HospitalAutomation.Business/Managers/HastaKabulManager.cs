using HospitalAutomation.Business.Interfaces;
using HospitalAutomation.Data;
using HospitalAutomation.Data.Interfaces;
using HospitalAutomation.Dtos;
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

    }
}
