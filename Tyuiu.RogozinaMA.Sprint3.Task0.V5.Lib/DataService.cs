using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RogozinaMA.Sprint3.Task0.V5.Lib
{
    public class DataService : ISprint3Task0V5
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                double term = Math.Pow(1.0 / Math.Sin(k), 2);
                sum += term;
            }
            return Math.Round(sum, 3);
        }
    }
}