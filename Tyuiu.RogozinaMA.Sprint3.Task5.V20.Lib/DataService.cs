using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RogozinaMA.Sprint3.Task5.V20.Lib
{
    public class DataService : ISprint3Task5V20
    {
        public double GetSumSumSeries(int x, int startValue1, int stopValue1, int startValue2, int stopValue2)
        {
            double totalSum = 0;

           
            for (int i = startValue1; i <= stopValue1; i++)
            {
         
                for (int k = startValue2; k <= stopValue2; k++)
                {
                   
                    double sinX = Math.Sin(x);
)
                    if (Math.Abs(sinX) < 0.0000001)
                    {
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