using System;
using Tyuiu.RogozinaMA.Sprint3.Task7.V10.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task7.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Рогозина М.А. | ИСПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Рогозина Милана Андреевна | ИСПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:          *");
            Console.WriteLine("* F(x) = (5x + 2.5)/(sin(x) + 3) + 2x + cos(x)                           *");
            Console.WriteLine("* на диапазоне [-5; 5] с шагом 1.                                        *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.    *");
            Console.WriteLine("* Значения занести в массив и округлить до двух знаков после запятой.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Стартовое значение x = {startValue}");
            Console.WriteLine($"Конечное значение x = {stopValue}");
            Console.WriteLine($"Функция: F(x) = (5x + 2.5)/(sin(x) + 3) + 2x + cos(x)");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    x     |   F(x)    |");
            Console.WriteLine("+----------+-----------+");

            double[] resultArray = ds.GetMassFunction(startValue, stopValue);

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double value = resultArray[index];
                Console.WriteLine($"| {x,5}    | {value,8:F2} |");
                index++;
            }

            Console.WriteLine("+----------+-----------+");

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* Массив значений:                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.Write("[ ");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write($"{resultArray[i]:F2}");
                if (i < resultArray.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(" ]");

            Console.WriteLine("\n***************************************************************************");
            Console.ReadKey();
        }
    }
}