using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Hastaneler
    {
        public int id { get; set; }
        public string hastaneAdi { get; set; }

        public int telefon { get; set; }
        public int IlceId { get; set; }
    }
}
