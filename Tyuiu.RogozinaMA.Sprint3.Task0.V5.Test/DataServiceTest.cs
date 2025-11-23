using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint3.Task0.V5.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 36.488;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetSumSeriesPartialRange()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 5;
            double res = ds.GetSumSeries(startValue, stopValue);
            // Проверяем что результат округлен до 3 знаков
            Assert.AreEqual(3, res.ToString().Split('.')[1].Length);
        }

        [TestMethod]
        public void ValidGetSumSeriesSingleTerm()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 1;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 1.188; // (1/sin(1))² ≈ (1/0.84147)² ≈ (1.1884)² ≈ 1.412
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetSumSeriesRounding()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 3;
            double res = ds.GetSumSeries(startValue, stopValue);
            string resString = res.ToString("F6");
            int decimalPlaces = resString.Length - resString.IndexOf('.') - 1;
            Assert.IsTrue(decimalPlaces <= 3);
        }
    }
}