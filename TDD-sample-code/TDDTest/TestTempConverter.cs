using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDLib;

namespace TDDTest
{
    [TestClass]
    public class TestTempConverter
    {
        [TestMethod]
        public void TestCelsiusToFahrenheit()
        {
            var converter = new TempConverter();
            Assert.AreEqual(32, converter.Convert(0, TempEnum.Celsius, TempEnum.Fahrenheit));
        }

        [TestMethod]
        public void TestFahrenheitToCelsius()
        {
            var converter = new TempConverter();
            Assert.AreEqual(-17.7778, converter.Convert(0, TempEnum.Fahrenheit, TempEnum.Celsius));
        }
    }
}
