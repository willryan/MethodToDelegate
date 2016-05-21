using System;

namespace MethodToDelegate.Test.ReturnDelegate
{
    public delegate string PythagDisplay(double x, double y);

    public static class DelegateExample
    {
        public delegate double Add(double x, double y);
        public delegate double Mult(double x, double y);
        public delegate double Sqrt(double x);
        public delegate double Pythag(double x, double y);
        public delegate string DoubleToString(double x);

        public static Add Addr() => (double a, double b) => a + b;
        public static Mult Multr() => (double a, double b) => a*b;

        public static Sqrt Sqrtr() => Math.Sqrt;

        public static Pythag Pythagr(Add add, Mult mult, Sqrt sqrt) => 
            (double x, double y) => sqrt(add(mult(x, x), mult(y, y)));

        public static DoubleToString DoubleToStringr() => (double x) => x.ToString();

        public static PythagDisplay PythagD(Pythag pyt, DoubleToString itos) => 
            (double x, double y) => itos(pyt(x, y));
    }

}
