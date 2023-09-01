using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Randevular
    {
        public int Id { get; set; }
        public int Tarih { get; set; }
        public int Saat { get; set; }
        public int Status { get; set; }
        public int HastaId { get; set; }
        public int DoktorId { get; set; }
        public int PoliklinikId { get; set; }
    }
}
