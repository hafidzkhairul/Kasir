using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasir
{
    public class Penjualan
    {
        public string NoJual { get; set; }
        public DateTime TglJual { get; set; }
        public int ItemJual { get; set; }
        public int TotalJual { get; set; }
        public int diBayar { get; set; }
        public int Kembali { get; set; }
        public string KodeKasir { get; set; }
    }
}
