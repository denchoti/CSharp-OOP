using NUnit.Framework;
using System;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry raceEntry;
        private UnitCar car;
        private UnitDriver driver;
        [SetUp]

        public void Setup()
        {
            raceEntry = new RaceEntry();
            car = new UnitCar("Model", 100, 5);
            driver = new UnitDriver("Deni", car);
        }

        [Test]
        public void UnitCarData_IsSetCorrectly()
        {
            Assert.AreEqual(car.Model, "Model");
            Assert.AreEqual(car.HorsePower, 100);
            Assert.AreEqual(car.CubicCentimeters, 5);
        }

        [Test]
        public void UnitDriverData_IsSetCorrectly()
        {
            Assert.AreEqual(driver.Name, "Deni");
            Assert.AreEqual(driver.Car, car);
        }

        [Test]
        public void UnitDriver_ThrowsException_WhenDriverIsNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var driver2 = new UnitDriver(null, car);
            });
        }

        [Test]
        public void Add_ThrowsException_WhenDriverIsNull()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                raceEntry.AddDriver(null);
            });
        }

        [Test]
        public void Add_ThrowsException_WhenDriverAlreadyExists()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                raceEntry.AddDriver(driver);
                raceEntry.AddDriver(driver);
            });
        }

        [Test]
        public void Add_WorksCorrectly()
        {
            raceEntry.AddDriver(driver);
            raceEntry.AddDriver(new UnitDriver("Pesho", car));
            Assert.AreEqual(raceEntry.Counter, 2);
        }

        [Test]
        public void CalculateAverageHorsePower_ThrowsException_WhenDriverCount_IsLesThanMinParticipants()
        {
            raceEntry.AddDriver(driver);
            Assert.Throws<InvalidOperationException>(() =>
            {
                raceEntry.CalculateAverageHorsePower();
            });
        }


        [Test]
        public void CalculateAverageHorsePower_WorksCorrectly()
        {
            raceEntry.AddDriver(driver); //100
            raceEntry.AddDriver(new UnitDriver("Steven", new UnitCar("test", 120, 10)));
            double average = raceEntry.CalculateAverageHorsePower();
            Assert.AreEqual(average, 110);
        }
    }
}
