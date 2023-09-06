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
    public class IlManager : IIlService
    {
        private readonly IIlRepository ilRepository;

        public IlManager() => ilRepository = new DataServiceRegistration().GetIlRepositoryInstance();
        public List<IlListDto> GetIlList()
        {
            var ilListDtos = new List<IlListDto>();
            var il = ilRepository.GetIllers();
            foreach (var iller in il)
            {
                var ilDto = new IlListDto();
                ilDto.Id = iller.Id;
                ilDto.SehirAdi= iller.SehirAdi;
                ilListDtos.Add(ilDto);
            }
            return ilListDtos;
        }
    }
}
