using System.Diagnostics.Contracts;

namespace RhinoMocksPlaything
{
    [ContractClass(typeof(PersonRepositoryContract))]
    public interface IPersonRepository
    {
        //// ----------------------------------------------------------------------------------------------------------

        void Save(Person person);

        //// ----------------------------------------------------------------------------------------------------------
    }
}
