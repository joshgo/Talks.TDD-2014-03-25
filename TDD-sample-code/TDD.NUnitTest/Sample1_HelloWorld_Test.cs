using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace TDD.NUnitTest
{
    [TestFixture]
    public class Sample1_HelloWorld_Test
    {
        [Test]
        public void HelloWorldTest()
        {
            Assert.AreEqual("Hello WORLD!!!", HelloWorld());
        }

        public static string HelloWorld()
        {
            return "Hello World";
        }
    }
}
