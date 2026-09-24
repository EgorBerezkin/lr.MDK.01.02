using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryDelenie;

namespace Delenie
{
    [TestClass]
    public class UnitTestDataRowDelenie
    {
        [TestClass]
        public class UnitTestDelenie
        {
            [DataTestMethod]
            [DataRow(8.0, 2.0, 4.0)]
            [DataRow(-8.0, 2.0, -4.0)]
            [DataRow(-8.0, -2.0, 4.0)]
            [DataRow(8.0, -2.0, -4.0)]
            [DataRow(0.0, 2.0, 0.0)]
            [DataRow(8.0, 0.0, double.PositiveInfinity)]
            [DataRow(0.0, -2.0, 0.0)]
            [DataRow(-8.0, 2.0, double.NegativeInfinity)]
            [DataRow(8.8, 4.4, 2.0)]
            public void TestDelenie_AllCases(double a, double b, double expected)
            {
                double real = Calculator.CalculeteDelenie(a, b);
                Assert.AreEqual(expected, real);
                //Calculator delenie = new Calculator();
                //double c = expected;
                //double real = delenie.CalculeteDelenie(a, b);
                //Assert.AreEqual(c, real);
            }
        }
    }
}
