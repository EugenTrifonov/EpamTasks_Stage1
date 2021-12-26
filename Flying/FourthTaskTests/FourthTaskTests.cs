using Flying;
using Flying.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FourthTaskTests
{
    [TestClass]
    public class FourthTaskTests
    {
        [TestMethod]
        [DataRow(2, 4, 1, 2000)]
        public void PositiveGetDistanceTest(int x, int y, int z, int distance)
        {
            Coordinate A = new Coordinate(x, y, z);
            Coordinate B = new Coordinate(x, y, z + 2000);
            Assert.AreEqual(distance, A.GetDistance(B));
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void DroneFlyOutOfRange()
        {
            Coordinate A = new Coordinate(2, 4, 1);
            Coordinate B = new Coordinate(2, 4, 2500);
            IFlyable drone = new Drone(A, 20);
            drone.FlyTo(B);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void BirdFlyOutOfRange()
        {
            Coordinate A = new Coordinate(2, 4, 1);
            Coordinate B = new Coordinate(2, 4, 4500);
            IFlyable bird = new Bird(A);
            bird.FlyTo(B);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void DroneWithLessThenZeroSpeed()
        {
            Coordinate A = new Coordinate(2, 4, 1);
            IFlyable drone = new Drone(A, -30);
        }
    }
}
