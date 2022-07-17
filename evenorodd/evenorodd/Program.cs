public class Evenodd
{
    public static void Evnodd()
    {
        Console.WriteLine("Enter a numbers to check odd or even");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine($"The number is even");
        }
        else
        {
            Console.WriteLine($"The number is odd");
        }

    }
    public static void Main(string[] args)
    {
        Evnodd();
    }
}