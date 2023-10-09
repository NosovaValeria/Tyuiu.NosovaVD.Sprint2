using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NosovaVD.Sprint2.Task1.V26.Lib;
namespace Tyuiu.NosovaVD.Sprint2.Task1.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Носова В.Д. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Носова Валерия Дмитриевна | ПКТб-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций, а также *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int a = 654;
            int b = 671;
            int c = 874;
            int d = 137;
            Console.WriteLine("Значение A: " + a);
            Console.WriteLine("Значение B: " + b);
            Console.WriteLine("Значение C: " + c);
            Console.WriteLine("Значение D: " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            bool[] res = ds.GetLogicOperations(a,b,c,d);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }


            Console.ReadKey();
        }
    }
}
