using System;

namespace day5
{
    public class Leap
    {
        public void LEapyear()
        {
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((1000 <= year ) && (year < 10000))
            {
                if ((year > 0))
                {
                    //1-to check div by 4
                    if (year % 4 == 0)
                    {

                        //2-div by 100
                        if (year % 100 == 0)
                        {
                            //3-div by 400
                            if (year % 400 == 0)
                            {
                                //4-leap year
                                Console.WriteLine("leap year");
                            }
                            //5- not a leap year
                            else
                            {
                                Console.WriteLine("not a leap year");



                            }
                        }


                        //4 leap year
                        else
                        {
                            Console.WriteLine(" a leap year");
                        }
                    }
                    //5 not a leap year
                    else
                    {
                        Console.WriteLine("not a leap year");
                    }
                }

            }
            else
            {
                Console.WriteLine("not a 4 digit number");
            }

        } 
        public static void Main(string[] args)
        {
            Leap year = new Leap();
            year.LEapyear();
        }
    } 
}