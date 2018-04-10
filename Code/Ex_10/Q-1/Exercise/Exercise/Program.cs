using System;
using System.Collections.Generic;

namespace Exercise
{
    class Genericclass<T>
    {
        public Array Insert(Array arraygen)
        {
            Console.WriteLine("The items in array are : ");
            foreach (var item in arraygen)
            {
                Console.WriteLine(item);
            }
            return arraygen;

        }
        public Array Delete(Array arrcopy)
        {
            Array.Clear(arrcopy,0,arrcopy.Length-1);
            Console.WriteLine("Deleted array list : ");
            foreach (var item in arrcopy)
            {
                Console.WriteLine(item);
            }
            return arrcopy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var gen = new Genericclass<int>();
            var arraygen = new int[10]{ 1,2,5,3,6,3,5,63,65,5};
            gen.Insert(arraygen);

            Console.WriteLine("Enter the position to insert in array : ");
            int pos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number to insert in the array : ");
            int iteminsert = Convert.ToInt32(Console.ReadLine());

            var list1 = new List<int>();
            list1.AddRange(arraygen);
            list1.Insert(pos, iteminsert);

            Console.WriteLine("Elements in the list : ");
                       
            Console.WriteLine("Inserted list : ");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            var arrcopy = new int[15];
            list1.CopyTo(arrcopy);
            gen.Delete(arrcopy);
        }
    }
}


