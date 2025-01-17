using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Prg282Project.BusinessLogicLayer
{
    /// <summary>
    /// Student Class 
    /// </summary>
    internal class Student
    {
        // Fields
        int studentID;
        string studentName;
        int studentAge;
        string course;

        // Constructors
        public Student() { }

        public Student(int studentID, string studentName, int studentAge, string course)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.studentAge = studentAge;
            this.course = course;
        }

        //Properties
        public int StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public int StudentAge { get => studentAge; set => studentAge = value; }
        public string Course { get => course; set => course = value; }

    }
}
