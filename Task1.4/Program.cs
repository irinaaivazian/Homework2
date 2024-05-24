namespace Task1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write your age: ");
            int age = int.Parse(Console.ReadLine());
            int CurrentYear = DateTime.Now.Year;
            int YearOfBirth = CurrentYear - age;
            Console.WriteLine("You were born in " + YearOfBirth);
        }
    }
}
