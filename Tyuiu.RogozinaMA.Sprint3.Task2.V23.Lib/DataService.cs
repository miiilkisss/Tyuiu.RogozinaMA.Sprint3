using System;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.RogozinaMA.Sprint3.Task2.V23.Lib
{
    public class DataService: ISprint3Task2V23
    {
        public double GetSumSeries(double a, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int k = startValue;

            // Цикл do...while
            do
            {
                // Формула: (a^k + 1/4) * sin(k)
                double term = (Math.Pow(a, k) + 0.25) * Math.Sin(k);
                sumSeries += term;
                k++;
            }
            while (k <= stopValue);

            return Math.Round(sumSeries, 3);
        }
    }
}