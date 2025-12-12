using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint3.Task2.V23.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double a = 1.5;
            int startValue = 1;
            int stopValue = 13;
            double res = ds.GetSumSeries(a, startValue, stopValue);

            double wait = 193.317;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetSumSeriesPartialRange()
        {
            DataService ds = new DataService();
            double a = 1.5;
            int startValue = 1;
            int stopValue = 5;
            double res = ds.GetSumSeries(a, startValue, stopValue);

            
            string[] parts = res.ToString().Split('.');
            if (parts.Length > 1)
            {
                Assert.AreEqual(3, parts[1].Length);
            }
        }

        [TestMethod]
        public void ValidGetSumSeriesSingleTerm()
        {
            DataService ds = new DataService();
            double a = 1.5;
            int startValue = 1;
            int stopValue = 1;
            double res = ds.GetSumSeries(a, startValue, stopValue);

            // Для k=1: (1.5^1 + 0.25) * sin(1) = (1.5 + 0.25) * 0.84147 = 1.75 * 0.84147 ≈ 1.4726
            double wait = 1.473; // Округлено до 3 знаков
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetSumSeriesRounding()
        {
            DataService ds = new DataService();
            double a = 1.5;
            int startValue = 1;
            int stopValue = 3;
            double res = ds.GetSumSeries(a, startValue, stopValue);

           
            string resString = res.ToString("F6");
            int decimalPlaces = resString.Length - resString.IndexOf('.') - 1;
            Assert.IsTrue(decimalPlaces <= 3);
        }
    }
}