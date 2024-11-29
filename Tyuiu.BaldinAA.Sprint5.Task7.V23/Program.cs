using System.IO;
using Tyuiu.BaldinAA.Sprint5.Task7.V23.Lib;
namespace Tyuiu.BaldinAA.Sprint5.Task7.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");


            string path = $@"C:\DataSprint5\InPutDataFileTask7V23.txt";
            string pathSaveFile = @"C:\Users\Artyom\source\repos\Tyuiu.BaldinAA.Sprint5\Tyuiu.BaldinAA.Sprint5.Task7.V23\bin\Debug\net8.0\OutPutFileTask7.V23.txt";


            Console.WriteLine("Данные находяться в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Находится в файле : ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey(); ;
        }
    }
}
