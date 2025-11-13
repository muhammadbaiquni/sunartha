namespace Sunartha;

public class Program
{
    public static void Main(String[] args)
    {
        var solution1 = new Solution1();
        solution1.Answer();

        Console.WriteLine("\n=======\n");

        var solution2 = new Solution2();
        solution2.Answer1(500);
        solution2.Answer2(500);
    }
}