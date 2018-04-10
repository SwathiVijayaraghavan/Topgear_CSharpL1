using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Training
{
    class OutofRange : Exception
    {
        public void Method()
        {
            Console.WriteLine("Out of Range Exception");
        }
    }
}
