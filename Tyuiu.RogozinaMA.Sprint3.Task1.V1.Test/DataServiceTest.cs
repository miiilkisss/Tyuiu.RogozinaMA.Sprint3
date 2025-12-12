using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint3.Task1.V1.Lib;
 
namespace Tyuiu.RogozinaMA.Sprint3.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiply()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiply();
            double wait = 0.007;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetMultiplyRange()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiply();

            Assert.IsTrue(res > 0 && res < 1);
        }

        [TestMethod]
        public void ValidGetMultiplyPrecision()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiply();

        
            Assert.IsTrue(res < 0.01);
        }

        [TestMethod]
        public void ValidGetMultiplyRounding()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiply();

            string resString = res.ToString("F6");
            int decimalPlaces = resString.Length - resString.IndexOf('.') - 1;
            Assert.IsTrue(decimalPlaces <= 3);
        }
    }
}