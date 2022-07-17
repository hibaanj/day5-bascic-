using System;

namespace Coreprogram
{
    public class Coin
    {
        public void Coinflip()
        {
            double head =0, tail = 0,limit = 0.5;
            Console.WriteLine("enter the times you want to flip the coin");
            int flip = Convert.ToInt32(Console.ReadLine());
            if(flip > 0)
            {
                for(int i =0; i<=flip; i++)
                {
                    Random rn = new Random();
                    int output = rn.Next(0, 2);
                    //Console.WriteLine(output);
                    if (output < 0.5)
                    {
                        //Console.WriteLine("tails");
                        tail++;
                    }
                    else
                    {

                        //Console.WriteLine("head");
                        head++;
                    }
                }
                //Console.WriteLine( head);
                //Console.WriteLine(tail);
                double prehead = (head / flip) * 100;
                double pretail = (tail / flip) * 100;
                Console.WriteLine($"the head percentage is {prehead} %");
                Console.WriteLine($"the tail percentage is {pretail} %");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
            

        }
        public static void Main(string[] args)
        {
            Coin c = new Coin();
            c.Coinflip();
            
        }
    }
}