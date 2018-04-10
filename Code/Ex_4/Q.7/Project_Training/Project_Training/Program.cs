using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*•	In this exercise, you will write a program that reads an integer day number (between 1 and 365) from the console and stores it in an integer variable.
 *  The program will convert this number into a month and a day of the month and then print the result to the console.
 *  For example, entering 40 should result in “February 9” being displayed.*/
namespace Project_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 365");
            int number=Convert.ToInt32(Console.ReadLine());

            if (number <= 365)
            {
                DateTime dt = new DateTime(2017,1,1);
                Console.WriteLine(dt.AddDays(number).ToLongDateString());
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}
