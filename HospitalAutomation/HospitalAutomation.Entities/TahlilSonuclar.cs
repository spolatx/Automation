using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class TahlilSonuclar
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public string Durum { get; set; }
        public string Sonuc { get; set; }
        public int Miktar { get; set; }
        public int TahlilId { get; set; }

    }
}
