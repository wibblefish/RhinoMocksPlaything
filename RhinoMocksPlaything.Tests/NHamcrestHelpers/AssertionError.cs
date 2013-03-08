using System;

namespace RhinoMocksPlaything.Tests.NHamcrestHelpers
{
    public class AssertionError : Exception
    {
        //// ----------------------------------------------------------------------------------------------------------

        public AssertionError(string error) : base(error)
        {
        }

        //// ----------------------------------------------------------------------------------------------------------
    }
}