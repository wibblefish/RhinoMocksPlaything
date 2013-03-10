using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace RhinoMocksPlaything
{
    [ContractClassFor(typeof(IPersonRepository))]
    internal abstract class PersonRepositoryContract : IPersonRepository
    {
        //// ----------------------------------------------------------------------------------------------------------

        public IEnumerable<Person> People
        {
            get
            {
                throw new NotSupportedException("Used to define the code contracts associated with IPersonRepository.");
            }
        }

        //// ----------------------------------------------------------------------------------------------------------
         
        public Person GetPersonById(int id)
        {
            throw new NotSupportedException("Used to define the code contracts associated with IPersonRepository.");
        }

        //// ----------------------------------------------------------------------------------------------------------

        public void Insert(Person person)
        {
            Contract.Requires<ArgumentNullException>(person != null, "No person supplied.");

            throw new NotSupportedException("Used to define the code contracts associated with IPersonRepository.");
        }

        //// ----------------------------------------------------------------------------------------------------------

        public void Save()
        {
            throw new NotSupportedException("Used to define the code contracts associated with IPersonRepository.");
        }

        //// ----------------------------------------------------------------------------------------------------------
        
        public abstract void Dispose();

        //// ----------------------------------------------------------------------------------------------------------
    }
}