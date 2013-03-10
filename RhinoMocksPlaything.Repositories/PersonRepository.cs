using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace RhinoMocksPlaything.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        //// ----------------------------------------------------------------------------------------------------------

        private readonly IContext context;
        
        //// ----------------------------------------------------------------------------------------------------------
         
        private bool disposed = false;

        //// ----------------------------------------------------------------------------------------------------------
        
        public PersonRepository(IContext context)
        {
            Contract.Requires<ArgumentNullException>(context != null);

            this.context = context;
        }

        //// ----------------------------------------------------------------------------------------------------------

        public IEnumerable<Person> People
        {
            get { return context.People.ToList(); }
        }

        //// ----------------------------------------------------------------------------------------------------------
        
        public Person GetPersonById(int id)
        {
            throw new NotImplementedException();
        }

        //// ----------------------------------------------------------------------------------------------------------
         
        public void Insert(Person person)
        {
            context.People.Add(person);
        }

        //// ----------------------------------------------------------------------------------------------------------

        public void Save()
        {
            throw new NotImplementedException();
        }

        //// ----------------------------------------------------------------------------------------------------------

        protected void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            disposed = true;
        }

        //// ----------------------------------------------------------------------------------------------------------
         
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //// ----------------------------------------------------------------------------------------------------------
    }
}
