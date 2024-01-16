using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB210156
{
    public class StudentiPorukeIB210156
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public DateTime Validnost { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }
        public Student Student { get; set; }
        public PredmetiIB210156 Predmet { get; set; }
    }
}
