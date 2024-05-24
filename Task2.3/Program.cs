namespace Task2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current console title is: \"{0}\"", Console.Title);
            Console.WriteLine("Press any key to change the console title.");
            Console.ReadKey(true);
            Console.Title = "Irina's Console";
            Console.WriteLine("Note that the new console title is \"{0}\"\n", Console.Title);
        }
    }
}
