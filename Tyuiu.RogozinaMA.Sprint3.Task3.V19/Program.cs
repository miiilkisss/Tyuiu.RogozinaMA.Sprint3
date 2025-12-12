using System;
using Tyuiu.RogozinaMA.Sprint3.Task3.V19.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Рогозина М.А. | ИСПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Рогозина Милана Андреевна | ИСПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы x на цифру 2 в строке:           *");
            Console.WriteLine("* sxxrrg x vfrx                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string inputString = "sxxrrg x vfrx";
            char replaceableChar = 'x';
            char replacementChar = '2';

            Console.WriteLine($"Исходная строка: {inputString}");
            Console.WriteLine($"Заменяемый символ: '{replaceableChar}'");
            Console.WriteLine($"Символ для замены: '{replacementChar}'");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.ReplaceCharOnNum(inputString, replaceableChar, replacementChar);
            Console.WriteLine($"Результат: {result}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}