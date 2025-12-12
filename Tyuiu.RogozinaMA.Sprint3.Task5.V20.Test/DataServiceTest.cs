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

            // x=5, i=1..3, k=1..6
            double res = ds.GetSumSumSeries(5, 1, 1, 3, 6);

            double wait = 50584.322;
            Assert.AreEqual(wait, res, 0.001); 
        }

        [TestMethod]
        public void ValidGetSumSumSeriesDifferentX()
        {
            DataService ds = new DataService();

          
            double res = ds.GetSumSumSeries(2, 1, 1, 3, 6);

            Assert.IsFalse(double.IsNaN(res) || double.IsInfinity(res));
        }

        [TestMethod]
        public void ValidGetSumSumSeriesSingleIteration()
        {
            DataService ds = new DataService();

          
            double res = ds.GetSumSumSeries(5, 1, 1, 1, 1);

            // (5/sin(5))^1 = 5/(-0.958924) ≈ -5.214
            double wait = -5.214;
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesAllParameters()
        {
            DataService ds = new DataService();

           
            int x = 5;
            int startValue1 = 1;  // начало i
            int startValue2 = 1;  // начало k
            int stopValue1 = 3;   // конец i
            int stopValue2 = 6;   // конец k

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = 50584.322;
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesParametersOrder()
        {
            DataService ds = new DataService();

           

            double res1 = ds.GetSumSumSeries(5, 1, 1, 3, 6);  // i=1..3, k=1..6
            double res2 = ds.GetSumSumSeries(5, 1, 1, 1, 6);  // i=1..1, k=1..6

     
            Assert.AreEqual(res1 / 3, res2, 0.001);
        }
    }
}