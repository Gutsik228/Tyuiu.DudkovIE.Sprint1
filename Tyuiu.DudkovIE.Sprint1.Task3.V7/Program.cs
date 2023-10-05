using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DudkovIE.Sprint1.Task3.V7.Lib;
namespace Tyuiu.DudkovIE.Sprint1.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число верст");
            int num;
            num = int.Parse(Console.ReadLine());

            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Дудков И. Е. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема:  1.3 Операторы составного присваивания                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Дудков Игорь Евгеньевич | СМАРТб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.,          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(num);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.VerstsToKilometers(num));



            Console.ReadKey();
        }
    }
}
