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
        public int sicilNo { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int diplomaNo { get; set; }
        public string adres { get; set; }
        public int cinsiyetId { get; set; }
        public int telNo { get; set; }
        public int telNo2 { get; set; }
        public string eMail { get; set; }
        public string dogumTarihi { get; set; }
        public string dogumYeri  { get; set; }
        public int unvanId { get; set; }
        public int klinikId { get; set; }
        public int hastaneId { get; set; }
    }
}
