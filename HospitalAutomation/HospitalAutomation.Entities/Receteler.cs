using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Receteler
    {
        public int id { get; set; }
        public int tarih { get; set; }
        public int kurumId { get; set; }
        public int doktorId { get; set; }
        public int hastaId { get; set; }
    }
}
