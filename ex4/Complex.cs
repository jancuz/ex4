using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace ex4
{
    class Complex //класс, отвечающий за выполения действий над комплексными числами
    {
        public double RealNumber;
        public double ImaginaryNumber;

        public Complex(double a, double b)
        {
            RealNumber = a;
            ImaginaryNumber = b;
        }

        // перегрузка оператора +
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.RealNumber + b.RealNumber, a.ImaginaryNumber + b.ImaginaryNumber);
        }
        public static Complex operator +(double num, Complex a)
        {
            return new Complex(a.RealNumber + num, a.ImaginaryNumber);
        }

        // перегрузка оператора -
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.RealNumber - b.RealNumber, a.ImaginaryNumber - b.ImaginaryNumber);
        }
        public static Complex operator -(Complex a, double num)
        {
            return new Complex(a.RealNumber - num, a.ImaginaryNumber);
        }

        // перегрузка оператора *
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.RealNumber * b.RealNumber + a.ImaginaryNumber * b.ImaginaryNumber * (-1),
                a.RealNumber * b.ImaginaryNumber + a.ImaginaryNumber * b.RealNumber);
        }
        public static Complex operator *(double num, Complex a)
        {
            return new Complex(a.RealNumber * num, a.ImaginaryNumber * num);
        }

        // перегрузка оператора /
        public static Complex operator /(Complex a, Complex b)
        {
            Complex bNegative = new Complex(b.RealNumber, b.ImaginaryNumber * (-1));
            Complex numerator = new Complex((a * bNegative).RealNumber, (a * bNegative).ImaginaryNumber);
            double denominator = Math.Pow(b.RealNumber, 2) - Math.Pow(b.ImaginaryNumber, 2) * (-1);
            return new Complex(numerator.RealNumber / denominator, numerator.ImaginaryNumber / denominator);
        }

        public static void Show(Complex res)
        {
            if (res.ImaginaryNumber == 0)
                Console.WriteLine("Выражение: 2 * u - 3 * u * v / (2 + w - v) - 7 = {0}", res.RealNumber);
            else
                if (res.ImaginaryNumber < 0)
                Console.WriteLine("Выражение: 2 * u - 3 * u * v / (2 + w - v) - 7 = {0} - {1}i", res.RealNumber, Math.Abs(res.ImaginaryNumber));
            else
                Console.WriteLine("Выражение: 2 * u - 3 * u * v / (2 + w - v) - 7 = {0} + {1}i", res.RealNumber, res.ImaginaryNumber);
        }
    }
}

