using System;

namespace Project_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number between 1 and 365");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a year");
                int year = Convert.ToInt32(Console.ReadLine());
                bool val = DateTime.IsLeapYear(year);
                Console.WriteLine(val);

                if (val == true && number > 1 && number <= 366)
                {
                    Console.WriteLine(year + " : Is a leap year");
                }

                else if (val == false && number > 1 && number < 365)
                {
                    Console.WriteLine(year + " : Is not a leap year");

                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (val == true)
                {
                    Console.WriteLine("The month and date pairs are as follows : ");
                    DateTime dt =  new DateTime(year,1,number);
                    for (int i = 0; i < 12; i++)
                    {
                        if (dt.Day != DateTime.DaysInMonth(year, dt.Month))
                            Console.WriteLine(dt.AddMonths(i).ToLongDateString());

                        else
                            Console.WriteLine("Invalid error");

                    }
                }
               
            }
            catch (Exception e)
            {

                Console.WriteLine("Check your inputs"+e.ToString()); ;
            }
            
        }

    }
}
