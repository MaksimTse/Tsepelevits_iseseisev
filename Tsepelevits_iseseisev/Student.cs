using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsepelevits_iseseisev
{
    class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string GroupCode { get; set; }
        public int[] Grades { get; set; }

        public Student(string lastName, string firstName, string groupCode, int[] grades)
        {
            LastName = lastName;
            FirstName = firstName;
            GroupCode = groupCode;
            Grades = grades;

        }

        public bool HasScholarship()
        {
            foreach (int grade in Grades)
            {
                if (grade < 4)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
