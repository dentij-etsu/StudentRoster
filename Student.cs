using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRoster
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public List<GradeItem> Grades { get; private set; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Grades = new List<GradeItem>();
        }

        public void AddGrade(string name, byte grade) => Grades.Add(new GradeItem(name, grade));
        public void RemoveGrade(string name)
        {
            // Search for all grade itmes to find the first one with the right name
            GradeItem item = Grades.Find(x => x.Name == name);
            // Removed the grade item if found

        }
        
    }
}
