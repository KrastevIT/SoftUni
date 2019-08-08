using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddRider_Correctly()
        {
            RaceEntry race = new RaceEntry();
            UnitMotorcycle motorcycle = new UnitMotorcycle("Suzuki", 100, 650);
            UnitRider rider = new UnitRider("Pesho", motorcycle);

            string actualMessage = race.AddRider(rider);

            Assert.AreEqual("Rider Pesho added in race.", actualMessage);
            Assert.AreEqual(1, race.Counter);
        }

        [Test]
        public void AddRider_ThrowInvalidOperationExceptionNull()
        {
            RaceEntry race = new RaceEntry();

            Assert.Throws<InvalidOperationException>(() => race.AddRider(null));
        }

        [Test]
        public void AddRider_ContainsRider_InvalidOperationException()
        {
            RaceEntry race = new RaceEntry();
            UnitMotorcycle motorcycle = new UnitMotorcycle("Suzuki", 100, 650);
            UnitRider rider = new UnitRider("Pesho", motorcycle);

            race.AddRider(rider);

            Assert.Throws<InvalidOperationException>(() => race.AddRider(rider));
        }

        [Test]
        public void AddRider_Return_InvalidOperationException()
        {
            RaceEntry race = new RaceEntry();
            UnitMotorcycle motorcycle = new UnitMotorcycle("Suzuki", 100, 650);
            UnitRider rider = new UnitRider("Pesho", motorcycle);

            race.AddRider(rider);

            Assert.Throws<InvalidOperationException>(() => race.AddRider(rider),
                "Rider Pesho is already added.");
        }

        [Test]
        public void CalculateAverageHorsePower_Correctly()
        {
            RaceEntry race = new RaceEntry();

            UnitMotorcycle firstMotorcycle = new UnitMotorcycle("Suzuki", 100, 650);
            UnitMotorcycle secondMotorcycle = new UnitMotorcycle("Yamaha", 200, 1000);

            UnitRider firstRider = new UnitRider("Pesho", firstMotorcycle);
            UnitRider secondRider = new UnitRider("Gosho", secondMotorcycle);

            race.AddRider(firstRider);
            race.AddRider(secondRider);

            double expectedAverageHorsePower = (firstMotorcycle.HorsePower + secondMotorcycle.HorsePower) / 2;

            Assert.AreEqual(expectedAverageHorsePower, race.CalculateAverageHorsePower());
        }

    }
}