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
            var intarr1 = new int[2,2];
            var intarr2 = new int[2,2];
            var result = new int[2, 2];

            Console.WriteLine("Enter values for 2x2 matrix1 : ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    intarr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter values for 2x2 matrix2 : ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    intarr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The resulting matrix is : ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[0, 0] = intarr1[0, 0] * intarr2[0, 0] + intarr1[0, 1] * intarr2[1, 0];
                    result[0, 1] = intarr1[0, 0] * intarr2[0, 1] + intarr1[0, 1] * intarr2[1, 1]; 
                    result[1, 0] = intarr1[1, 0] * intarr2[0, 0] + intarr1[1, 1] * intarr2[1, 0]; 
                    result[1, 1] = intarr1[1, 0] * intarr2[0, 1] + intarr1[1, 1] * intarr2[1, 1]; 

                }
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
