using System;
namespace FactoryPattern
{
	public class Mandolin : IStringable
	{
		public Mandolin()
		{
        }

        public void Play()
        {
            Console.WriteLine("Great, we'll sign you up for mandolin lessons!");
            Console.WriteLine("The notes on a mandolin are G, D, A, and E.");
            Console.WriteLine("Each note has two strings an octave apart, for a total of 8!");
        }
    }
}

