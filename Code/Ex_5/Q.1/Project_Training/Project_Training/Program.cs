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
            Console.WriteLine("Enter 5 numbers : ");
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements in the array are : ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            } 
            
        }
    }
}
