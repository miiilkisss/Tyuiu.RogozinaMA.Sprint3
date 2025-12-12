using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint3.Task3.V19.Lib;

namespace Tyuiu.RogozinaMA.Sprint3.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();
            string result = ds.ReplaceCharOnNum("sxxrrg x vfrx", 'x', '2');
            string wait = "s22rrg 2 vfr2";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidReplaceCharOnNumDifferentChars()
        {
            DataService ds = new DataService();
            string result = ds.ReplaceCharOnNum("hello world", 'o', '0');
            string wait = "hell0 w0rld";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidReplaceCharOnNumEmptyString()
        {
            DataService ds = new DataService();
            string result = ds.ReplaceCharOnNum("", 'x', '2');
            string wait = "";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidReplaceCharOnNumNoMatches()
        {
            DataService ds = new DataService();
            string result = ds.ReplaceCharOnNum("abcdef", 'x', '2');
            string wait = "abcdef";
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidReplaceCharOnNumAllMatches()
        {
            DataService ds = new DataService();
            string result = ds.ReplaceCharOnNum("xxxx", 'x', '2');
            string wait = "2222";
            Assert.AreEqual(wait, result);
        }
    }
}