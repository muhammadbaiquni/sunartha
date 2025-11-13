namespace Sunartha;

public class Solution1
{
    public void Answer()
    {
        var listMobil = new List<ListMobil>()
        {
            new ListMobil() { IDRegistrasi = 1, Tipe = "Sedan", Merk = "Toyota", Varian = "FT86" },
            new ListMobil() { IDRegistrasi = 2, Tipe = "SUV", Merk = "Toyota", Varian = "RAV4" },
            new ListMobil() { IDRegistrasi = 3, Tipe = "Sedan", Merk = "Honda", Varian = "Accord" },
            new ListMobil() { IDRegistrasi = 4, Tipe = "SUV", Merk = "Honda", Varian = "CRV" },
            new ListMobil() { IDRegistrasi = 5, Tipe = "Sedan", Merk = "Honda", Varian = "City" }
        };

        void PrintList(string title, IEnumerable<ListMobil> list)
        {
            Console.WriteLine($"\n{title}");

            foreach (var item in list)
                Console.WriteLine(item.ToString());
        }

        // 1. Tampilkan data pertama yang memiliki merk Honda
        PrintList("Jawaban 1.1", listMobil.Where(x => x.Merk.Equals("honda", StringComparison.OrdinalIgnoreCase)).Take(1));

        // 2. Tampilkan data terakhir yang memiliki merk "Honda" dan bertipe "Sedan"
        PrintList("Jawaban 1.2", listMobil.Where(x => x.Merk.Equals("honda", StringComparison.OrdinalIgnoreCase) && x.Tipe.Equals("sedan", StringComparison.OrdinalIgnoreCase)).TakeLast(1));

        // 3. Tampilkan data pertama yang memiliki merk "Honda" dan varian "City"
        PrintList("Jawaban 1.3", listMobil.Where(x => x.Merk.Equals("honda", StringComparison.OrdinalIgnoreCase) && x.Varian.Equals("city", StringComparison.OrdinalIgnoreCase)).Take(1));

        // 4. Tampilkan data default yang memiliki merk "Toyota"
        PrintList("Jawaban 1.4", listMobil.Where(x => x.Merk.Equals("toyota", StringComparison.OrdinalIgnoreCase)));

        // 5. Tampilkan 3 data apa saja
        PrintList("Jawaban 1.5", listMobil.Take(3));
    }
}
