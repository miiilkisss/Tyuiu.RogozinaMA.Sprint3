using System;
using Tyuiu.RogozinaMA.Sprint3.Task5.V20.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task5.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Рогозина М.А. | ИСПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Рогозина Милана Андреевна | ИСПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить двойную сумму по формуле:                                     *");
            Console.WriteLine("*      3     6                                                            *");
            Console.WriteLine("* y = ∑   ∑   (x/sin(x))^k                                                *");
            Console.WriteLine("*     i=1  k=1                                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;  
            int stopValue1 = 3;   
            int startValue2 = 1;  
            int stopValue2 = 6;   

            Console.WriteLine($"Значение x = {x}");
            Console.WriteLine($"Внешний цикл: от i = {startValue1} до {stopValue1}");
            Console.WriteLine($"Внутренний цикл: от k = {startValue2} до {stopValue2}");
            Console.WriteLine($"Формула: y = ∑[i=1..3] ∑[k=1..6] (x/sin(x))^k");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine($"Результат y = {result}");

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* ПРОВЕРКА ОЖИДАЕМОГО РЕЗУЛЬТАТА:                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Ожидаемый результат: 50584.322");
            Console.WriteLine($"Разница: {Math.Abs(result - 50584.322):F6}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}