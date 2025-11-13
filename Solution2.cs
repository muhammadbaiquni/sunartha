using System.Text;

namespace Sunartha;

public class Solution2
{
    public void Answer1(int angka)
    {
        Console.WriteLine("Jawaban 2.1");
        for (int i = 1; i <= angka; i++)
        {
            var hasil = Tulis(i, (3, "tik"), (5, "tek"));
            Console.WriteLine(hasil ?? i.ToString());
        }
    }

    public void Answer2(int angka)
    {
        Console.WriteLine("\nJawaban 2.2");
        for (int i = 1; i <= angka; i++)
        {
            var hasil = Tulis(i, (3, "tik"), (5, "tek"), (7, "tok"));
            Console.WriteLine(hasil ?? i.ToString());
        }
    }

    private static string? Tulis(int value, params (int pembagi, string tulisan)[] aturan)
    {
        StringBuilder hasil = new StringBuilder();
        foreach (var (pembagi, tulisan) in aturan)
        {
            if (pembagi != 0 && value % pembagi == 0)
                hasil.Append(tulisan);
        }

        return hasil.Length == 0 ? null : hasil.ToString();
    }
}
