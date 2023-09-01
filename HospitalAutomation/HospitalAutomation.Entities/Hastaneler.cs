using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Hastaneler
    {
        public int Id { get; set; }
        public string HastaneAdi { get; set; }

        public int Telefon { get; set; }
        public int IlceId { get; set; }
    }
}
