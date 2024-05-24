namespace Task1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please fill the fields below:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Age: ");
            string age = Console.ReadLine();
            Console.Write("Profession: ");
            string profession = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Profession: {profession}");
        }
    }
}
