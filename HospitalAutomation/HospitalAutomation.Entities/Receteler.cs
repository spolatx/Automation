using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Receteler
    {
        public int Id { get; set; }
        public int Tarih { get; set; }
        public int KurumId { get; set; }
        public int DoktorId { get; set; }
        public int HastaId { get; set; }
    }
}
