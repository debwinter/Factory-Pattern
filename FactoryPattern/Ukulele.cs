using System;
namespace FactoryPattern
{
	public class Ukulele : IStringable
	{
		public Ukulele()
		{
        }

        public void Play()
        {
            Console.WriteLine("Great, we'll sign you up for ukulele lessons!");
            Console.WriteLine("The strings on a ukulele are G, C, E, and A.");
            Console.WriteLine("They're made of a softer material than other strings and great to learn on!");
        }
    }
}

