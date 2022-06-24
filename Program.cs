using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Сколько Вам лет?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Где Вы живете?");
            string home = Console.ReadLine();
            Console.WriteLine("Где Вы работаете?");
            string work = Console.ReadLine();
            Console.WriteLine($"Вы {name}, вам {age} год, вы живете {home}, работаете на {work}");
        }
    }
}
