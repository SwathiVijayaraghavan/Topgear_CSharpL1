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
            Console.WriteLine("Enter a number to print the fibonacci series");
            int number = Convert.ToInt32(Console.ReadLine());

            int n0 = 0; int n1 = 1;
            Console.Write("The fibonacci series is {0} {1} ",n0,n1);
            for (int i = 2  ; i < number; i++)
            {
                int sum = n0 + n1;
                Console.Write(sum+" ");
                n0 = n1;
                n1 = sum;

            }
        

        }
    }
}
