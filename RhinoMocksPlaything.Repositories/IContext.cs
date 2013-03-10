using System;
using System.Data.Entity;

namespace RhinoMocksPlaything.Repositories
{
    public interface IContext : IDisposable
    {
        //// ----------------------------------------------------------------------------------------------------------

        IDbSet<Person> People { get; }

        //// ----------------------------------------------------------------------------------------------------------
    }
}