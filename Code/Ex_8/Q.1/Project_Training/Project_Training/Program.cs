using System;

namespace Project_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value to be divided by 0");
            int number = Convert.ToInt32(Console.ReadLine());
            try
            {
                int div = number / 0;
                Console.WriteLine("Divisible by 0");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
