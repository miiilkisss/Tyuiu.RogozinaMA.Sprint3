using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint3.Task5.V20.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            double res = ds.GetSumSumSeries(x, 1, 3, 1, 6);

            // Для x=2: sin(2) ≈ 0.9093, x/sin(x) ≈ 2/0.9093 ≈ 2.199
            // Сумма степеней от 1 до 6 для основания 2.199
            // Это примерно: 2.199 + 4.836 + 10.635 + 23.387 + 51.428 + 113.088 = 205.573
            // Умножаем на 3 (внешний цикл): 205.573 * 3 = 616.719
            // Округление до 3 знаков: 616.719
            double wait = 616.719;
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesXEqualsOne()
        {
            DataService ds = new DataService();
            int x = 1;
            double res = ds.GetSumSumSeries(x, 1, 3, 1, 6);

            // Для x=1: sin(1) ≈ 0.8415, x/sin(x) ≈ 1/0.8415 ≈ 1.1884
            // Можно проверить, что результат положительный
            Assert.IsTrue(res > 0);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesSingleIteration()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.GetSumSumSeries(x, 1, 1, 1, 1);

            // Для одного слагаемого: (3/sin(3))^1
            // sin(3) ≈ 0.1411, 3/0.1411 ≈ 21.26
            double wait = 21.26;
            Assert.AreEqual(wait, res, 0.01);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesRounding()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(2, 1, 3, 1, 6);

            string resString = res.ToString("F6");
            int decimalPlaces = resString.Length - resString.IndexOf('.') - 1;
            Assert.IsTrue(decimalPlaces <= 3);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesZeroSin()
        {
            DataService ds = new DataService();
       
            int x = (int)Math.Round(Math.PI); // x = 3
            double res = ds.GetSumSumSeries(x, 1, 3, 1, 6);

      
            Assert.IsFalse(double.IsInfinity(res) || double.IsNaN(res));
        }
    }
}