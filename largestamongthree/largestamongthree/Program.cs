public class Largest
{
    public void Largestnumber()
    {
        Console.WriteLine("Enter three numbers");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        var largest = a > b ? (a > c ? a : c) : (b > c ? b : c);
        Console.WriteLine($"the largest numbeer is {largest} ");
    }
    public static void Main(string[] args)
    {
        Largest number = new Largest();
        number.Largestnumber();

    }
}