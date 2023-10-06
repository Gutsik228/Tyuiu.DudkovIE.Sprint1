using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DudkovIE.Sprint1.Task4.V30.Lib;
namespace Tyuiu.DudkovIE.Sprint1.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа x, y");
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Дудков И. Е. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема:  Class Math                                                       *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Дудков Игорь Евгеньевич | СМАРТб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("*   вычисляет результат по формуле и печатает его на экране (x+y^3) / e^(2−y)*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x + " y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(Math.Round(ds.Calculate(x, y), 2));



            Console.ReadKey();
        }
    }
}
