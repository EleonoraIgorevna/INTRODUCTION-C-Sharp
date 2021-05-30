using System;


namespace Homework_4
{
    class Program
    {




        /*enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        };
        */

       // static void Main(string[] args)
        //{
            //1
            //Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
            //Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.

            /*  

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



           static string GetFullName(string FirstName, string LastName, string Patronymic)
           {
               string UserName = FirstName + " " + LastName + " " + Patronymic;
               return UserName;
           }
            */


            // Способ номер 2
            /*

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Какая у тебя фамилия?");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Какое имя.");
                string LastName = Console.ReadLine();
                Console.WriteLine("Напиши отчество.");
                string Patronymic = Console.ReadLine();
                GetFullName(FirstName, LastName, Patronymic);


            }


            static void GetFullName(string FirstName, string LastName, string Patronymic)
            {
                Console.WriteLine($" { FirstName }  { LastName}  { Patronymic}  ");

            }*/



            //НОМЕР 2
            /*
            {
                Console.WriteLine("Введи числа через пробел.");
                string value = Console.ReadLine();
                int SumOfValue = GetSum(value);
                Console.WriteLine(SumOfValue);
                Console.ReadLine();
            }



            static int GetSum(string value)
            {
                string[] array = value.Split(' ');// пробел как разделитель
                int SumOfValue = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    string arrayvalue = array[i];
                    int quantityvalue01 = int.TryParse(arrayvalue, out int num)
                        ? num //тут я нашла решение в отрытых источниках, но я не поняла что это и зачем здесь. На уроках мы не проходили. Можно ли как то прописать это проще?
                        : 0; // можно ли  заменить строчки 104 и 105 чем  то  более простоым и понятным для новичков?
            
            SumOfValue = SumOfValue + quantityvalue01;
                }
                return SumOfValue;


            }
            */

            //НОМЕР 3
            //Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
            //На выходе — значение из перечисления(enum) — Winter, Spring, Summer, Autumn.
            //Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, лето, осень).
            //Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
            //Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».

          
            enum Year
        {
            Winter,
            Spring,
            Summer,
            Autumn
        };

        static void Main(string[] args)
        {

            Console.WriteLine("Введи число месяца года от 1 до 12");

            string value = Console.ReadLine();

            GetMonhts(value);


            static string GetMonhts(string  a)
            {
                int x = Convert.ToInt32(a);
                if (x > 12 || x < 1)
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12.");
                    return;
                }
                else
                {
                    switch (x)
                    {
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine(Year.Winter);
                            return;
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine(Year.Spring);
                            return;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine(Year.Summer);
                            return;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine(Year.Autumn);
                            return;

                    }
                }
            } // Возникает ошибка "Требуется объект с типом, приводимый к "string". Не знаю как убрать.
        }




            //НОМЕР 4























        

    }
}

  

            
            



           
