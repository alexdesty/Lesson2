using Lesson2.Models;
namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var askInfo1 = new AskInfo();
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("\nВведите возраст: ");
            var age = Console.ReadLine();
            Console.Write("\nВведите рост: ");
            var height = Console.ReadLine();
            askInfo1.Name = name;
            askInfo1.Age = Convert.ToInt32(age);
            askInfo1.Height = Convert.ToSingle(height);
            Console.WriteLine($"\nПривет, {askInfo1.Name}!");
            Console.WriteLine($"\tВаш возраст: {askInfo1.Age} лет.");
            Console.WriteLine($"\t\tВаш рост: {askInfo1.Height}м.");
        }
    }
}