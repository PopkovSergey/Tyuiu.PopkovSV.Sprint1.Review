using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PopkovSV.Sprint1.TaskReview.V10.Lib;

namespace Tyuiu.PopkovSV.Sprint1.TaskReview.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine($"Результат:" + Math.Round(ds.Calculate(x), 3));
            Console.ReadLine();
        }
    }
}
