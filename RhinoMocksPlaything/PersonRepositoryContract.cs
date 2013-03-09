using System;
using System.Diagnostics.Contracts;

namespace RhinoMocksPlaything
{
    [ContractClassFor(typeof(IPersonRepository))]
    public class PersonRepositoryContract : IPersonRepository
    {
        //// ----------------------------------------------------------------------------------------------------------
        
        public void Save(Person person)
        {
            Contract.Requires<ArgumentNullException>(person != null, "No person supplied.");

            throw new NotSupportedException("Used to define the code contracts associated with IPersonRepository.");
        }

        //// ----------------------------------------------------------------------------------------------------------
    }
}