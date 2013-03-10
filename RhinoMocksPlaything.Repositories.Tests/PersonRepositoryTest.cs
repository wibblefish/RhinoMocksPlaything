using System;
using System.Data.Entity;
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

        [TestMethod]
        public void Insert_Person_ExpectPersonToBeAddedToContext()
        {
            // Arrange
            var context = MockRepository.GenerateStub<IContext>();
            var people = MockRepository.GenerateStub<IDbSet<Person>>();
            context.Stub(c => c.People).Return(people);

            var repository = new PersonRepository(context);

            var person = new Person();

            // Act
            repository.Insert(person);

            // Assert
            people.AssertWasCalled(p => p.Add(person));
        }

        //// ----------------------------------------------------------------------------------------------------------
    }
}
