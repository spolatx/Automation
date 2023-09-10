using HospitalAutomation.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business.Interfaces
{
    public interface IHastaKabulService
    {
        public void CreateHastaKabul(RegisterHastalarDto hastalarDto);
        public List<RegisterHastalarDto> HastaSorgula(string tcno);
    }
}
