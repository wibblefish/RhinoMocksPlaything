using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RhinoMocksPlaything.Repositories
{
    public class Context : DbContext, IContext
    {
        //// ----------------------------------------------------------------------------------------------------------

        public IDbSet<Person> People { get; set; }

        //// ----------------------------------------------------------------------------------------------------------

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        //// ----------------------------------------------------------------------------------------------------------
    }
}
