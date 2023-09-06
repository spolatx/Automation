using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Ilceler
    {
        public int Id { get; set; }
        public string IlceAdi { get; set; }
        public int SehirId { get; set; }
    }
}
