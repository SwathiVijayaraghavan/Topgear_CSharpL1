using System;

namespace Project_Training
{
    class Program
    {
        static Array Method()
        {
            int[,] arr = new int[3,5];
            Console.WriteLine("The elements of the array are : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = 42;
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Program.Method();
        }
    }
}
