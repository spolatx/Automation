using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Dtos
{
    public class RegisterHastalarDto
    {
        public string TcNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int CinsiyetId { get; set; }
        public int KanGrubuId { get; set; }
        public int DogumYeriId { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string CepTel { get; set; }
        public string Istel { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public int PoliklinikId { get; set; }
        public int DoktorId { get; set; }




    }
}
