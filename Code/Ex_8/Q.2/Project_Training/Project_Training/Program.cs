using System;

namespace Project_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three values to calculate average");
            int number = Convert.ToInt32(Console.ReadLine());
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (number > 100 || number < 0)
                    throw new OutofRange();

                if ((number2 < 0) || (number1 < 0) || (number < 0))
                    throw new NegativeValueException();
            }
            catch (NegativeValueException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            catch (OutofRange ex1)
            {
                Console.WriteLine(ex1.ToString());
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid datatype is not correct");
            }
            int average = (number + number1 + number2) / 3;
            Console.WriteLine("The average is : "+average);
        }
    }
}
