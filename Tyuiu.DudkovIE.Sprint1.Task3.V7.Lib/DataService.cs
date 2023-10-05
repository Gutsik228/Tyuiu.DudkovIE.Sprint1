using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DudkovIE.Sprint1.Task3.V7.Lib
{

    public class DataService : ISprint1Task3V7
    {
        public double VerstsToKilometers(double verst)
        {
            return verst * 1.0668;
        }
    }
}
