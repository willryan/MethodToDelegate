using System;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace MethodToDelegate.Test
{
    [TestFixture]
    public class DelegateGenerationTest
    {
        private PythagDisplay _vanilla;
        private PythagDisplay _dependencyGenerated;

        [SetUp]
        public void Before()
        {
            var di = new QDDI();
            di.Load(typeof(DelegateExample));
            // vanilla
            DelegateExample.Pythag vanillaPythag = (x, y) => DelegateExample.Pythagr(DelegateExample.Addr, DelegateExample.Multr, DelegateExample.Sqrtr, x, y);
            _vanilla = (x, y) => DelegateExample.PythagD(vanillaPythag, DelegateExample.DoubleToStringr, x, y);
            // Dependency generated
            _dependencyGenerated = di.Get<PythagDisplay>();
        }

        [Test]
        public void Test_ManualCorrectAnswers()
        {
            Assert.That(_dependencyGenerated(3, 4), Is.EqualTo("5"));
            Assert.That(_dependencyGenerated(6, 8), Is.EqualTo("10"));
            Assert.That(_dependencyGenerated(8, 15), Is.EqualTo("17"));
        }

        [Test]
        public void Test_MatchVanilla()
        {
            var values = Enumerable.Range(1, 10)
                .SelectMany(x => Enumerable.Range(1, 10).Select(y => Tuple.Create(x, y)))
                .ToList();
            foreach (var value in values)
            {
                Assert.That(_dependencyGenerated(value.Item1, value.Item2), Is.EqualTo(_vanilla(value.Item1, value.Item2)));
            }
        }

        [Test]
        public void Test_Speed()
        {
            ReportPythag("Vanilla", _vanilla);            
            ReportPythag("DI", _dependencyGenerated);            
            ReportPythag("Vanilla", _vanilla);            
        }

        public static void ReportPythag(string name, PythagDisplay func)
        {
            var time = TimePythag(func);
            Console.WriteLine("{0}: {1}", name, time);
        }

        private static TimeSpan TimePythag(PythagDisplay func)
        {
            var watch = Stopwatch.StartNew();
            foreach (var x in Enumerable.Range(1, 1000))
            {
                foreach (var y in Enumerable.Range(1, 1000))
                {
                    func(x, y);
                }
            }
            return watch.Elapsed;
        }
    }
}