using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RogozinaMA.Sprint3.Task6.V16.Lib
{
    public class DataService : ISprint3Task6V16
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalDivisors = 0;

            // Перебираем все числа в заданном диапазоне
            for (int num = startValue; num <= stopValue; num++)
            {
                // Для каждого числа подсчитываем количество делителей
                int divisorsCount = 0;

                // Делители от 1 до самого числа
                for (int divisor = 1; divisor <= num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        divisorsCount++;
                    }
                }

                totalDivisors += divisorsCount;


            }

            return totalDivisors;
        }
    }
}