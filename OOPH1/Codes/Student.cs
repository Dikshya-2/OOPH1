using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1.Codes
{
    sealed class Student: TecPerson, ITøj
    {
        public int StudentId { get; set; }
        public string TøjFarve 
        { 
            get; 
            set; 
        }
        public int SkoStørrelse 
        {
            get;
            set;
        }

        public Student(string firstName, string lastName, int studentId) : base(firstName, lastName)
        {
            StudentId = studentId;
            try
            {
                //
                if (SkoStørrelse < 40)
                {
                    throw new Exception("Din sko størrelse er for lille...");
                }
            }
            catch(Exception exc)
            {
                string s = exc.Message;
            }
            
        }

        public override void MinMeaningOmTec(string txt)
        {
            
        }

        public void SetSkoStørrelse(int nr)
        {
            SkoStørrelse = nr;
        }
    }
}
