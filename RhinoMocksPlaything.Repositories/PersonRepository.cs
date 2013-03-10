using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        //// ----------------------------------------------------------------------------------------------------------

        public void Save()
        {
            throw new NotImplementedException();
        }

        //// ----------------------------------------------------------------------------------------------------------

        protected virtual void Dispose(bool disposing)
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
