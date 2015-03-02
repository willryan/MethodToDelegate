using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Moq;
using NUnit.Framework;

namespace MethodToDelegate.Test
{
    // A test that shows how this code pattern would be tested
    [TestFixture]
    public class GenericDelegateExampleTest
    {

        [Test]
        public void Test_Adj1()
        {
            Assert.That(GenericDelegateExample.AdjOne<int,string>(5), Is.EqualTo("5ONE"));
            Assert.That(GenericDelegateExample.AdjOne<int,int>(5), Is.EqualTo(6));
            Assert.That(GenericDelegateExample.AdjOne<string,string>("5"), Is.EqualTo("5ONE"));
            Assert.That(GenericDelegateExample.AdjOne<string,int>("5"), Is.EqualTo(6));
        }

        [Test]
        public void Test_Adj2()
        {
            Assert.That(GenericDelegateExample.AdjTwo<int,string>(5), Is.EqualTo("5TWO"));
            Assert.That(GenericDelegateExample.AdjTwo<int,int>(5), Is.EqualTo(7));
            Assert.That(GenericDelegateExample.AdjTwo<string,string>("5"), Is.EqualTo("5TWO"));
            Assert.That(GenericDelegateExample.AdjTwo<string,int>("5"), Is.EqualTo(7));
        }

        [Test]
        public void Test_Combiner()
        {
            var adj1 = new Mock<GenericDelegateExample.AdjustOne<int, string>>();
            var adj2 = new Mock<GenericDelegateExample.AdjustTwo<string, string>>();
            adj1.Setup(a => a(3)).Returns("THREE");
            adj2.Setup(b => b("Four")).Returns("4");
            Assert.That(GenericDelegateExample.Combiner(adj1.Object, adj2.Object, 3, "Four"), Is.EqualTo("THREE:4"));
        }
    }
}