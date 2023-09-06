using HospitalAutomation.Business.Interfaces;
using HospitalAutomation.Data;
using HospitalAutomation.Data.Interfaces;
using HospitalAutomation.Data.Repositories;
using HospitalAutomation.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business.Managers
{
    public class IlceManager : IIlceService
    {
        private readonly IIlceRepository ilceRepository;

        public IlceManager() => ilceRepository = new DataServiceRegistration().GetIlceRepositoryInstance();
        public List<IlceListDto> GetIlceList()
        {
            List<IlceListDto> ilceListDtos = new List<IlceListDto>();

            var ilceler = ilceRepository.GetIlceler();
            foreach ( var ilce in ilceler)
            {
                var ilceDto = new IlceListDto();
                ilceDto.Id = ilce.Id;
                ilceDto.IlceAdi= ilce.IlceAdi;
                ilceDto.SehirId= ilce.SehirId;
                ilceListDtos.Add(ilceDto);
            }
            return ilceListDtos;

        }
    }
}
