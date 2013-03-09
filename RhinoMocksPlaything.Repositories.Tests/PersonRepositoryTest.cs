using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RhinoMocksPlaything.Repositories.Tests
{
    [TestClass]
    public class PersonRepositoryTest
    {
        //// ----------------------------------------------------------------------------------------------------------

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Save_NullPerson_ExpectArgumentNullException()
        {
            // Arrange
            Person person = null;
            var repository = new PersonRepository();

            // Act
            repository.Save(person);

            // Assert
        }

        //// ----------------------------------------------------------------------------------------------------------
    }
}
