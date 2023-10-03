using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DudkovIE.Sprint1.Task1.V14.Lib
{
    public class DataService: ISprint1Task1V14
    {
        public double Calculate(double a, double b, double c)
        {
            return a * b / c + (a / (b + c));
        }    
    }
}
