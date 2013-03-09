using System;

namespace RhinoMocksPlaything
{
    public class Person
    {
        //// ----------------------------------------------------------------------------------------------------------
         
        private const string LastNameFormat = "{0}, {1}";
        
        //// ----------------------------------------------------------------------------------------------------------

        public int Id { get; protected set; }

        //// ----------------------------------------------------------------------------------------------------------

        public string FirstName { get; set; }

        //// ----------------------------------------------------------------------------------------------------------

        public string LastName { get; set; }

        //// ----------------------------------------------------------------------------------------------------------

        public string FullName
        {
            get
            {
                if (FirstName != null && LastName != null)
                    return String.Format(LastNameFormat, LastName, FirstName);

                if (FirstName == null)
                    return LastName;

                return FirstName;
            }
        }

        //// ----------------------------------------------------------------------------------------------------------
    }
}
