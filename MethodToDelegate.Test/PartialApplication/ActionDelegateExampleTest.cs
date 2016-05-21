using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;

namespace MethodToDelegate.Test.PartialApplication
{
    // A test that shows how this code pattern would be tested
    [TestFixture]
    public class ActionDelegateExampleTest
    {

        [Test]
        public void Test_Appendr()
        {
            var list = new[] {"1", "2", "3"}.ToList();
            ActionDelegateExample.Appendr(list, new List<string> {"4", "5"});
            Assert.That(list, Is.EqualTo(new [] {"1", "2", "3", "4", "5"}));
        }

        [Test]
        public void Test_RepAddr()
        {
            var mockAppend = new Mock<ActionDelegateExample.AppendListToList>();
            var mockRepeat = new Mock<ActionDelegateExample.Repeat>();
            mockAppend.Setup(m => m(new List<string> {"1", "2"}, new List<string> {"3", "4"}))
                .Callback((List<string> first, List<string> second) => first.Reverse());
            mockRepeat.Setup(m => m("33",44)).Returns(new List<string>{"3", "4"});
            var list = new List<string> {"1", "2"};
            ActionDelegateExample.RepAddr(mockRepeat.Object, mockAppend.Object, list, "33", 44);
            Assert.That(list, Is.EqualTo(new [] {"2", "1"}));
        }
    }
}