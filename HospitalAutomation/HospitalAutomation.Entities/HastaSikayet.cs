using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class HastaSikayet
    {
        public int Id { get; set; }
        public string Tarih { get; set; }
        public string Sikayet { get; set; }
        public int HastaKabulId { get; set; }
        public int HastaId { get; set; }
    }
}
