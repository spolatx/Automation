using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class TahlilSonuclar
    {
        public int id { get; set; }
        public string aciklama { get; set; }
        public string durum { get; set; }
        public string sonuc { get; set; }

        public int miktar { get; set; }
        public int tahlilId { get; set; }

    }
}
