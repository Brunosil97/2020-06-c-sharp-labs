using NUnit.Framework;
using TechInterviewQuestions;

namespace TechInterviewTest
{
    public class Tests
    {
        //private PrimeFactor _primeFactor;
        [SetUp]
        public void Setup()
        {
           // _primeFactor = new PrimeFactor();
        }

        
        [TestCase(10, 2)]
        [TestCase(15, 3)]
        [TestCase(60, 10)]
        public void SumPrimeInputNumbersTest(int number, int expectedResult)
        {
            var _primeFactor = new PrimeFactor();
            var result = _primeFactor.SumPrimeInputNumbers(number);
            Assert.AreEqual(expectedResult, result);
        }
    }
}