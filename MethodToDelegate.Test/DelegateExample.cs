using System;

namespace MethodToDelegate.Test
{
    public delegate string PythagDisplay(double x, double y);

    public static class DelegateExample
    {
        public delegate double Add(double x, double y);
        public delegate double Mult(double x, double y);
        public delegate double Sqrt(double x);
        public delegate double Pythag(double x, double y);
        public delegate string DoubleToString(double x);

        [Implements(typeof(Add))]
        public static double Addr(double a, double b)
        {
            return a + b;
        }

        [Implements(typeof(Mult))]
        public static double Multr(double a, double b)
        {
            return a * b;
        }

        [Implements(typeof(Sqrt))]
        public static double Sqrtr(double a)
        {
            return Math.Sqrt(a);
        }

        [Implements(typeof(Pythag))]
        public static double Pythagr(Add add, Mult mult, Sqrt sqrt, double x, double y)
        {
            return sqrt(add(mult(x, x), mult(y, y)));
        }

        [Implements(typeof (DoubleToString))]
        public static string DoubleToStringr(double x)
        {
            return x.ToString();
        }

        [Implements(typeof(PythagDisplay))]
        public static string PythagD(Pythag pyt, DoubleToString itos, double x, double y)
        {
            return itos(pyt(x, y));
        }
    }
}
