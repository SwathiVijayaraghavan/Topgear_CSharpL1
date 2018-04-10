using System;
//Create a delegate type that points to a method, which takes an array of int as the parameter and performs operations on the array.
//Make the delegate point to methods like Print(), Reverse() and Sort() and perform those operations.

namespace Project_Training
{
    delegate void method(Array array1);
    class Program
    {
        static void Method(Array array1)
        {
            Console.WriteLine("Printing the array elements");
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Reversing the array elements");
            Array.Reverse(array1);
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorting the array elements");
            Array.Sort(array1);
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }

        }
        static void Main(string[] args)
        {
            var intarr = new int[] { 1, 8, 6, 9, 3, 5, 15 };
            method meth = new method(Method);
            meth(intarr);
            
        }
    }
}
