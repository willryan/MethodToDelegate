using System;
using System.Diagnostics;
using System.Linq;
using Moq;
using NUnit.Framework;

namespace MethodToDelegate.Test
{
    // A test that shows how this code pattern would be tested
    [TestFixture]
    public class DelegateExampleTest
    {

        [Test]
        public void Test_Addr()
        {
            Assert.That(DelegateExample.Addr(3.0, 4.0), Is.EqualTo(7.0));
        }

        [Test]
        public void Test_Pythag()
        {
            var mockAdd = new Mock<DelegateExample.Add>();
            var mockMult = new Mock<DelegateExample.Mult>();
            var mockSqrt = new Mock<DelegateExample.Sqrt>();
            mockMult.Setup(m => m(1.0, 1.0)).Returns(11.0);
            mockMult.Setup(m => m(2.0, 2.0)).Returns(22.0);
            mockAdd.Setup(a => a(11.0, 22.0)).Returns(1212.0);
            mockSqrt.Setup(s => s(1212.0)).Returns(3.0);
            Assert.That(DelegateExample.Pythagr(mockAdd.Object, mockMult.Object, mockSqrt.Object, 1.0, 2.0), Is.EqualTo(3.0));
        }

        [Test]
        public void Test_PythagDisplay()
        {
            var mockPythag = new Mock<DelegateExample.Pythag>();
            var mockDoubleToString = new Mock<DelegateExample.DoubleToString>();
            mockPythag.Setup(p => p(1.0, 18.0)).Returns(81.0);
            mockDoubleToString.Setup(d => d(81.0)).Returns("Eighty one");
            Assert.That(DelegateExample.PythagD(mockPythag.Object, mockDoubleToString.Object, 1.0, 18.0), Is.EqualTo("Eighty one"));
        }

        [Test]
        public void Test_PythagDisplay_NoMocks()
        {
            DelegateExample.Pythag pythagImpl = (x, y) => x + y;
            DelegateExample.DoubleToString dTosTmpl = (d) => string.Format("Got {0}", d);
            Assert.That(DelegateExample.PythagD(pythagImpl, dTosTmpl, 1.0, 18.0), Is.EqualTo("Got 19"));
        }
    }
}