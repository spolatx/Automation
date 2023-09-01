using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Muayeneler
    {
        public int Id { get; set; }
        public string Tarih { get; set; }
        public int HastaKabulId { get; set; }

    }
}
