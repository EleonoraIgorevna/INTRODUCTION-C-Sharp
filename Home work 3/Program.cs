using System;

namespace Home_work_3
{
    class Program
    {
        static void Main(string[] args)
        {


            // 1 . Написать программу, выводящую элементы двухмерного массива по диагонали.
            /*
            int[,] array = new int[5, 5];
            array[0, 0] = 1;
            array[1, 1] = 1;
            array[2, 2] = 1;
            array[3, 3] = 1;
            array[4, 4] = 1;
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            //2.Написать программу — телефонный справочник — создать двумерный массив 5 * 2, хранящий список телефонных контактов: первый элемент хранит имя контакта,
				// второй — номер телефона/ e - mail.
            string[,] myphonebook = new string[,]
            {
                {"Griboedov", "+79158622325, Griboedov@mail.ru"},
                {"Pushkin", "+79158622765, Pushkin@mail.ru"},
                {"Tolstoi", "+79708622775, Tolstoi@mail.ru"},
                {"Goncharov", "+79998622377, Goncharov@mail.ru"},
                {"Ostrovskii", "+79778622111, Ostrovskii@mail.ru"}
            };
            for (int i = 0; i < myphonebook.GetLength(0); i++)
            {
                for (int j = 0; j < myphonebook.GetLength(1); j++)
                {
                   
                    Console.Write($"{myphonebook[i, j]} ");
                }
                System.Console.WriteLine();
            }
            
            //3. Написать программу, выводящую введененную пользователем строку в обратном порядке. Hello
            char[] hello = { 'h', 'e', 'l', 'l', 'o' };
            for (int x = hello.Length -1; x >=0; x--) 
            {
                
                   Console.Write($"{hello[x]}");
                
            }*/

            // 4 . Морской бой.


            char[,] array = new char[10, 10];

            array[0, 0] = '0';
            array[0, 1] = '1';
            array[0, 2] = '2';
            array[0, 3] = '3';
            array[0, 4] = '4';
            array[0, 5] = '5';
            array[0, 6] = '6';
            array[0, 7] = '7';
            array[0, 8] = '8';
            array[0, 9] = '9';

            array[1, 0] = '1';
            array[2, 0] = '2';
            array[3, 0] = '3';
            array[4, 0] = '4';
            array[5, 0] = '5';
            array[6, 0] = '6';
            array[7, 0] = '7';
            array[8, 0] = '8';
            array[9, 0] = '9';

            array[4, 4] = 'Х'; //корабль 1
            array[5, 4] = 'Х';
            array[6, 4] = 'Х';
            array[7, 4] = 'Х';
            array[7, 8] = 'Х'; //корабль 2
            array[8, 8] = 'Х';


            //не знаю, как пустые клетки отметить нулем ((

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();



            }


        }
    }
}