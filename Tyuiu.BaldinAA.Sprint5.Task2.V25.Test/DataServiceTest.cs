using System.IO;
using Tyuiu.BaldinAA.Sprint5.Task2.V25.Lib;
namespace Tyuiu.BaldinAA.Sprint5.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Artyom\source\repos\Tyuiu.BaldinAA.Sprint5\Tyuiu.BaldinAA.Sprint5.Task2.V25\bin\Debug\net8.0\OutPutFileTask2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}