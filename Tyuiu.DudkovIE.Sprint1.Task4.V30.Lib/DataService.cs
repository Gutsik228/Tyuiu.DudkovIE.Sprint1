using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DudkovIE.Sprint1.Task4.V30.Lib
{
    public class DataService : ISprint1Task4V30
    {
        public double Calculate(double x, double y)
        {
            double res1 = x + Math.Pow(y, 3);
            double res2 = Math.Pow(Math.E, 2 - y);
            return res1 / res2;
        }
    }
}
