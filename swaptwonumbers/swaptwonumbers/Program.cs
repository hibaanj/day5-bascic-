public class Swappingnumbers
{
    public void Swapnumber()
    {
        
        Console.WriteLine("Enter two numbers to swap");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"the value of a and b before swapping is a = {a} and b = {b}");

        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"the value of a and b after swapping is a = {a} and b = {b}");

    }
    public static void Main(string[] args)
    {
        Swappingnumbers sn = new Swappingnumbers();
        sn.Swapnumber();
    }
}