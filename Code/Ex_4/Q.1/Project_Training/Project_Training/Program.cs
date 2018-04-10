using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find if its a odd or even number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Number is an even number");
            }

            else
            {
                Console.WriteLine("Number is an odd number");
            }
        

        }
    }
}
