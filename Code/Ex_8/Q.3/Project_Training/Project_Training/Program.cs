using System;

    /* In this exercise, you will add functionality to the program that you created in Control Structures. 
    The program will examine the initial day number that is  entered by the user. If it is less than 1 or greater than 365, 
    the program will throw an InvalidArgument exception (“Day out of range”). 
    The program will trap this exception in a catch clause and display a diagnostic message on the console. */

namespace Project_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 365");
            int number=Convert.ToInt32(Console.ReadLine());

            try
            {
                if (number>1 && number <= 365)
                {
                    DateTime dt = new DateTime(2017, 1, 1);
                    Console.WriteLine(dt.AddDays(number).ToLongDateString());
                }
                else
                {
                    throw new InvalidArgumentException();
                }
            }
            catch (InvalidArgumentException ex)
            {
                Console.WriteLine("Day out of Range : "+ ex);                
            }  
        }
    }
}
