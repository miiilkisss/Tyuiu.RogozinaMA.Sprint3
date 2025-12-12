using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint3.Task7.V10.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            // Проверяем размер массива
            Assert.AreEqual(11, result.Length); // от -5 до 5 включительно = 11 значений

            // Проверяем несколько значений
            // При x = -5
            // sin(-5) ≈ 0.9589, sin(-5)+3 ≈ 3.9589
            // 5*(-5) + 2.5 = -25 + 2.5 = -22.5
            // -22.5 / 3.9589 ≈ -5.68
            // 2*(-5) = -10
            // cos(-5) ≈ 0.2837
            // Итого: -5.68 - 10 + 0.2837 ≈ -15.40
            Assert.AreEqual(-15.40, result[0], 0.01);

            // Проверяем округление до 2 знаков
            string valueStr = result[0].ToString("F3");
            Assert.AreEqual(2, valueStr.Split('.')[1].Length);
        }

        [TestMethod]
        public void ValidGetMassFunctionSingleValue()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(0, 0);

            Assert.AreEqual(1, result.Length);

            // При x = 0:
            // sin(0) = 0, sin(0)+3 = 3
            // 5*0 + 2.5 = 2.5
            // 2.5 / 3 = 0.8333
            // 2*0 = 0
            // cos(0) = 1
            // Итого: 0.8333 + 0 + 1 = 1.8333 → 1.83
            Assert.AreEqual(1.83, result[0], 0.01);
        }

        [TestMethod]
        public void ValidGetMassFunctionNoDivisionByZero()
        {
            DataService ds = new DataService();

           

            double[] result = ds.GetMassFunction(-5, 5);

           
            foreach (double value in result)
            {
                Assert.IsFalse(double.IsNaN(value));
                Assert.IsFalse(double.IsInfinity(value));
            }
        }

        [TestMethod]
        public void ValidGetMassFunctionRange()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-2, 2);

            
            Assert.AreEqual(5, result.Length);

         
            Assert.AreNotEqual(0, result[0]); 
            Assert.AreNotEqual(0, result[4]); 
        }

        [TestMethod]
        public void ValidGetMassFunctionRounding()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(1, 1);

           
            double value = result[0];
            string strValue = value.ToString("F10");
            string decimalPart = strValue.Substring(strValue.IndexOf('.') + 1, 2);
            string beyondDecimal = strValue.Substring(strValue.IndexOf('.') + 3);

            Assert.IsTrue(beyondDecimal.Trim('0') == "");
        }
    }
}