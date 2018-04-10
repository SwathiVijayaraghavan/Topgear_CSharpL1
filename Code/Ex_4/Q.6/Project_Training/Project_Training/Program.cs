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
            Console.Write("Enter a string : ");
            string name=Console.ReadLine();

            string strnew = string.Copy(name);
            Console.WriteLine("Copied string is : "+strnew);
        }
    }
}
