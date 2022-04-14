using OOPH1.Codes;
using System;

namespace OOPH1
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Teacher t = new("Niels", "Olesen", 1001); 
            Console.WriteLine($"Name = {t.FirstName} {t.LastName}");

            Student s = new("Patric", "S.", 2001);
            Console.WriteLine($"Name = {s.FirstName} {s.LastName}");
        }

        // TargetTyped
    }
}
