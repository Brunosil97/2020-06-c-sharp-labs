using NUnit.Framework;
using SafariPark;

namespace SafariParkTest
{
    public class PersonTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Bruno", "Silva", "Bruno Silva")]
        [TestCase("", "", " ")]
        public void GetFullNameTest(string fname, string lname, string expected)
        {
            var instance = new Person(fname, lname);
            var actual = instance.GetFullName();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetAgeIfSame()
        {
            var instance = new Person("A", "B") { Age = 25 };
            var actual = instance.Age = 25;
            Assert.AreEqual(25, actual);
        }
    }
}