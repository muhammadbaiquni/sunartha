using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunartha
{
    public class Mobil
    {
        public int IDRegistrasi { get; }
        public string Tipe { get; }
        public string Merk { get; }
        public string Varian { get; }

        public Mobil(int idRegistrasi, string tipe, string merk, string varian)
        {
            IDRegistrasi = idRegistrasi;
            Tipe = tipe;
            Merk = merk;
            Varian = varian;
        }

        public override string ToString()
        {
            return $"{IDRegistrasi}, {Merk}, {Varian}";
        }
    }
}
