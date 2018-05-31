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
    }
}

