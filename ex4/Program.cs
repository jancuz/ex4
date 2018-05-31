using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввод трех комплексных чисел
            double u1 = AskData.ReadDoubleNumber("Введите действительную часть числа U:", double.MinValue, double.MaxValue);
            double u2 = AskData.ReadDoubleNumber("Введите мнимую часть числа U: ", double.MinValue, double.MaxValue);
            Complex u = new Complex(u1, u2);
            Console.WriteLine();

            double v1 = AskData.ReadDoubleNumber("Введите действительную часть числа V: ", double.MinValue, double.MaxValue);
            double v2 = AskData.ReadDoubleNumber("Введите мнимую часть числа V: ", double.MinValue, double.MaxValue);
            Complex v = new Complex(v1, v2);
            Console.WriteLine();

            double w1 = AskData.ReadDoubleNumber("Введите действительную часть числа W: ", double.MinValue, double.MaxValue);
            double w2 = AskData.ReadDoubleNumber("Введите мнимую часть числа W: ", double.MinValue, double.MaxValue);
            Complex w = new Complex(w1, w2);
            Console.WriteLine();
            // выполенение выражения по действиям
            Complex res1 = 2 * u;
            Complex res2 = 3 * u;
            Complex res3 = res2 * w;
            Complex res4 = 2 + w;
            Complex res5 = res4 - v;
            if (res5.RealNumber == 0 && res5.ImaginaryNumber == 0) // проверка знаменателя
                Console.WriteLine("Деление на ноль!");
            else
            {
                Complex res6 = res3 / res5;
                Complex res7 = res1 - res6;
                Complex res = res7 - 7;
                Complex.Show(res);
            }

            Console.ReadLine();
        }
    }
}
