using System;

namespace Project_Training
{
    public class RandomHelper
    {
        static double ran1;
        static int ran;
        public static int Randint(int a, int b)
        {
            var rand = new Random();
            ran = rand.Next(a,b);
            return ran;            
        }
        public static double Randdouble(double a1,double b1)
        {
            var rand1 = new Random();
            ran1 = rand1.NextDouble();
            return ran1;
        }
           
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 2 integers for generating a random number between them");
                int num = Convert.ToInt32(Console.ReadLine());
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter 2 integers for generating a random double number between them");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double num3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Random number between integers is : "+RandomHelper.Randint(num,num1));
                Console.WriteLine("Random number between integers is : "+RandomHelper.Randdouble(num2,num3));

            }
            catch (Exception e)
            {
                Console.WriteLine("Check inputs. " + e.Message.ToString());
            }

        }

    }
}
