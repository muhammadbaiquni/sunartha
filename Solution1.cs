using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunartha
{
    public class Solution1
    {
        public void Answer()
        {
            IEnumerable<ListMobil> listMobil = new List<ListMobil>()
            {
                new ListMobil() { IDRegistrasi = 0001, Tipe = "Sedan", Merk = "Toyota", Varian = "FT86" },
                new ListMobil() { IDRegistrasi = 0002, Tipe = "SUV", Merk = "Toyota", Varian = "RAV4" },
                new ListMobil() { IDRegistrasi = 0003, Tipe = "Sedan", Merk = "Honda", Varian = "Accord" },
                new ListMobil() { IDRegistrasi = 0004, Tipe = "SUV", Merk = "Honda", Varian = "CRV" },
                new ListMobil() { IDRegistrasi = 0005, Tipe = "Sedan", Merk = "Honda", Varian = "City" }
            };

            // 1. Tampilkan data pertama yang memiliki merk Honda
            Console.WriteLine("Jawaban 1.1");
            var satu = listMobil
                .Where(x => x.Merk.ToLower() == "honda")
                .Select(x => new ListMobil { IDRegistrasi = x.IDRegistrasi, Merk = x.Merk, Varian = x.Varian })
                .First();
            Console.WriteLine(satu.ToString());

            // 2. Tampilkan data terakhir yang memiliki merk "Honda" dan bertipe "Sedan"
            Console.WriteLine("\nJawaban 1.2");
            var dua = listMobil.Where(x => x.Merk.ToLower() == "honda" && x.Tipe.ToLower() == "sedan")
                .Select(x => new ListMobil { IDRegistrasi = x.IDRegistrasi, Merk = x.Merk, Varian = x.Varian })
                .Last();
            Console.WriteLine(dua.ToString());

            // 3. Tampilkan data pertama yang memiliki merk "Honda" dan varian "City"
            Console.WriteLine("\nJawaban 1.3");
            var tiga = listMobil.Where(x => x.Merk.ToLower() == "honda" && x.Varian.ToLower() == "city")
                .Select(x => new ListMobil { IDRegistrasi = x.IDRegistrasi, Merk = x.Merk, Varian = x.Varian })
                .First();
            Console.WriteLine(tiga.ToString());

            // 4. Tampilkan data default yang memiliki merk "Toyota"
            Console.WriteLine("\nJawaban 1.4");
            var empat = listMobil.Where(x => x.Merk.ToLower() == "toyota")
                .Select(x => new ListMobil { IDRegistrasi = x.IDRegistrasi, Merk = x.Merk, Varian = x.Varian })
                .ToList();
            foreach (var list in empat)
            {
                Console.WriteLine(list.ToString());
            }

            // 5. Tampilkan 3 data apa saja
            Console.WriteLine("\nJawaban 1.5");
            var lima = listMobil
                .Select(x => new ListMobil { IDRegistrasi = x.IDRegistrasi, Merk = x.Merk, Varian = x.Varian })
                .Take(3);
            foreach (var list in lima)
            {
                Console.WriteLine(list.ToString());
            }
        }
    }
}
