using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
        private readonly int NightsToRentHotel = 5;

        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(new DateTime(1990, 2, 3), new DateTime(1991, 2, 3), 100);
            Assert.IsNotNull(target);
        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightDoesntTimeTravel()
        {
            var target = new Flight(new DateTime(1992, 2, 3), new DateTime(1991, 2, 3), 100);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightDoesntGoBackwards()
        {
            var target = new Flight(new DateTime(1990, 2, 3), new DateTime(1991, 2, 3), -100);
        }
        [Test()]
        public void TestFlightEquals()
        {
            var target1 = new Flight(new DateTime(1990, 2, 3), new DateTime(1991, 2, 3), 100);
            var target2 = new Flight(new DateTime(1990, 2, 3), new DateTime(1991, 2, 3), 100);
            Assert.AreEqual(true, target1.Equals(target2));
        }
	}
}
