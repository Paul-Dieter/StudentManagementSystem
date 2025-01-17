using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.DirectoryServices;
using System.Diagnostics;
using Prg282Project.BusinessLogicLayer;

namespace Prg282Project.DataLayer
{
    internal class FileHandler
    {
        public string filename = @"students.txt";
        public string summaryFilename = @"summary.txt";
        public static List<Student> studentTextList = new List<Student>();

        /// <summary>
        /// Checks if the student text file exists and creates it if not.
        /// </summary>
        public List<Student> CreateStudentTextFile()
        {
            if (!File.Exists(filename)) // Creates file if it does not exist
            {
                List<Student> initialStudents = new List<Student>
                {
                    new Student(578003, "Hayley Treutens", 21, "BComp"),
                    new Student(577999, "Kyle Smith", 24, "BComp"),
                    new Student(600948, "Paul-Dieter Brandt", 25, "BComp"),
                    new Student(697834, "Markiplier", 35, "BIT"),
                    new Student(697834, "PewDiePie", 35, "BIT"),
                    new Student(825395, "Johnny Depp", 61, "BComp"),
                    new Student(364729, "Barack Obama", 63, "BIT"),
                    new Student(278403, "Brad Pit", 60, "BIT"),
                    new Student(579204, "Queen Elizabeth", 96, "BIT"),
                    new Student(529462, "Keanu Reeves", 60, "BIT"),
                };
                WriteStudentsToFile(initialStudents);
            }
            studentTextList = ReadStudentTextFile(); // Retrieves data from file 
            return studentTextList;
        }

        /// <summary>
        /// Writes a list of students to the student text file.
        /// </summary>
        public void WriteStudentsToFile(List<Student> students)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Student student in students)
                {
                    writer.WriteLine($"{student.StudentID},{student.StudentName},{student.StudentAge},{student.Course}"); //Writes student data to the text file
                }
            }
        }

        /// <summary>
        /// Reads all data in the student text file and updates the in-memory list of students.
        /// </summary>
        public List<Student> ReadStudentTextFile()
        {
            studentTextList.Clear();
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            using (StreamReader reader = new StreamReader(fs))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(','); //Splits data into a format to match a Student object 
                    Student st = new Student(int.Parse(fields[0]), fields[1], int.Parse(fields[2]), fields[3]);
                    studentTextList.Add(st);
                }
            }
            return studentTextList;
        }

        /// <summary>
        /// Generates summary.txt
        /// </summary>
        public void GenerateSummary(DataHandler dh)
        {
            //Create File
            if (!File.Exists(summaryFilename))
            {
                File.Create(summaryFilename);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(summaryFilename))
                {
                    writer.Write($"Amount of students: {dh.totalStudents}, Average Age: {dh.averageStudentsAge}, Date: {DateTime.Now:yyyy-MM-dd}");
                }
            }
        }

        /// <summary>
        /// Overwrites file without the student correlated to the id provided
        /// Hence "delete"
        /// </summary>
        public void DeleteStudentInfo(string id)
        {
            List<string> newLines = new List<string>();

            using (StreamReader SR = new StreamReader(filename))
            {
                string line;
                while ((line = SR.ReadLine()) != null)
                {
                    if (!line.Contains(id)) //If line does not contain id, adds line to newLines list
                    {
                        newLines.Add(line);
                    }
                }
            }

            using (StreamWriter SW = new StreamWriter(filename))
            {
                foreach (string line in newLines)
                {
                    SW.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// Code starts a new process to open specified file using its default associated application
        /// Utilizes ProcessStartInfo with the file path and setting UseShellExecute to true
        /// Basically allowing the opening of a file as if it were double clicked in its folder
        /// </summary>
        public void OpenFile()
        {
            if (File.Exists(filename))
            {
                //Process.Start runs a new process on computer
                Process.Start(new ProcessStartInfo(filename) //holds the configuration information for starting a process.
                {
                    UseShellExecute = true // UseShellExecute specifies whether to use the operating system shell to start the process. true = allows non-executable files to be opened with their associated application
                });
            }
        }

        ///<summary>
        ///Create admin login.txt with username and password.
        /// </summary>
        public static void CreateLoginTxt()
        {
            string loginTxt = @"login.txt";

            try
            {
                if (!File.Exists(loginTxt))
                {
                    using (FileStream fs = File.Create(loginTxt)) { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong :{ex}");
            }


            using (StreamWriter sw = new StreamWriter(loginTxt))
            {
                sw.Write("admin,12345");
                sw.Dispose();

            }
        }


        ///<summary>
        ///Admin login validation, provides access to the main form to add students.
        /// </summary>
        public static void ValidateAdmin(string username, string password)
        {
            string[] login;
            DataBaseForm dbForm = new DataBaseForm();

            string loginLocation = @"login.txt";

            using (StreamReader SR = new StreamReader(loginLocation))
            {
                login = SR.ReadLine().Split(",");
            }

            if (username == login[0] && password == login[1])
            {
                dbForm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Details");
                throw new Exception("Login Failed");
            }
        }

    }
}
