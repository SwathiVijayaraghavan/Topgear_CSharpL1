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
            Console.WriteLine("Enter a string to check if its a palindrome or not");
            string name=Console.ReadLine();

            char[] Name = name.ToCharArray();
            Array.Reverse(Name);

            string namerev = new string(Name);

            if (name ==namerev)
            {
                Console.WriteLine("Is a plaindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
           
        

        }
    }
}
