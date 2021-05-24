using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
            //Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.

            /*
            static void Main(string[] args)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Какая у тебя фамилия?");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("Какое имя.");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Напиши отчество.");
                    string Patronymic = Console.ReadLine();
                    string FullName = GetFullName(FirstName, LastName, Patronymic);
                    Console.WriteLine(FullName);
                }
            }
            static string GetFullName(string FirstName, string LastName, string Patronymic)
            {
                string UserName =  FirstName +" "+ LastName + " " + Patronymic ;
                return UserName; 
            }
            //2
            static void Main(string[] args)
            {
                Console.WriteLine("Введи числа.");
                string value = Console.ReadLine();
                int SumOfValue = GetSum(value);
                Console.WriteLine(SumOfValue);
                Console.ReadLine();
            }
            static int GetSum(string value)
            {
                string[] quantity = value.Split(' ');// пробел как разделитель
                int SumOfValue = 0;
                for (int i = 0; i < quantity.Length; i++)
                {
                    string quantityvalue = quantity[i];
                    int quantityvalue01 = int.TryParse(quantityvalue, out int num)
                        ? num
                        : 0;
                    SumOfValue = SumOfValue + quantityvalue01;
                }
                return SumOfValue;
                */
        }
    }
}
