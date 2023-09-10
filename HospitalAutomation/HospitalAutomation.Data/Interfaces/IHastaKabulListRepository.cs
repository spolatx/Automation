using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Data.Interfaces
{
    public interface IHastaKabulListRepository
    {
        public void GetHastalar(HastaKabul hastaKabul);
        public List<HastaKabul> HastaSorgula(string tcno);
    }
}
