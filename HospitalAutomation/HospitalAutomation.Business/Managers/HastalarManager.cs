using HospitalAutomation.Business.Interfaces;
using HospitalAutomation.Data.Repositories;
using HospitalAutomation.Data;
using HospitalAutomation.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAutomation.Data.Interfaces;

namespace HospitalAutomation.Business.Managers
{
    public class HastalarManager : IHastalarService
    {
        private readonly IHastaRepository hastalarRepository;
        public HastalarManager() => hastalarRepository = new DataServiceRegistration().GetHastalarRepositoryInstance();
        public List<HastalarListDto> GetHastalarList()
        {
            var hastalarListDto = new List<HastalarListDto>();
            var hastalar = hastalarRepository.GetHastalar();
            foreach (var hasta in hastalar)
            {
                var hastaDto = new HastalarListDto();
                hastaDto.ID = hasta.Id;
                hastaDto.HastaAd = hasta.HastaAd;
                hastaDto.HastaSoyad = hasta.HastaSoyad;
                hastalarListDto.Add(hastaDto);
            }

            return hastalarListDto;
        }

        
    }
}

