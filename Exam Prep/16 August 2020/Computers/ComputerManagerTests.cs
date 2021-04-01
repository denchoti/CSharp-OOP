using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Computers.Tests
{
    public class Tests
    {
        private Computer computer;
        private ComputerManager manager;

        [SetUp]
        public void Setup()
        {
            this.computer = new Computer("SomeManufacturer", "SomeModel", 200);
            this.manager = new ComputerManager();
        }

        [Test]
        public void CheckIfDataIsInitializedCorrecyly()
        {
            Assert.AreEqual(computer.Manufacturer, "SomeManufacturer");
            Assert.AreEqual(computer.Model, "SomeModel");
            Assert.AreEqual(computer.Price, 200);
        }

        [Test]
        public void Add_ThrowsAgumentException_WhenComputerAlreadyExists()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                manager.AddComputer(computer);
                manager.AddComputer(computer);
            });
        }

        [Test]
        public void Add_ThrowsAgumentException_WhenComputerIsNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                manager.AddComputer(null);
            });
        }

        [Test]
        public void Add_Works_WithCorrectInput()
        {
            manager.AddComputer(computer);          
            Assert.AreEqual(1, manager.Count);
            manager.AddComputer(new Computer("Test","Test1",200));
            Assert.AreEqual(2, manager.Count);
        }

        [Test]
        public void Remove_RemovesComputer()
        {
            manager.AddComputer(computer);
            manager.RemoveComputer("SomeManufacturer", "SomeModel");
            Assert.AreEqual(0, manager.Count);
        }

        [Test]
        public void Remove_ThrowsException_WhenDataIsNull()
        {
            manager.AddComputer(computer);

            Assert.Throws<ArgumentNullException>(() => manager.RemoveComputer("SomeManufacturer", null));
        }

        [Test]
        public void Remove_ThrowsException_WhenDataIsIncorrect()
        {
            manager.AddComputer(computer);

            Assert.Throws<ArgumentException>(() => manager.RemoveComputer("SomeManufacturer", "Blipblop"));
        }


        [Test]
        public void GetComputer_Works()
        {
            manager.AddComputer(computer);
            Assert.AreEqual(computer, manager.GetComputer("SomeManufacturer", "SomeModel"));
        }

        [Test]
        public void GetComputer_ThrowsException_WhenComputerDoesntExist()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                manager.GetComputer("SomeManufacturer", "SomeModel");
            });
        }

        [Test]
        public void GetComputer_ThrowsException_WhenComputerIsNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                manager.GetComputer(null, null);
            });
        }

        [Test]
        public void GetComputersByManufacturer_ReturnComputer_WhenComputerExists()
        {
            var computer2 = new Computer("SomeManufacturer", "OtherModel", 100);
            var computer3 = new Computer("OtherManufacturer", "OtherModel", 100);

            manager.AddComputer(computer);
            manager.AddComputer(computer2);
            manager.AddComputer(computer3);

            var computersFromManafacturer = manager.GetComputersByManufacturer("SomeManufacturer");

            CollectionAssert.Contains(computersFromManafacturer, computer);
            CollectionAssert.Contains(computersFromManafacturer, computer2);
            CollectionAssert.DoesNotContain(computersFromManafacturer, computer3);

        }

    }
}
