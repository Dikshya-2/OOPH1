using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1.Codes
{
    sealed class Teacher: TecPerson
    {
        public int TeacherId { get; set; }
        public Teacher(string firstName, string lastName, int teacherId) : base(firstName, lastName)
        {
            TeacherId = teacherId;
        }

        public override void MinMeaningOmTec(string txt)
        {
            
        }
    }
}
