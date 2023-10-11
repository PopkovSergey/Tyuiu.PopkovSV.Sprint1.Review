using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PopkovSV.Sprint1.TaskReview.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            double res = (2 / Math.Tan(3 * x)) - ((Math.Log10(Math.Cos(x))) / (Math.Log10(1 + (Math.Pow(x, 2)))));
            return Math.Round (res, 3);
        }
    }
}
