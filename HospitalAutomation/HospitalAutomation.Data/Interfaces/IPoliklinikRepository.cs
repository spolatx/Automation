using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Data.Interfaces
{
    public interface IPoliklinikRepository
    {
        List<Poliklinikler>GetPoliklinikler();
    }
}
