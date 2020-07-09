using NUnit.Framework;
using CalculatorLib;

namespace CalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2,2,4)]
        [TestCase(100, 10, 110)]
        public void TheNumbersAddUp(int num1, int num2, int expected)
        {
            var actual = Calculator.Add(num1, num2);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(4, 2, 2)]
        [TestCase(10, 7, 3)]
        public void TheNumbersSubtractCorrectly(int num1, int num2, int expected)
        {
            var actual = Calculator.Subtract(num1, num2);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(3, 3, 9)]
        [TestCase(2, 10, 20)]
        public void TheNumbersMultiply(int num1, int num2, int expected)
        {
            var actual = Calculator.Multiply(num1, num2);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(10, 2, 5)]
        [TestCase(20, 2, 10)]
        public void TheNumbersDivide(int num1, int num2, int expected)
        {
            var actual = Calculator.Divide(num1, num2);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(9, 4, 1)]
        [TestCase(6, 5, 1)]
        public void TheNumbersHaveRemainder(int num1, int num2, int expected)
        {
            var actual = Calculator.Modulus(num1, num2);
            Assert.AreEqual(actual, expected);
        }
    }
}