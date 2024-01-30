using System;
namespace FactoryPattern
{
	public class Bass : IStringable
	{
		public Bass()
		{
        }

        public void Play()
        {
            Console.WriteLine("Great, we'll sign you up for bass lessons!");
            Console.WriteLine("The strings on a bass are E, A, D, and G.");
            Console.WriteLine("Get ready to play some low notes!");
        }
    }
}

