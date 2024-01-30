using System;
namespace FactoryPattern
{
	public class Guitar : IStringable
	{
		public Guitar()
		{
		}

        public void Play()
        {
            Console.WriteLine("Great, we'll sign you up for guitar lessons!");
            Console.WriteLine("The strings on a guitar are E, A, D, G, B, and E.");
            Console.WriteLine("One way to remember this is with the line:");
            Console.WriteLine("Eddie Ate Dynamite. Good Bye Eddie!");
        }
    }
}

