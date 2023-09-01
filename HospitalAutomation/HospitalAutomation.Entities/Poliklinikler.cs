using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Poliklinikler
    {
        public int id { get; set; }
        public string poliklinikAdi { get; set; }
        public int randevuSure { get; set; }
        public int hastaneId { get; set; }
    }
}
