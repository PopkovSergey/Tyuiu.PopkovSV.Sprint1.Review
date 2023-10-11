using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint1.TaskReview.V10.Lib;

namespace Tyuiu.PopkovSV.Sprint1.TaskReview.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 20;
            double wait = 6.399;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
