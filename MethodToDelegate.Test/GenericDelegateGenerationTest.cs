using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace MethodToDelegate.Test
{
    [TestFixture]
    public class GenericDelegateGenerationTest
    {
        private Combine<int,int,string> _optionOne;
        private Combine<string,string,int> _optionTwo;

        [SetUp]
        public void Before()
        {
            var di = new QDDI();
            //di.Load(typeof(GenericDelegateExample));
            //_optionOne = di.Get<Combine<int,int,string>>();
            //_optionTwo = di.Get<Combine<string,string,int>>();
        }

        [Test]
        public void Test_CorrectBehavior_OptionOne()
        {
            throw new InconclusiveException("GENERIC SUPPORT NOT YET COMPLETED");
            Assert.That(_optionOne(3, 5), Is.EqualTo("35"));
        }

        [Test]
        public void Test_CorrectBehavior_OptionTwo()
        {
            throw new InconclusiveException("GENERIC SUPPORT NOT YET COMPLETED");
            Assert.That(_optionTwo("3", "5"), Is.EqualTo(8));
        }
    }
}