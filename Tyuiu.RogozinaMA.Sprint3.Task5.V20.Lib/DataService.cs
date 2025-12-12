using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RogozinaMA.Sprint3.Task5.V20.Lib
{
    public class DataService : ISprint3Task5V20
    {
        public double GetSumSumSeries(int x, int startValue1, int stopValue1, int startValue2, int stopValue2)
        {
            double totalSum = 0;

            // Внешний цикл по i
            for (int i = startValue1; i <= stopValue1; i++)
            {
                // Внутренний цикл по k
                for (int k = startValue2; k <= stopValue2; k++)
                {


                    // Из формулы: (x/sin(x))^k
                    double sinX = Math.Sin(x);

                    // Проверяем, чтобы sin(x) не был равен 0 (во избежание деления на 0)
                    if (Math.Abs(sinX) < 0.0000001)
                    {
                        // Если sin(x) очень близок к 0, пропускаем это слагаемое
                        continue;
                    }

                    double baseValue = x / sinX;        // x/sin(x)
                    double term = Math.Pow(baseValue, k); // (x/sin(x))^k
                    totalSum += term;
                }
            }

            return Math.Round(totalSum, 3);
        }
    }
}