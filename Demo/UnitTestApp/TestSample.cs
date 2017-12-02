using System;
using Demo;
using NUnit.Framework;


namespace UnitTestApp
{
    [TestFixture]
    public class TestsSample
    {

        [SetUp]
        public void Setup() { }


        [TearDown]
        public void Tear() { }

        [Test]
        public void Pass()
        {
            Console.WriteLine("test1");
            Assert.True(true);
        }

        [Test]
        public void Fail()
        {
            Assert.False(true);
        }

        [Test]
        [Ignore("another time")]
        public void Ignore()
        {
            Assert.True(false);
        }

        [Test]
        public void Inconclusive()
        {
            Assert.Inconclusive("Inconclusive");
        }

        /// <summary>
        /// To run code in Demo project, need to add Xamarin Forms Nuget package
        /// </summary>
        [Test]
        public void Service_Add_ReturnsSum()
        {
            // Arrange
            var service = new Service();
            var expectedResult = 5;

            // Act
            var result = service.Add(2, 3);
            
            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}