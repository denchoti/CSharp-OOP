using System;
using System.Linq;
using NUnit.Framework;

namespace Tests
{
    public class DatabaseTests
    {
        private Database database;
        [SetUp]
        public void Setup()
        {
            database = new Database();
        }

        [Test]
        public void Add_ThrowException_WhenCapacityIsExceeded()
        {
            
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(17));
        }

        [Test]
        public void Add_IncreasesDatabaseCount_WhenAddIsValidOperation()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                this.database.Add(123);
            }

            Assert.That(database.Count, Is.EqualTo(n));
        }
        [Test]
        public void Add_AddsElementToDatabase()
        {
            int element = 123;
            database.Add(element);
            int[] elements = database.Fetch();
            Assert.That(elements.Contains(element));
        }

        [Test]
        public void Remove_ThrowsException_WhenDatabaseIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void Remove_DecreasesDatabaseCount()
        {
            database.Add(1);
            database.Add(2);
            database.Add(3);
            database.Remove();

            int expectedCount = 2;
            Assert.That(database.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void Remove_DeleteslementFromDatabase()
        {
            int lastElement = 3;
            database.Add(1);
            database.Add(2);
            database.Add(lastElement);
            database.Remove();
            int[] elements = database.Fetch();
            Assert.IsFalse(elements.Contains(lastElement));
        }

        [Test]
        public void Fetch_ReturnsDatabaseCopyInsteadOfReference()
        {
            database.Add(1);
            database.Add(2);
            int[] firstCopy = database.Fetch();
            database.Add(3);
            int[] secondCopy = database.Fetch();

            Assert.That(firstCopy, Is.Not.EqualTo(secondCopy));
        }

        [Test]
        public void Count_ReturnZeroWhenDatabaseIsEmpty()
        {
            Assert.That(database.Count, Is.EqualTo(0));
        }

        [Test]
        public void Ctor_ThrowsExceptionWhenDatabaseCapcityIsExceeded()
        {
            Assert.Throws<InvalidOperationException>(() => 
            database = new Database(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17));
        }

        [Test]
        public void Ctor_AddsElementToDatabase()
        {
            int[] arr = new[] { 1, 2, 3 };
            database = new Database(arr);

            Assert.That(database.Count, Is.EqualTo(arr.Length));
            Assert.That(database.Fetch(), Is.EquivalentTo(arr));

        }
    }
}