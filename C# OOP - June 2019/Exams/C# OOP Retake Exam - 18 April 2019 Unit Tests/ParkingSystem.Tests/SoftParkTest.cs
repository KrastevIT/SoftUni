namespace ParkingSystem.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    public class SoftParkTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Constructor_Correctly()
        {
            SoftPark park = new SoftPark();

            bool isValid =
              park.Parking.ContainsKey("A1") &&
              park.Parking.ContainsKey("A2") &&
              park.Parking.ContainsKey("A3") &&
              park.Parking.ContainsKey("A4") &&
              park.Parking.ContainsKey("B1") &&
              park.Parking.ContainsKey("B2") &&
              park.Parking.ContainsKey("B3") &&
              park.Parking.ContainsKey("B4") &&
              park.Parking.ContainsKey("C1") &&
              park.Parking.ContainsKey("C2") &&
              park.Parking.ContainsKey("C3") &&
              park.Parking.ContainsKey("C4");


            Assert.IsTrue(isValid);
        }

        [Test]
        public void ParkCar_Correctly_Add()
        {
            SoftPark park = new SoftPark();
            Car car = new Car("Tesla", "9090");

            string returnExpected = park.ParkCar("A1", car);
            var addExpected = park.Parking.Any(x => x.Value == car);

            Assert.AreEqual(addExpected, park.Parking.Any(x => x.Key == "A1" && x.Value == car));
            Assert.AreEqual(returnExpected, $"Car:{car.RegistrationNumber} parked successfully!");
        }

        [Test]
        public void ParkCar_ArgumentException_NoFindPark()
        {
            SoftPark park = new SoftPark();
            Car car = new Car("Tesla", "9090");

            Assert.Throws<ArgumentException>(() =>
            park.ParkCar("D1", car), "Parking spot doesn't exists!");

        }

        [Test]
        public void ParkCar_ArgumentException_ParkSpotBusy()
        {
            SoftPark park = new SoftPark();
            Car car = new Car("Tesla", "9090");

            park.ParkCar("A1", car);

            Assert.Throws<ArgumentException>(() =>
            park.ParkCar("A1", car), "Parking spot is already taken!");

        }

        [Test]
        public void ParkCar_InvalidOperationException_RegistrationNumber()
        {
            SoftPark park = new SoftPark();
            Car car = new Car("Tesla", "9090");

            park.ParkCar("A1", car);

            Assert.Throws<InvalidOperationException>(() =>
            park.ParkCar("A2", car), "Car is already parked!");

        }

        [Test]
        public void RemoveCar_Correctly()
        {
            SoftPark park = new SoftPark();
            Car car = new Car("Tesla", "9090");

            park.ParkCar("A1", car);
            var returnExpected = park.RemoveCar("A1", car);

            var findPark = park.Parking.FirstOrDefault(x => x.Key == "A1");
            bool isValid = findPark.Value == null;

            Assert.IsTrue(isValid);
            Assert.AreEqual(returnExpected, $"Remove car:{car.RegistrationNumber} successfully!");
        }

        [Test]
        public void RemoveCar_ArgumentException_NoFindParkSpot()
        {
            SoftPark park = new SoftPark();
            Car car = new Car("Tesla", "9090");

            Assert.Throws<ArgumentException>(() =>
            park.RemoveCar("D2", car), "Parking spot doesn't exists!");
        }

        [Test]
        public void RemoveCar_ArgumentException_NoFindCar()
        {
            SoftPark park = new SoftPark();
            Car firstCar = new Car("Tesla", "9090");
            Car secondCar = new Car("Opel", "9090");

            park.ParkCar("A1", firstCar);


            Assert.Throws<ArgumentException>(() =>
            park.RemoveCar("A1", secondCar), "Car for that spot doesn't exists!");
        }
    }
}