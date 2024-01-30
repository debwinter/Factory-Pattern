using System;
namespace FactoryPattern
{
	public class Banjo : IStringable
	{
		public Banjo()
		{
        }

        public void Play()
        {
            Console.WriteLine("Great, we'll sign you up for banjo lessons!");
            Console.WriteLine("The strings on a banjo are G, D, G, B, and D.");
            Console.WriteLine("This is the only instrument with high note strings on both ends!");
        }
    }
}

