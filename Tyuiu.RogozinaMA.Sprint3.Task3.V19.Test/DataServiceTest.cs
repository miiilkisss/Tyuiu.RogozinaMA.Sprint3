using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint3.Task3.V19.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceXOnTwo()
        {
            DataService ds = new DataService();
            string input = "sxxrrg x vfrx";
            string result = ds.ReplaceXOnTwo(input);
            string wait = "s22rrg 2 vfr2";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidReplaceXOnTwoEmptyString()
        {
            DataService ds = new DataService();
            string input = "";
            string result = ds.ReplaceXOnTwo(input);
            string wait = "";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidReplaceXOnTwoNoX()
        {
            DataService ds = new DataService();
            string input = "abcdefg";
            string result = ds.ReplaceXOnTwo(input);
            string wait = "abcdefg";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidReplaceXOnTwoOnlyX()
        {
            DataService ds = new DataService();
            string input = "xxxx";
            string result = ds.ReplaceXOnTwo(input);
            string wait = "2222";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidReplaceXOnTwoMixedCase()
        {
            DataService ds = new DataService();
            string input = "xXxX"; // Большие X не должны заменяться
            string result = ds.ReplaceXOnTwo(input);
            string wait = "2X2X"; // Только маленькие 'x' заменяются на '2'
            Assert.AreEqual(wait, result);
        }
    }
}