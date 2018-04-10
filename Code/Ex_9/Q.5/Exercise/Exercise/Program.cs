using System;
namespace Exercise
{
    abstract class Instrument
    {
        public abstract void play();
    }
    class Piano : Instrument
    {
        public override void play()
        {
            Console.WriteLine("Piano is playing tan tan tan tan");
        }
    }
    class Flute : Instrument
    {
        public override void play()
        {
            Console.WriteLine("Flute is playing toot toot toot toot");
        }
    }
    class Guitar : Instrument
    {
        public override void play()
        {
            Console.WriteLine("Guitar is playing tin tin tin");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Instrument[] i = new Instrument[10];
            for (int id = 0; id < 10; id += 3)
            {
                i[id] = new Piano();
                if (id + 1 < 10)
                    i[id + 1] = new Flute();
                if (id + 2 < 10)
                    i[id + 2] = new Guitar();
            }
            Console.WriteLine("Is of type : "+i[2].GetType());
            i[2].play();
        }
    }
}


