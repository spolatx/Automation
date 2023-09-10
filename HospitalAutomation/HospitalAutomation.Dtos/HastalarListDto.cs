using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Dtos
{
    public class HastalarListDto
    {
        public int ID { get; set; }
        public string HastaAd { get; set; }
        public string HastaSoyad { get; set; }
        public int tckimlikNo { get; set; }

        public string Aciklama { get; set; }

        public string KanGrubuAdi { get; set; }

        public string DogumYeri { get; set; }
        public string DogumTarihi { get; set; }
    }
}
