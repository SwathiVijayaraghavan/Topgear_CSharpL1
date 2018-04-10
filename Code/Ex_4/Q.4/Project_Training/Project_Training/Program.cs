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
            Console.WriteLine("Enter a string : ");
            string name=Console.ReadLine();

            string splitstr = name.Substring(1);
            Console.WriteLine("New string is : "+splitstr);
        }
    }
}
