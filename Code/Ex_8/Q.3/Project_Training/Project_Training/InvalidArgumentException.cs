using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Training
{
    class InvalidArgumentException : Exception
    {
        public void method()
        {
            Console.WriteLine("Invalid Argument Exception");
        }
    }
}
