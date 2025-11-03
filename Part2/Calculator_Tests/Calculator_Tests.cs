using NUnit.Framework;
using Calc;
using System;

namespace Calculator_Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private readonly Calculator _calculatorAddition = new Calculator(5.2, 2.3, '+');
        private readonly Calculator _calculatorSubtraction = new Calculator(5.2, 2.3, '-');
        private readonly Calculator _calculatorMultiplication = new Calculator(5.2, 2.3, '*');
        private readonly Calculator _calculatorDivision = new Calculator(5.2, 2.3, '/');
        
        [Test]
        public void TestAddition()
        {
            Assert.That(_calculatorAddition.Calculate(), Is.EqualTo(7.5).Within(0.001));
        }

        [Test]
        public void TestSubtraction()
        {
            Assert.That(_calculatorSubtraction.Calculate(), Is.EqualTo(2.9).Within(0.001));
        }

        [Test]
        public void TestMultiplication()
        {
            Assert.That(_calculatorMultiplication.Calculate(), Is.EqualTo(11.96).Within(0.001));
        }

        [Test]
        public void TestDivision()
        {
            Assert.That(_calculatorDivision.Calculate(), Is.EqualTo(2.2609).Within(0.001));
        }

        private readonly Calculator _calculatorZeroDivision = new Calculator(5, 0, '/');
        [Test]
        public void TestDivisionByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculatorZeroDivision.Calculate());
        }

        [Test]
        public void TestInvalidOperator_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Calculator(5.2, 2.3, '%'));
        }
    }
}
