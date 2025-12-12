using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RogozinaMA.Sprint3.Task4.V20.Lib
{
    public class DataService: ISprint3Task4V20
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1.0;

           
            for (int x = startValue; x <= stopValue; x++)
            {
                
                if (x == 0)
                {
                    continue; // пропускаем x = 0
                }

                // Вычисляем значение функции y = x/(cos(x) - x) + 2.5
                double denominator = Math.Cos(x) - x;

               
                if (Math.Abs(denominator) < 0.0001)
                {
                    continue; 
                }

                double y = x / denominator + 2.5;
                product *= y;
            }

            return Math.Round(product, 3);
        }
    }
}