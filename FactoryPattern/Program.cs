namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our music school!");
            Console.WriteLine();
            Console.WriteLine("We specialize in string instruments.");
            Console.WriteLine("Sign up for lessons below.");
            Console.WriteLine("How many strings are on the instrument you'd like to play?");
            string userInput = Console.ReadLine();

            IStringable instrument = StringFactory.NewStringable(userInput);

            Console.WriteLine();
            instrument.Play();
        }
    }
}
