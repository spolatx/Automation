using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class HastaSikayet
    {
        public int id { get; set; }
        public string Tarih { get; set; }
        public string sikayet { get; set; }
        public int hastaKabulId { get; set; }
        public int hastaId { get; set; }
    }
}
