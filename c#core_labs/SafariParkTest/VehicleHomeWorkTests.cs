
using NUnit.Framework;
using SafariPark;

namespace SafariParkTest
{
    class VehicleHomeWorkTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
            
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMoveOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [TestCase(0, 0)]
        [TestCase(1,1)]
        [TestCase(4, 4)]
        [TestCase(6, 5)]
        public void VehicleCapacityTest(int numPassengers, int expectedPassengers)
        {
            Vehicle v = new Vehicle(5);
            v.NumPassengers = numPassengers;
            Assert.AreEqual(expectedPassengers, v.NumPassengers);
        }
    }
}
