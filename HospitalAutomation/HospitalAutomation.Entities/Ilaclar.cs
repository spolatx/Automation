using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Ilaclar
    {
        public int Id { get; set; }
        public string IlacAdi { get; set; }
        public string IcerikBilgi { get; set; }
        public int Fiyat { get; set; }
    }
}
