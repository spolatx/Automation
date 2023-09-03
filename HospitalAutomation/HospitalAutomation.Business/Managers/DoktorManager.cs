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
    public class DoktorManager : IDoktorService
    {
        private readonly IDoktorRepository doktorRepository;

        public DoktorManager()=>doktorRepository=new DataServiceRegistration().GetDoktorRepositoryInstance();
        public List<DoktorListDto> GetDoktorList()
        {
            var doktorListDto = new List<DoktorListDto>();
            var doktorList = doktorRepository.GetListDoktor();
            foreach (var doktor in doktorList)
            {
                var doktorDto = new DoktorListDto();
                doktorDto.Id=doktor.Id;
                doktorDto.Ad = doktor.Ad;
                doktorDto.MeslekKodu=doktor.MeslekKodu;
                doktorListDto.Add(doktorDto);
            }
            return doktorListDto;
        }
    }
}
