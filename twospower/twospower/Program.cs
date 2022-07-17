using System;

namespace day5
{
    public class Power
    {
        public static void Power2()

        {
            int n = Convert.ToInt32(Console.ReadLine());
            int limit = 31, num = 0;
            if (n <= limit)
            {
                while (num <= n)
                {
                    double power = Math.Pow(2, num);
                    Console.WriteLine(power);
                    num++;
                }
            }
            else
            {
                Console.WriteLine($"Invalid input, limit is {limit}");
            }
        }
        public static void Main(string[] args)
        {
            Power2();
        }
    }
}