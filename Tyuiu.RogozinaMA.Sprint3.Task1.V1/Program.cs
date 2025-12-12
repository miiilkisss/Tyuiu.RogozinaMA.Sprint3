using System;
using Tyuiu.RogozinaMA.Sprint3.Task1.V1.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task1.V1
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Рогозина М.А. | ИСПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Рогозина Милана Андреевна | ИСПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
            Console.WriteLine("* ряда по формуле:                                                        *");
            Console.WriteLine("*       7                                                                 *");
            Console.WriteLine("* p = ∏ (3/k)^(-2)                                                        *");
            Console.WriteLine("*      k=1                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Формула: p = ∏[k=1 to 7] (3/k)^(-2)");
            Console.WriteLine("Диапазон: k = 1 до 7");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiply();
            Console.WriteLine($"Произведение ряда = {result}");

            Console.ReadLine();
        }
    }
}