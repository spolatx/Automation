using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class HastaKabul
    {
        public int Id { get; set; }

        public string gelisTarihi { get; set; }

        public int sikayet { get; set; }

        public int durum { get; set; }

        public int cikisTarihi { get; set; }

        public int hastaId { get; set; }

        public int doktorId { get; set; }
        public int poliklinikId { get; set; }
        public int randevuId { get; set; }
    }
}
