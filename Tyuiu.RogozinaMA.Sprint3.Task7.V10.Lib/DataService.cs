using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RogozinaMA.Sprint3.Task7.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Вычисляем размер массива
            int size = Math.Abs(stopValue - startValue) + 1;
            double[] result = new double[size];

            int index = 0;

            // Табулируем функцию от startValue до stopValue
            for (int x = startValue; x <= stopValue; x++)
            {
                // Вычисляем значение функции: F(x) = (5x + 2.5)/(sin(x) + 3) + 2x + cos(x)

                // Проверяем знаменатель на ноль
                double denominator = Math.Sin(x) + 3;

                if (Math.Abs(denominator) < 0.0001) // если знаменатель близок к 0
                {
                    result[index] = 0; // по условию возвращаем 0
                }
                else
                {
                    double numerator = 5 * x + 2.5;
                    double fraction = numerator / denominator;
                    double value = fraction + 2 * x + Math.Cos(x);

                    // Округляем до 2 знаков после запятой
                    result[index] = Math.Round(value, 2);
                }

                index++;
            }

            return result;
        }
    }
}