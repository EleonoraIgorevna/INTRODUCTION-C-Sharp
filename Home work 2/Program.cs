using System;

namespace Home_work_2
{
    class Program
    {
        static void Main(string[] args)
        {/*
            //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

            Console.WriteLine("Введите  максимальную температуру.");
            double tempMax = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите минимальную температуру.");
            double tempMin = double.Parse(Console.ReadLine());
            double Average = (tempMax + tempMin) / 2;
            Console.WriteLine($"Средняя температура: {Average} градусов. ");



            //Запросить у пользователя порядковый номер текущего месяца и вывести его название.

            Console.WriteLine("Введите  номер месяца от 1 до 12.");
            int mounth = int.Parse(Console.ReadLine());

            switch (mounth)
            {
                case 1:
                    Console.WriteLine("Январь.");
                    break;
                case 2:
                    Console.WriteLine("Февраль.");
                    break;
                case 3:
                    Console.WriteLine("Март.");
                    break;
                case 4:
                    Console.WriteLine("Апрель.");
                    break;
                case 5:
                    Console.WriteLine("Май.");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль.");
                    break;
                case 8:
                    Console.WriteLine("Август.");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь.");
                    break;
                case 10:
                    Console.WriteLine("Октябрь.");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь.");
                    break;
                case 12:
                    Console.WriteLine("Декабрь.");
                    break;
                default:
                    Console.WriteLine("Введите число от 1 до 12.");
                    break;
            }




            //Определить, является ли введённое пользователем число чётным.

            Console.WriteLine("Введите число.");
            double value;
            value = double.Parse(Console.ReadLine());
            double result = value % 2;
            switch (result)
            {
                case 0:
                    Console.WriteLine("Число  четное.");
                    break;
                default:
                    Console.WriteLine("Число не четное.");
                    break;
            }

            //Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, 
            //только за место динамических, по вашему мнению, данных(это может быть дата, название магазина, сумма покупок) подставляйте переменные,
            //которые были заранее заготовлены до вывода на консоль.

            double Count = 500.34;
            int quantity = 1;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" ________________________________________");
            Console.WriteLine("|              OOO'Ромашка'              |");
            Console.WriteLine("|             ИНН:  45632455             |");
            Console.WriteLine("|  Россия, г.Москва, ул. Профсоюзная 42  |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|          КАССОВЫЙ ЧЕК/ПРИХОД           |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("| Доставка цветов                 " + quantity + " шт   |");
            Console.WriteLine("| Услуга   " + Count + "                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                      " + DateTime.Now + "|");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Co45nsole.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|               @}-->--                  |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|_________СПАСИБО ЗА ПОКУПКУ!____________|");



            */
            /*
            //Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».*/

            Console.WriteLine("Введите  номер месяца от 1 до 12.");
            int mounth1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите среднюю температуру.");
            int temp = int.Parse(Console.ReadLine());


            switch (mounth1)
                {
                    case 12:
                    case 1:
                    case 2:
                     if (temp > 0)
                        {
                        Console.WriteLine("Дождливая зима.");
                        return;
                    }
                    else
                        Console.WriteLine("Это зимний месяц.");
                    break;
                    case 3:
                    case 4:

                    case 5:
                        Console.WriteLine("Весна.");
                        break;
                    case 6:

                    case 7:

                    case 8:
                        Console.WriteLine("Лето.");
                        break;
                    case 9:

                    case 10:

                    case 11:
                        Console.WriteLine("Осень.");
                        break;

                    default:
                        Console.WriteLine("Введите число месяца  от 1 до 12.");
                        break;
                }
        }
    }
}
