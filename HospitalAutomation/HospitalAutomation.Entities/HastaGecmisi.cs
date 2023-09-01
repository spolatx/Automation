using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class HastaGecmisi
    {
        public int gecmisId { get; set; }

        public string tarih { get; set; }

        public string aciklama { get; set; }

        public int surekliKullanilanIlaclar { get; set; }

        public int gecirdigiHastaliklar { get; set; }

        public int gecirdigiAmeliyatlar { get; set; }

        public int alerjiler { get; set; }

        public int hastaId { get; set; }
    }
}
