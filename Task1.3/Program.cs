namespace Task1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write your year of birth: ");
            int YearOfBirth = int.Parse(Console.ReadLine());
            int CurrentYear = DateTime.Now.Year;
            int age = CurrentYear - YearOfBirth;
            Console.WriteLine("You are " + age + " years old.");
        }
    }
}
