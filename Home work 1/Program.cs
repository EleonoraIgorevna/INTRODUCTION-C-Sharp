using System;

namespace Home_work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя.");
            string name;
            name = Console.ReadLine();
            Console.WriteLine($"Привет,  {name} ! Сегодня { DateTime.Now }");
        }
    }
}
