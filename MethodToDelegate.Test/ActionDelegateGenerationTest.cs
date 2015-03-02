using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace MethodToDelegate.Test
{
    [TestFixture]
    public class ActionDelegateGenerationTest
    {
        private RepeatedlyAddToList _subject;

        [SetUp]
        public void Before()
        {
            var di = new QDDI();
            di.Load(typeof(ActionDelegateExample));
            _subject = di.Get<RepeatedlyAddToList>();
        }

        [Test]
        public void Test_CorrectBehavior()
        {
            var strings = new List<string>();
            _subject(strings, "3", 2);
            _subject(strings, "1", 1);
            _subject(strings, "5", 5);
            Assert.That(string.Join("", strings), Is.EqualTo("33155555"));
        }
    }
}