using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTSV
{
    public class Student
    {
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; } // "Nam" hoặc "Nữ"
        public float AverageScore { get; set; }
        public string Faculty { get; set; }

        public Student() { }

        public Student(string studentID, string fullName, string gender, float averageScore, string faculty)
        {
            StudentID = studentID;
            FullName = fullName;
            Gender = gender;
            AverageScore = averageScore;
            Faculty = faculty;
        }
    }
}
