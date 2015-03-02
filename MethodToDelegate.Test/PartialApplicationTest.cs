using System;
using System.Linq;
using NUnit.Framework;

namespace MethodToDelegate.Test
{
    [TestFixture]
    public class PartialApplicationTest
    {

        [Test]
        public void Test_Linq()
        {
            var nums = new[] {1, 2, 3, 4};
            Func<int, int, int> add = (x, y) => x + y;
            Func<int, int, bool> gt = (x, y) => y > x;
            var output = nums.Select(add.Apply(2)).Where(gt.Apply(4));
            Assert.That(output, Is.EqualTo(new [] { 5, 6 }));
        }

        [Test]
        public void Test_Action()
        {
            var value = 19;
            Action<int,int> addProductToValue = (x, y) => value += (x*y);
            addProductToValue.Apply(5)(2);
            Assert.That(value, Is.EqualTo(29));
        }
    }
}