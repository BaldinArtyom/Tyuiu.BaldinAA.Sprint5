using System.IO;
using Tyuiu.BaldinAA.Sprint5.Task3.V11.Lib;
namespace Tyuiu.BaldinAA.Sprint5.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\Users\Artyom\source\repos\Tyuiu.BaldinAA.Sprint5\Tyuiu.BaldinAA.Sprint5.Task3.V11\bin\Debug\net8.0\OutPutFileTask3.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsist);
        }
    }
}