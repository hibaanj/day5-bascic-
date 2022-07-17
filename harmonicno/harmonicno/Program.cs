using System;

namespace day5
{
    public class Harmonica
    {
        public void Harmno()

        {

            double harm = 0;
            Console.WriteLine("enter the value of n - ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    harm = harm + (1.0 / i);
                    if (i == n)
                    {
                        Console.Write($"1/{n}");
                        break;
                    }
                    Console.Write($"1/{i} + ");
                }
                Console.WriteLine($"\nThe value of {n}th harmonic number is {harm}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        public static void Main(string[] args)
        {
            Harmonica harm = new Harmonica();   
            harm.Harmno();
        }
    }
}