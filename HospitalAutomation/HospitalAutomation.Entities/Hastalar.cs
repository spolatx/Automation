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

        public string hastaAd { get; set; }

        public string hastaSoyad { get; set; }

        public int sicilNo { get; set; }

        public int cepTel { get; set; }

        public int isTel { get; set; }

        public int tcKimlikNo { get; set; }

        public string dogumTarihi { get; set; }

        public int cinsiyet { get; set; }

        public string Meslek { get; set; }

        public int kanGrubuId { get; set; }

        public int sehirId { get; set; }

        public int ilceId { get; set; }

        public int dogumYeriId { get; set; }
    }
}
