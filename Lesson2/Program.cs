using Lesson2.Models;
namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var askInfo1 = new AskInfo();
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Введите возраст:");
            string age = Console.ReadLine();
             Console.WriteLine("\n");
            Console.WriteLine("Введите рост:");
            string height = Console.ReadLine(); 
            Console.WriteLine("\n");
            askInfo1.Name = name;
            askInfo1.Age = Convert.ToInt32(age);
            askInfo1.Height = Convert.ToDouble(height);
            Console.WriteLine($"Привет, {askInfo1.Name}!");
            Console.WriteLine($"\tВаш возраст: {askInfo1.Age} лет.");
            Console.WriteLine($"\t\tВаш рост: {askInfo1.Height}м.");
        }
    }
}