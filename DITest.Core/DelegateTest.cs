using System;
using System.Diagnostics;
using System.Linq;
using Ninject.Infrastructure.Language;

namespace DITest.Core
{
    public static class DelegateTest
    {
        public static void TestIt()
        {
            DelegateHandler.RegisterDelegates(typeof(Funks));
            // vanilla
            Funks.Pythag vanillaPythag = (x, y) => Funks.Pythagr(Funks.Addr, Funks.Multr, Funks.Sqrtr, x, y);
            Func<double, double, string> vanillaFunc = (x, y) => Funks.PythagD(vanillaPythag, Funks.DoubleToStringr, x, y);
            // Dependency generated
            var diFunc = DI.Get<PythagDisplay>();

            ReportPythag("Vanilla", vanillaFunc);
            ReportPythag("DI", (d, d1) => diFunc(d, d1));
            ReportPythag("Vanilla", vanillaFunc);
        }

        public static void ReportPythag(string name, Func<double, double, string> func)
        {
            var time = TimePythag(func);
            Console.WriteLine("{0}: {1}", name, time);
        }

        public static TimeSpan TimePythag(Func<double, double, string> func)
        {
            var watch =Stopwatch.StartNew();
            Enumerable.Range(1, 1000).Map(x =>
            {
                Enumerable.Range(1, 1000).Map(y =>
                {
                    func(x, y);
                });
            });
            return watch.Elapsed;
        }
    }
}