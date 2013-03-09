using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHamcrest.Core;

using Assert = RhinoMocksPlaything.Tests.Support.NHamcrestHelpers.Assert;

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

        [TestMethod]
        public void FullName_PersonHasLastNameOnly_ExpectLastName()
        {
            // Arrange
            var lastName = "Capes";
            var person = new Person
                             {
                                 LastName = lastName
                             };

            // Act
            var fullName = person.FullName;

            // Assert
            Assert.That(fullName, Is.EqualTo(lastName));
        }

        //// ----------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void FullName_PersonHasFirstNameOnly_ExpectFirstName()
        {
            // Arrange
            var firstName = "Geoff";
            var person = new Person
                             {
                                 FirstName = firstName
                             };

            // Act
            var fullName = person.FullName;

            // Assert
            Assert.That(fullName, Is.EqualTo(firstName));
        }

        //// ----------------------------------------------------------------------------------------------------------

        [TestMethod]
        public void FullName_PersonHasFirstNameAndLastName_ExpectLastNameFollowedByACommaASpaceAndFirstName()
        {
            // Arrange
            var firstName = "Geoff";
            var lastName = "Capes";
            var person = new Person
                             {
                                 FirstName = firstName,
                                 LastName = lastName
                             };

            // Act
            var fullName = person.FullName;

            // Assert
            var expected = "Capes, Geoff";
            Assert.That(fullName, Is.EqualTo(expected));
        }

        //// ----------------------------------------------------------------------------------------------------------
    }
}
