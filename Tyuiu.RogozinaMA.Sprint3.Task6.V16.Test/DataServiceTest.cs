using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint3.Task6.V16.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(5, 16);

            // 5: 2 делителя (1,5)
            // 6: 4 делителя (1,2,3,6)
            // 7: 2 делителя (1,7)
            // 8: 4 делителя (1,2,4,8)
            // 9: 3 делителя (1,3,9)
            // 10: 4 делителя (1,2,5,10)
            // 11: 2 делителя (1,11)
            // 12: 6 делителей (1,2,3,4,6,12)
            // 13: 2 делителя (1,13)
            // 14: 4 делителя (1,2,7,14)
            // 15: 4 делителя (1,3,5,15)
            // 16: 5 делителей (1,2,4,8,16)
            // Сумма: 2+4+2+4+3+4+2+6+2+4+4+5 = 42

            int wait = 42;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsSingleNumber()
        {
            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(5, 5);

            // Для числа 5: делители 1 и 5 = 2 делителя
            int wait = 2;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsSmallRange()
        {
            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(1, 3);

            // 1: 1 делитель
            // 2: 2 делителя
            // 3: 2 делителя
            // Итого: 5
            int wait = 5;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsPrimeNumbers()
        {
            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(11, 13);

            // 11: 2 делителя
            // 12: 6 делителей
            // 13: 2 делителя
            // Итого: 10
            int wait = 10;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsSameStartStop()
        {
            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(12, 12);

            // 12: 6 делителей (1,2,3,4,6,12)
            int wait = 6;
            Assert.AreEqual(wait, result);
        }
    }
} 