using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunartha
{
    public class ListMobil
    {
        public int IDRegistrasi { get; set; }
        public string Tipe { get; set; }
        public string Merk { get; set; }
        public string Varian { get; set; }

        public override string ToString()
        {
            return $"{IDRegistrasi}, {Merk}, {Varian}";
        }
    }
}
