using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunartha
{
    public class Solution2
    {
        public void Answer1(int angka)
        {
            Console.WriteLine("Jawaban 2.1");
            for (int i = 1; i <= angka; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("tiktek");
                else if (i % 3 == 0) Console.WriteLine("tik");
                else if (i % 5 == 0) Console.WriteLine("tek");
                else Console.WriteLine(i);
            }
        }

        public void Answer2(int angka)
        {
            Console.WriteLine("\nJawaban 2.2");
            for (int i = 1; i <= angka; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0) Console.WriteLine("tiktektok");
                else if (i % 3 == 0 && i % 7 == 0) Console.WriteLine("tiktok");
                else if (i % 5 == 0 && i % 7 == 0) Console.WriteLine("tektok");
                else if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("tiktek");
                else if (i % 3 == 0) Console.WriteLine("tik");
                else if (i % 5 == 0) Console.WriteLine("tek");
                else if (i % 7 == 0) Console.WriteLine("tok");
                else Console.WriteLine(i);
            }
        }
    }
}
