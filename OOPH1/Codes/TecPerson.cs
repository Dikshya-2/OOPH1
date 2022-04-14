using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1.Codes
{
    abstract class TecPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public TecPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public abstract void MinMeaningOmTec(string txt);
    }
}
