namespace Lesson2Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            float first_number = Convert.ToSingle(Console.ReadLine());
            Console.Write("\nEnter the second number: ");
            float second_number = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\nResults:");
            Console.WriteLine($"\n {first_number} + {second_number} = {first_number + second_number}");
            Console.WriteLine($"\n {first_number} - {second_number} = {first_number - second_number}");
            Console.WriteLine($"\n {first_number} * {second_number }= {first_number * second_number}");
            Console.WriteLine($"\n {first_number} / {second_number} = {first_number / second_number}");

        }
    }
}