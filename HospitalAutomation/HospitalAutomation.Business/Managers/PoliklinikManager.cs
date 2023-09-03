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
    public class PoliklinikManager : IPoliklinikService
    {
        private readonly IPoliklinikRepository poliklinikRepository;

        public PoliklinikManager() => poliklinikRepository = new DataServiceRegistration().GetPoliklinikRepositoryInstance();
        public List<PoliklinikListDto> GetPoliklinikList()
        {
           var poliklinikListDto = new List<PoliklinikListDto>();
            var poliklinik = poliklinikRepository.GetPoliklinikler();
            foreach (var poliklinikler in poliklinik)
            {
                var poliklinikList = new PoliklinikListDto();
                poliklinikList.Id=poliklinikler.Id;
                poliklinikList.PoliklinikAdi = poliklinikler.PoliklinikAdi;
                poliklinikList.RandevuSure = poliklinikler.RandevuSure;
                poliklinikList.HastaneId = poliklinikler.HastaneId;
                poliklinikListDto.Add(poliklinikList);
            }
            return poliklinikListDto;
        }
    }
}
