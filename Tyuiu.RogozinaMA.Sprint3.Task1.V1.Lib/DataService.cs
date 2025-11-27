using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RogozinaMA.Sprint3.Task1.V1.Lib
{
    public class DataService: ISprint3Task1V1
    {
            public double GetMultiply()
            {
                double product = 1.0;
                int k = 1;

                while (k <= 7)
                {
                    double term = Math.Pow(3.0 / k, -2);
                    product *= term;
                    k++;
                }

                return Math.Round(product, 3);
            }
        }
    }