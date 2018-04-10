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
            Console.WriteLine("Enter the size of a side of a square");
            int size = Convert.ToInt32(Console.ReadLine());

            int area = size*size;
            Console.WriteLine("The area of the square is: "+area);

            Console.ReadLine();
        }
    }
}
