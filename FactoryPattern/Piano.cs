using System;
namespace FactoryPattern
{
	public class Piano : IStringable
	{
		public Piano()
		{
		}

        public void Play()
        {
            Console.WriteLine("I'm not sure we offer lessons on the instrument you're thinking of.");
            Console.WriteLine("Why don't we start you on piano? It's great for building music fundamentals.");
            Console.WriteLine("Many people don't realize that pianos are actually string instruments!");
            Console.WriteLine("In your first lesson, we'll open up the piano and show you the strings inside.");
        }
    }
}

