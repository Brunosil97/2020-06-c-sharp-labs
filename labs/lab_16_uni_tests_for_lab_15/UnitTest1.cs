using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using lab_15_unit_testing;

namespace lab_16_uni_tests_for_lab_15
{
    public class Tests
    {
        private int _result;
        private int _sum;
        [SetUp]
        public void Setup()
        {
            //arange and act - we get an actual result
            //_result = Calculator.TripleCalc(10, 2, 4, out int sum);
            //_sum = sum;
        }

        //[Test]
        //public void ProductIsCorrect()

        //{ 
        //    //Assert - see if matches expected result
        //    Assert.AreEqual(80, _result);
        //}

        [TestCase(10,2,4,80)]
        [TestCase(5,2,2,20)]
        public void ProductIsCorrect(int a, int b, int c, int expected)
        {
            var actual = Calculator.TripleCalc(a, b, c, out int sum);
            Assert.AreEqual(expected, actual);
        }

        //[Test]
        //public void SumIsCorrect()

        //{
        //    Assert.AreEqual(16, _sum);
        //}
        [TestCase(2,2,2,6)]
        public void SumIsCorrect(int a, int b, int c, int expected)
        {
            Calculator.TripleCalc(a, b, c, out int sum);
            Assert.AreEqual(expected, sum);
        }
    }
}