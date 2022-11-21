using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRoster
{
    record GradeItem
    {
        public readonly byte Grade;
        public readonly string Name; // Name of assignment

        public string Letter => GetLetterGrade();

        public GradeItem(string name, byte grade)
        {
            Name = name;
            Grade = (byte)(grade % 100);
        }

        public string GetLetterGrade()
        {
            if (Grade >= 97) return "A+";
            if (Grade >= 93) return "A";
            if (Grade >= 90) return "A-";
            if (Grade >= 80) return "B+";
            if (Grade >= 70) return "C";
            if (Grade >= 60) return "D";
            if (Grade >= 10) return "F";
            else return "Super F";

        }
    }
}
