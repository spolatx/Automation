using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class HastaGecmisi
    {
        public int GecmisId { get; set; }

        public string Tarih { get; set; }

        public string Aciklama { get; set; }

        public int SurekliKullanilanIlaclar { get; set; }

        public int GecirdigiHastaliklar { get; set; }

        public int GecirdigiAmeliyatlar { get; set; }

        public int Alerjiler { get; set; }

        public int HastaId { get; set; }
    }
}
