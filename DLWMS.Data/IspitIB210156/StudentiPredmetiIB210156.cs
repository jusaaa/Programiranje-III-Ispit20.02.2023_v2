using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB210156
{
    public class StudentiPredmetiIB210156
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
        public Student Student { get; set; }
        public PredmetiIB210156 Predmet { get; set; }

    }
}
