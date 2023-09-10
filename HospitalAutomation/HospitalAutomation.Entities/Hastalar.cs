using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Hastalar
    {
        public int Id { get; set; }

        public string HastaAd { get; set; }

        public string HastaSoyad { get; set; }

        public int SicilNo { get; set; }

        public int CepTel { get; set; }

        public int IsTel { get; set; }

        public int TcKimlikNo { get; set; }

        public string DogumTarihi { get; set; }

        public int Cinsiyet { get; set; }

        public string Meslek { get; set; }

        public int KanGrubuId { get; set; }

        public int SehirId { get; set; }

        public int IlceId { get; set; }

        public int DogumYeriId { get; set; }

        public string Aciklama { get; set; }
        public string KanGrubu { get; set; }

        public string DogumYeri { get; set; }
    }
}
