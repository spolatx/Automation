using HospitalAutomation.Dtos;
using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business.Interfaces
{
    public interface IIlceService
    {
        public List<IlceListDto> GetIlceList();
    }
}
