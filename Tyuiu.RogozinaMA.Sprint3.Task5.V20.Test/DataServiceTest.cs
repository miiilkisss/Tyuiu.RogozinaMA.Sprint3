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
            int x = 5; 
            double res = ds.GetSumSumSeries(x, 1, 3, 1, 6);

            double wait = 50584.322;
            Assert.AreEqual(wait, res, 0.001); 
        }

        [TestMethod]
        public void ValidGetSumSumSeriesXEqualsTwo()
        {
            DataService ds = new DataService();
            int x = 2;
            double res = ds.GetSumSumSeries(x, 1, 3, 1, 6);

            Assert.IsTrue(res > 0 && res < 1000000);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesSingleK()
        {
            DataService ds = new DataService();
            int x = 5;
 
            double res = ds.GetSumSumSeries(x, 1, 3, 1, 1);

            // Для x=5: sin(5) ≈ -0.9589, x/sin(x) ≈ -5.214
            // 3 * (-5.214) ≈ -15.642
            double wait = -15.642;
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesSingleI()
        {
            DataService ds = new DataService();
            int x = 5;
    
            double res = ds.GetSumSumSeries(x, 1, 1, 1, 6);

          
            double wait = 16861.441;
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesRounding()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(5, 1, 3, 1, 6);

            // Проверяем округление до 3 знаков
            string resString = res.ToString("F6");
            string decimalPart = resString.Substring(resString.IndexOf('.') + 1);
            decimalPart = decimalPart.TrimEnd('0');

            Assert.IsTrue(decimalPart.Length <= 3, $"Длина дробной части: {decimalPart.Length}");
        }
    }
}