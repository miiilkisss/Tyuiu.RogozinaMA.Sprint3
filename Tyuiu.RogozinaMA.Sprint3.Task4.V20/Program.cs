using System;
using Tyuiu.RogozinaMA.Sprint3.Task4.V20.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task4.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Рогозина М.А. | ИСПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:Использование операторов continue и break в циклах                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Рогозина Милана Андреевна | ИСПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение    *");
            Console.WriteLine("* функции y = x/(cos(x) - x) + 2,5                                       *");
            Console.WriteLine("* При х = 0 пропустить значение. Полученные значения перемножать.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Стартовое значение x = {startValue}");
            Console.WriteLine($"Конечное значение x = {stopValue}");
            Console.WriteLine($"Функция: y = x/(cos(x) - x) + 2,5");
            Console.WriteLine($"При x = 0 значение пропускается");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(startValue, stopValue);
            Console.WriteLine($"Произведение значений функции = {result}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}