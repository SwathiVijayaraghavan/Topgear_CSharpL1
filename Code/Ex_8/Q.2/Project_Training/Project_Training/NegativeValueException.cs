using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Training
{
    class NegativeValueException : Exception
    {
        public void Method()
        {
            Console.WriteLine("Negative value exception");
        }
    }
}
