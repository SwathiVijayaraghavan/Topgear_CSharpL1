using System;
namespace Exercise
{
    class Fan
    {
        const int slow = 1;
        const int medium = 2;
        const int fast = 3;
        private int speed = slow;
        private bool name = false;
        private double radius = 5;
        private string color = "red";
        public Fan()
        {
            ToString();
        }
        public override string ToString()
        {
          return  "Current status of fan : " + "Speed of fan is  "+ speed +
                  ", Color of fan is: " + color + ", Name of the fan is " +name +  ", Radius of the fan is " + radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var fan = new Fan();
            System.Console.WriteLine(fan);
        }
    }
}

