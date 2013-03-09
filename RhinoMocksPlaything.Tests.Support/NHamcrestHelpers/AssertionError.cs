using System;

namespace RhinoMocksPlaything.Tests.Support.NHamcrestHelpers
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