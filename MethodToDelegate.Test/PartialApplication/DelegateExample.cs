using System;
using MethodToDelegate.PartialApplication;

namespace MethodToDelegate.Test.PartialApplication
{
    public delegate string PythagDisplay(double x, double y);

    public static class DelegateExample
    {
        public delegate double Add(double x, double y);
        public delegate double Mult(double x, double y);
        public delegate double Sqrt(double x);
        public delegate double Pythag(double x, double y);
        public delegate string DoubleToString(double x);

        [ToDelegate(typeof(Add))]
        public static double Addr(double a, double b) => a + b;

        [ToDelegate(typeof (Mult))]
        public static double Multr(double a, double b) => a*b;

        [ToDelegate(typeof (Sqrt))]
        public static double Sqrtr(double a) => Math.Sqrt(a);

        [ToDelegate(typeof(Pythag))]
        public static double Pythagr(Add add, Mult mult, Sqrt sqrt, double x, double y) => 
            sqrt(add(mult(x, x), mult(y, y)));

        [ToDelegate(typeof (DoubleToString))]
        public static string DoubleToStringr(double x) => x.ToString();

        [ToDelegate(typeof(PythagDisplay))]
        public static string PythagD(Pythag pyt, DoubleToString itos, double x, double y) => 
            itos(pyt(x, y));
    }
}
