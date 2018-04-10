using System;

namespace Project_Training
{
    public class Employee
    {
        public string _empname;
        public Employee(string _empname,double _basicsalary)
        {
            string Employeename = _empname;
            double basicsalary = _basicsalary;
            CalculateNetPay(Employeename,basicsalary);  
        }
        public void CalculateNetPay(string Employeename, double basicsalary)
        {
            double HRA = 0.15 * basicsalary;
            double DA = 0.10 * basicsalary;
            double _grosspay = HRA + DA + basicsalary;
            double _tax = 0.08 * _grosspay;
            double _netpay = _grosspay - (_tax);
            Console.WriteLine("The basic pay is : " + basicsalary);
            Console.WriteLine("The gross pay is : " + _grosspay);
            Console.WriteLine("The net pay is : " + _netpay);
            Console.WriteLine("The tax is : " + _tax);
            Console.WriteLine("HRA is : " + HRA);
            Console.WriteLine("DA is : " + DA);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the name of the employee");
                string Name = Console.ReadLine();

                Console.WriteLine("Enter the salary of the employee");
                double basicpay = Convert.ToDouble(Console.ReadLine());
                var emp = new Employee(Name, basicpay);
            }
            catch (Exception e)
            {
                Console.WriteLine("Check inputs. "+e.Message.ToString());
            } 

        }

    }
}
