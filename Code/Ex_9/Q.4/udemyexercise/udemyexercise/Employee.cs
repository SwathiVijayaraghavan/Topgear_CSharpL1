/*	 Create a class called Person with a member variable name. Save it in a file called Person.cs.
 *	 Create a class called Employee who will inherit the Person class. 
 *	 The other data members of the employee class are annual salary (double), the year the employee started to work, 
 *	 and the national insurance number which is a String. Save this in a file called Employee.cs . 
 *	 Your class should have a reasonable number of constructors and accessor methods.
 *	 Write another class called TestEmployee, containing a main method to fully test your class definition  */

namespace udemyexercise
{
    class Employee : Person
    {
        public Employee(double _annualsalary)
        {
            System.Console.WriteLine("The double annual salary is: "+ _annualsalary);
        }
        public Employee(double _annualsalary,int _empworkst)
        {
            System.Console.WriteLine("The double annual salary of employee number "+_empworkst+ " is: " + _annualsalary);

        }
        public Employee(double _annualsalary, int _empworkst, string nationalinsnum)
        {
            System.Console.WriteLine("The double annual salary of " + _empworkst +" with national insurance number : "+nationalinsnum+ " is: " + _annualsalary);

        }

    }
}
