using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg282Project.BusinessLogicLayer
{
    internal class DataHandler
    {
        public string filename = @"students.txt";
        public int totalStudents;
        public int averageStudentsAge;

        /// <summary>
        /// Generates amount of students in students.txt
        /// </summary>
        public void AmountOfStudents()
        {
            // Read students file
            if (File.Exists(filename))
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string txt;
                    while ((txt = reader.ReadLine()) != null)
                    {
                        totalStudents++; //increments totalStudents count
                    }
                }
            }
        }

        /// <summary>
        /// Generates Average Age of students in students.txt
        /// </summary>
        public void AverageStudentAge()
        {
            string CurrentLine;
            using (StreamReader reader = new StreamReader(filename))
            {
                reader.ReadLine();
                while ((CurrentLine = reader.ReadLine()) != null)
                {

                    string[] Students = CurrentLine.Split(',');
                    int age = int.Parse(Students[2]);
                    averageStudentsAge += age; //increments the averageStudentAge by the age of each student

                }
                averageStudentsAge = averageStudentsAge / totalStudents; // calculates the average age of students
            }
        }

        /// <summary>
        /// Rests averageStudentsAge and averageStudentsAge counters to prevent
        /// duplicate counting if the summary is done again.
        /// </summary>
        public void ResetCounters()
        {
            averageStudentsAge = 0;
            totalStudents = 0;
        }
    }

}
