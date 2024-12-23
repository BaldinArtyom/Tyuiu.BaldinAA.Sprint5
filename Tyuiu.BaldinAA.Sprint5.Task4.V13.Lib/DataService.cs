﻿using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BaldinAA.Sprint5.Task4.V13.Lib
{
    public class DataService : ISprint5Task4V13
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Double.Parse(strX.Replace('.', ','));
            double res = Math.Round(Math.Cos(x) + (Math.Pow(x, 2) / 2), 3);

            return res; ;
        }
    }
}
