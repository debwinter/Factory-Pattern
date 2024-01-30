using System;
namespace FactoryPattern
{
	public static class StringFactory
	{
		public static IStringable NewStringable(string input)
		{
			switch (input)
			{
				case "4":
					return FourStrings();
				case "5":
					return new Banjo();
				case "6":
					return new Guitar();
				case "8":
					return new Mandolin();
				default:
					return new Piano();
			}
		}

		public static IStringable FourStrings()
		{
			Console.WriteLine();
			Console.WriteLine("We have three options with 4 strings! Would you like a ukulele, violin, or bass?");
			string userInput = Console.ReadLine();
			switch (userInput.ToLower())
			{
				case "ukulele" or "uke" or "u" or "ukelele":
					return new Ukulele();
				case "violin":
					return new Violin();
				case "bass":
					return new Bass();
				default:
					return new Piano();
			}
		}
	}
}

