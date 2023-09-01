using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Ilaclar
    {
        public int id { get; set; }
        public string ilacAdi { get; set; }
        public string icerikBilgi { get; set; }
        public int fiyat { get; set; }
    }
}
