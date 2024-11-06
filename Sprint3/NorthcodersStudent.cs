using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    class NorthcodersStudent
    {
        public bool IsDebugging { get; set; }
        public string Name { get; set; }
        public int YearsCoding { get; set; }
        public string CodingAffiliation { get; set; } = "Northcoders";
        public void CheckIfDebugging()
        {
            if (IsDebugging)
            {
                Console.WriteLine("Defeating bugs in code...");
            }
            else
            {
                Console.WriteLine("Bugs defeated, happy coding!");
            }
        }

        public NorthcodersStudent(string name, int yearsCoding, bool isDebugging, string codingAffiliation)
        {
            IsDebugging = isDebugging;
            Name = name;
            YearsCoding = yearsCoding;
            CodingAffiliation = codingAffiliation;
        }
    }
}
