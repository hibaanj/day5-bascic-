public class Factors
{
    public void primefactor()
    {
      
            int y = 0;
            Console.WriteLine("enter the value of n ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                while (n % 2 == 0)
                {
                    Console.WriteLine(2 + " ");
                    n /= 2;
                }
                //if n gets odd
                for(int i = 3; i < Math.Sqrt(n); i += 2)
                {
                    while (n % i == 0)
                    {
                        Console.WriteLine(2 + " ");
                        n /= i;
                    }

                }
                if (n > 2)
                {
                    Console.WriteLine(n);
                }
            }
            else
            {
                Console.WriteLine("Invalud input");
            }
        
    }
    public static void Main(string[] args)
    {
        Factors f = new Factors();
        f.primefactor();
    }
}