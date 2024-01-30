using System;
namespace FactoryPattern
{
	public class Violin : IStringable
	{
		public Violin()
		{
        }

        public void Play()
        {
            Console.WriteLine("Great, we'll sign you up for violin lessons!");
            Console.WriteLine("The strings on a violin are G, D, A, and E.");
            Console.WriteLine("When you learn violin, you will need to use a bow.");
        }
    }
}

