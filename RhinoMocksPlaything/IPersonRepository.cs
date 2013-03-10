using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace RhinoMocksPlaything
{
    [ContractClass(typeof(PersonRepositoryContract))]
    public interface IPersonRepository : IDisposable
    {
        //// ----------------------------------------------------------------------------------------------------------

        IEnumerable<Person> People { get; }

        //// ----------------------------------------------------------------------------------------------------------
         
        Person GetPersonById(int id);
        
        //// ----------------------------------------------------------------------------------------------------------
         
        void Insert(Person person);

        //// ----------------------------------------------------------------------------------------------------------
         
        void Save();

        //// ----------------------------------------------------------------------------------------------------------
    }
}
