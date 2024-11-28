using System.IO;
using Tyuiu.BaldinAA.Sprint5.Task1.V14.Lib;
namespace Tyuiu.BaldinAA.Sprint5.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Path = @"C:\Users\Artyom\source\repos\Tyuiu.BaldinAA.Sprint5\Tyuiu.BaldinAA.Sprint5.Task1.V14\bin\Debug\net8.0\OutPutFileTask1.txt";
            Console.WriteLine(Path);

            FileInfo FI = new FileInfo(Path);
            bool A = FI.Exists;
            Assert.AreEqual(true, A);
        }
    }
}