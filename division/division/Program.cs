public class Division
{
    public void Remquo()
    {
        Console.WriteLine("enter the dividend");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the divisor");
        int b = Convert.ToInt32(Console.ReadLine());

        if ((a > 0) && (b > 0))
        {
            Console.WriteLine($"The quotient is {a / b}");
            Console.WriteLine($"The remainder is {a % b}");
        }
        else
        {
            Console.WriteLine("Invalud input, negative integers are not allowed");
        }
    }
    public static void Main(string[] args){
        Division dev = new Division();
        dev.Remquo();
    }
}