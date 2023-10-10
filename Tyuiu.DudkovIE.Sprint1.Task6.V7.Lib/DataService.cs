using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DudkovIE.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string[] StrArr = value.Split(' ');
            string NewString = "";
            for(int i = 0; i < StrArr.Length; i++)
            {
                for(int j = 0; j < StrArr[i].Length - 1; j++)
                {
                    NewString += StrArr[i][j];    
                }
                NewString += " ";     
            }
            return NewString;
        }
    }
}
