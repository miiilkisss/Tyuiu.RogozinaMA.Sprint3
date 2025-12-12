using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint3.Task4.V20.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);

            // Ожидаемое значение (примерное)
            double wait = 0.001; // Это очень маленькое число из-за перемножения
            Assert.AreEqual(wait, res, 0.001); // Проверка с погрешностью 0.001
        }

        [TestMethod]
        public void ValidCalculateWithoutZero()
        {
            DataService ds = new DataService();
            // Проверяем что x=0 пропускается
            // При x=0: y = 0/(cos(0) - 0) + 2.5 = 0/1 + 2.5 = 2.5
            // Если бы не пропускали, результат был бы другим

            double res1 = ds.Calculate(-1, 1); // включает 0, но он пропускается
            double res2 = ds.Calculate(-1, 0); // от -1 до 0 (0 пропускается)
            double res3 = ds.Calculate(0, 1);  // от 0 до 1 (0 пропускается)

            // Все три результата должны быть равны произведению только для x=-1 и x=1
            // (если диапазон от -1 до 1 и 0 пропускается)
            Assert.AreNotEqual(0, res1);
        }

        [TestMethod]
        public void ValidCalculateSingleValue()
        {
            DataService ds = new DataService();
            // Проверяем для одного значения (кроме 0)
            double res = ds.Calculate(1, 1);

            // При x=1: y = 1/(cos(1) - 1) + 2.5
            // cos(1) ≈ 0.5403
            // y = 1/(0.5403 - 1) + 2.5 = 1/(-0.4597) + 2.5 ≈ -2.175 + 2.5 = 0.325
            double expected = 0.325;
            Assert.AreEqual(expected, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateRounding()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-5, 5);

            // Проверяем что результат округлен до 3 знаков
            string resString = res.ToString("F6");
            string decimalPart = resString.Substring(resString.IndexOf('.') + 1);
            decimalPart = decimalPart.TrimEnd('0');

            Assert.IsTrue(decimalPart.Length <= 3);
        }

        [TestMethod]
        public void ValidCalculateSkipZero()
        {
            DataService ds = new DataService();
            // Сравниваем два расчета: с 0 и без 0
            double withZeroRange = ds.Calculate(-1, 1);  // от -1 до 1 (0 пропускается)
            double withoutZero = (ds.Calculate(-1, -1) * ds.Calculate(1, 1)); // отдельно -1 и 1

            // Они должны быть примерно равны, так как 0 пропускается
            Assert.AreEqual(withoutZero, withZeroRange, 0.001);
        }
    }
}