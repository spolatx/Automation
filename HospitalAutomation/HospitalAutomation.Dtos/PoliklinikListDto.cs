using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Dtos
{
    public class PoliklinikListDto
    {
        public int Id { get; set; }
        public string PoliklinikAdi { get; set; }
        public int RandevuSure { get; set; }
        public int HastaneId { get; set; }
    }
}
