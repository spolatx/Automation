using HospitalAutomation.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business.Interfaces
{
    public interface IPoliklinikService
    {
        List<PoliklinikListDto> GetPoliklinikList();
    }
}
