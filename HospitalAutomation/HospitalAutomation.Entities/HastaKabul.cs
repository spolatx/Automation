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

        public string GelisTarihi { get; set; }

        public int Sikayet { get; set; }

        public int Durum { get; set; }

        public int CikisTarihi { get; set; }

        public int HastaId { get; set; }

        public int DoktorId { get; set; }
        public int PoliklinikId { get; set; }
        public int RandevuId { get; set; }
    }
}
