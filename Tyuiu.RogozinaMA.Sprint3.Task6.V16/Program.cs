using System;
using Tyuiu.RogozinaMA.Sprint3.Task6.V16.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Рогозина М.А. | ИСПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Рогозина Милана Андреевна | ИСПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                    *");
            Console.WriteLine("* принадлежащих числовому отрезку [5, 16] количество всех делителей      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 5;
            int stopValue = 16;

            Console.WriteLine($"Начало диапазона: {startValue}");
            Console.WriteLine($"Конец диапазона: {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetSumTheDivisors(startValue, stopValue);
            Console.WriteLine($"Общее количество делителей всех чисел в диапазоне [{startValue}, {stopValue}] = {result}");

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* ПОДРОБНЫЙ РАСЧЕТ:                                                       *");
            Console.WriteLine("***************************************************************************");

         
            int checkTotal = 0;
            for (int num = startValue; num <= stopValue; num++)
            {
                int count = 0;
                string divisors = "";
                for (int d = 1; d <= num; d++)
                {
                    if (num % d == 0)
                    {
                        count++;
                        divisors += d + " ";
                    }
                }
                Console.WriteLine($"Число {num,2}: {count,2} делителей ({divisors.Trim()})");
                checkTotal += count;
            }
            Console.WriteLine($"Итого: {checkTotal} делителей");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
} 