using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Personeller
    {
        public int Id { get; set; }
        public int SicilNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DiplomaNo { get; set; }
        public string Adres { get; set; }
        public int CinsiyetId { get; set; }
        public int TelNo { get; set; }
        public int TelNo2 { get; set; }
        public string EMail { get; set; }
        public string DogumTarihi { get; set; }
        public string DogumYeri  { get; set; }
        public int UnvanId { get; set; }
        public int KlinikId { get; set; }
        public int HastaneId { get; set; }
        public string MeslekKodu { get; set; }
    }
}
