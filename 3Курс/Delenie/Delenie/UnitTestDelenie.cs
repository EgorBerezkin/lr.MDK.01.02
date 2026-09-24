using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryDelenie;
using System;

namespace Delenie
{
    [TestClass]
    public class UnitTestDelenie
    {
        [TestMethod]
        public void TestMethodDelenieInt()
        {
            // Деление целочисленные положительных
            Calculator calculator = new Calculator();
            double c = 4.0;
            double division =  Calculator.CalculeteDelenie(8.0, 2.0);
            Assert.AreEqual(division, c);
        }
        [TestMethod]
        public void TestMethodDelenieMinus1()
        {
            // Деление отрицательных на положительное целое числа
            Calculator calculator = new Calculator();
            double c = -4.0;
            double division = Calculator.CalculeteDelenie(-8.0, 2.0);
            Assert.AreEqual(division, c);
        }
        [TestMethod]
        public void TestMethodDelenieMinus2()
        {
            // Деление положительное на отрицательных целое числа
            Calculator calculator = new Calculator();
            double c = -4.0;
            double division = Calculator.CalculeteDelenie(8.0, -2.0);
            Assert.AreEqual(division, c);
        }
        [TestMethod]
        public void TestMethodDelenieOtrizatelnie()
        {
            // Деление отрицательных
            Calculator calculator = new Calculator();
            double c = 4.0;
            double division = Calculator.CalculeteDelenie(-8.0, -2.0);
            Assert.AreEqual(division, c);
        }
        [TestMethod]
        public void TestMethodDelenieNaNull()
        {
            // Деление на нолика
            Calculator calculator = new Calculator();
            double c = double.PositiveInfinity;
            double division = Calculator.CalculeteDelenie(8.0, 0.0);
            Assert.AreEqual(division, c);
        }
        [TestMethod]
        public void TestMethodDelenieNullNaChislo()
        {
            // Деление нолика
            Calculator calculator = new Calculator();
            double c = 0.0;
            double division = Calculator.CalculeteDelenie(0.0, 8.0);
            Assert.AreEqual(division, c);
        }

        [TestMethod]
        public void TestMethodDelenieOtricatelnoeNaNull()
        {
            // Деление отрицательного числа на нолика
            Calculator calculator = new Calculator();
            double c = double.NegativeInfinity;
            double division = Calculator.CalculeteDelenie(-8.0, 0.0);
            Assert.AreEqual(division, c);
        }
        [TestMethod]
        public void TestMethodDelenieNullNaOtricatelnoeChislo()
        {
            // Деление нолика
            Calculator calculator = new Calculator();
            double c = 0.0;
            double division = Calculator.CalculeteDelenie(0.0, -8.0);
            Assert.AreEqual(division, c);
        }
    }
}
