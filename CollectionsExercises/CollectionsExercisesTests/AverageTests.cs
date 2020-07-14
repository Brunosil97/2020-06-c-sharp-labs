using NUnit.Framework;
<<<<<<< HEAD

namespace CollectionsExercisesTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			Assert.Pass();
		}
	}
=======
using CollectionsExercisesLib;
using System.Collections.Generic;

namespace CollectionsExercisesTests
{
    public class AverageTests
    {
        [Test]
        public void IfTheListIsEmptyTheAverageIsZero()
        {
            var argList = new List<double>();
            var result = ListExercises.Average(argList);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void GivenAListIsTheAverageCorrect()
        {
            var argList = new List<double> { 5, 2, 6, 1 };
            var result = ListExercises.Average(argList);
            Assert.AreEqual(3.5, result);
        }
    }
>>>>>>> collections_hw
}