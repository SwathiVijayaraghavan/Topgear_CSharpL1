using System;

namespace Exercise
{
    abstract class Fruit
    {
        public string name { get; set; }
        public string taste { get; set; }
        public abstract void eat();
        
    }
   class apple : Fruit
   {
      public override void eat()
      {
            name = "apple";
            taste = "sweet";
            Console.WriteLine("The name of the fruit is : "+name);
            Console.WriteLine("The taste of "+name+" is " + taste);
      }
   }
   class orange : Fruit
   {
      public override void eat()
      {
            name = "orange";
            taste = "nice";
            Console.WriteLine("The name of the fruit is : " + name);
            Console.WriteLine("The taste of " + name + " is " + taste);
      }
   }

   class Program
   {
     static void Main(string[] args)
     {
            Console.WriteLine("Apple fruit attributes : ");
            var app = new apple();
            app.eat();
            Console.WriteLine();

            Console.WriteLine("Orange fruit attributes : ");
            var orr = new orange();
            orr.eat();       
     }
   }   
}


