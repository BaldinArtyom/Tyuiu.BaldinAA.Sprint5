using System.IO;
using Tyuiu.BaldinAA.Sprint5.Task0.V20.Lib;
namespace Tyuiu.BaldinAA.Sprint5.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            string path = @"C:\Users\Artyom\source\repos\Tyuiu.BaldinAA.Sprint5\Tyuiu.BaldinAA.Sprint5.Task0.V5\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}