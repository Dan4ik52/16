using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Вывести в строку десять заглавных букв "а" через один пробел:
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.Write("А ");
            }
            */

            //2.Вывести в обратном порядке числа от 50 до 40.
            /*
            for(int i = 50; i >= 40; i--) 
            { 
                Console.WriteLine(i);
            }
            */

            // 3.Вывести в строку через пробел следующие натуральные числа: 6    12     24      30      36
            /*
            for (int i = 6; i <= 36; i += 6)
                if (i != 18)
                {
                    Console.Write($"{i} ");
            }       
            */

            // 4.Вывести двузначные числа, кратные 11, подсчитать их количество и сумму.
            /*
            int summa = 0;
            int quantity = 0;
            for (int i = 10; i <= 99; i++)
                if (i % 11 == 0)
                {
                    Console.WriteLine(i);                 
                    quantity++;
                    summa += i;
                }
            Console.WriteLine($"Кол-во = {quantity}\nСумма = {summa}");
            */

            // 5 *.Вывести и посчитать количество трехзначных чисел, сумма цифр которых равна 20.

            /*
            int quantity = 0;
            for (int i = 100; i < 1000; i++)
            {
                int number1 = i / 100;
                int number2 = (i % 100) / 10;
                int number3 = i % 10;

                if (number1 + number2 + number3 == 20)
                {
                    Console.WriteLine(i);
                    quantity++;
                }
            }
            Console.WriteLine($"Всего их: {quantity}");
            */

            //  6 *.За каждый месяц банк начисляет к сумме вклада 7 % от суммы.Напишите консольную программу,
            //     в которую пользователь вводит сумму вклада и количество месяцев.А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
            /*
            Console.Write("Введите сумму вклада: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во месяцев: ");
            int month = int.Parse(Console.ReadLine());
            double sum = price;
            double contr = 0.07;

            for (int i = 0; i < month; i++)
            {
                sum = sum + sum * contr;
            }
            Console.WriteLine($"Конечная сумма:{sum:f2}");
            */
            Console.ReadKey();
        }
    }
}
