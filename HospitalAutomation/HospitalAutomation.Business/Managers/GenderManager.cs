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
    public class GenderManager : IGenderService
    {
        private readonly IGenderRepository genderRepository;
        public GenderManager() => genderRepository = new DataServiceRegistration().GetGenderRepositoryInstance();
        public List<GenderListDto> GetGenderList()
        {
            var genderListDto = new List<GenderListDto>();
            var genders = genderRepository.GetGenders();
            foreach (var gender in genders)
            {
                var genderDto = new GenderListDto();
                genderDto.Id = gender.Id;
                genderDto.Aciklama = gender.Aciklama;

                genderListDto.Add(genderDto);
            }

            return genderListDto;
        }
    }
}
