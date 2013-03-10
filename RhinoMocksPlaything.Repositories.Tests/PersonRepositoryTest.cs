using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace RhinoMocksPlaything.Repositories.Tests
{
    [TestClass]
    public class PersonRepositoryTest
    {
        //// ----------------------------------------------------------------------------------------------------------

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_NullContext_ExpectArgumentNullException()
        {
            // Arrange
            IContext context = null;

            // Act
            var repository = new PersonRepository(context);

            // Assert
        }

        //// ----------------------------------------------------------------------------------------------------------

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Insert_NullPerson_ExpectArgumentNullException()
        {
            // Arrange
            var context = MockRepository.GenerateStub<IContext>();
            Person person = null;
            var repository = new PersonRepository(context);

            // Act
            repository.Insert(person);

            // Assert
        }

        //// ----------------------------------------------------------------------------------------------------------
    }
}
