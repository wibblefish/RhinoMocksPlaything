using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHamcrest.Core;

using Assert = RhinoMocksPlaything.Tests.NHamcrestHelpers.Assert;

namespace RhinoMocksPlaything.Tests
{
    [TestClass]
    public class PersonTest
    {
        //// ----------------------------------------------------------------------------------------------------------
		 
        [TestMethod]
        public void DefaultConstructor_Call_ExpectIdOfZero()
        {
            // Arrange

            // Act
            var person = new Person();

            // Assert
            Assert.That(person.Id, Is.EqualTo(0));
        }

        //// ----------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void DefaultConstructor_Call_ExpectNullFirstName()
        {
            // Arrange

            // Act
            var person = new Person();

            // Assert
            Assert.That(person.FirstName, Is.Null());
        }

        //// ----------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void DefaultConstructor_Call_ExpectNullLastName()
        {
            // Arrange

            // Act
            var person = new Person();

            // Assert
            Assert.That(person.LastName, Is.Null());
        }

        //// ----------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void DefaultConstructor_Call_ExpectNullFullName()
        {
            // Arrange

            // Act
            var person = new Person();

            // Assert
            Assert.That(person.FullName, Is.Null());
        }

        //// ----------------------------------------------------------------------------------------------------------
    }
}
