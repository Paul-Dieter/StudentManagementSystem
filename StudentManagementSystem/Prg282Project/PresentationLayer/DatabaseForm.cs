using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Prg282Project.DataLayer;
using Prg282Project.BusinessLogicLayer;


namespace Prg282Project
{
    public partial class DataBaseForm : Form
	{
		public BindingSource bs = new BindingSource();
		List<Student> students = new List<Student>();
		DataHandler dh = new DataHandler();
		FileHandler fh = new FileHandler();
		int indexRow;

		public DataBaseForm()
		{
			InitializeComponent();

			this.ControlBox = false; // Removes top exit, minimize and maximize
			this.StartPosition = FormStartPosition.CenterScreen; // centres form

		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void StudentEntryForm_Load(object sender, EventArgs e)
		{
			students = fh.CreateStudentTextFile(); //Creates or reads data from students.txt
			bs.DataSource = students;
			dgvDisplay.DataSource = bs; // Displays data to data grid view
		}

		private void GenerateSummaryButton_Click(object sender, EventArgs e)
		{
			//Resets Count.
			dh.ResetCounters();

			//Calculates count
			dh.AmountOfStudents();
			dh.AverageStudentAge();

			//Generate Count in summary
			fh.GenerateSummary(dh);

			AverageAgeTextBox.Text = dh.averageStudentsAge.ToString();
			StudentsInListTextBox.Text = dh.totalStudents.ToString();
		}

		/// <summary>
		/// Adds new students to the student.txt file from the textboxes on the form.
		/// Validates all input fields and ensures correct data format.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddStudentButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidTextBoxes() && !IDFound(int.Parse(txtStudentID.Text)))
				{
					Student student = new Student(int.Parse(txtStudentID.Text), txtStudentName.Text, int.Parse(txtAge.Text), txtCourse.Text);
					students.Add(student);

					// Updates student list displayed
					fh.WriteStudentsToFile(students);
					students = fh.ReadStudentTextFile();

					//Resets Data grid view display
					dgvDisplay.DataSource = "";
					bs.DataSource = students;
					dgvDisplay.DataSource = bs;

					// Resets student data textboxes
					txtStudentID.Text = null;
					txtStudentName.Text = "";
					txtAge.Text = null;
					txtCourse.Text = "";
				}
				else
				{
					MessageBox.Show("ID already in use. Please enter unique ID");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
			}
		}

		/// <summary>
		/// Captures student id
		/// Removes student from data grid
		/// id is utilized to "delete" student from text file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeleteStudentDetailsButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidTextBoxes())
				{
					string id = txtStudentID.Text;

					if (IDFound(int.Parse(id)))
					{
						//Removes selected row from data grid
						int indexRow = dgvDisplay.CurrentCell.RowIndex;
						dgvDisplay.Rows.RemoveAt(indexRow);

						fh.DeleteStudentInfo(id);
					}
					else
					{
						MessageBox.Show("ID Does Not Exist. Please enter existing ID");
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
			}
		}

		/// <summary>
		/// Selects student by clicking on their row
		/// Fills correlating text boxes with students info
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			indexRow = e.RowIndex;
			DataGridViewRow row = dgvDisplay.Rows[indexRow];

			try
			{
				//Goes through each cell in selected row, if any are null, shows error message
				for (int i = 0; i < row.Cells.Count; i++)
				{
					if (row.Cells[i].Value == null)
					{
						MessageBox.Show("Please select a valid row.");
						return;
					}
				}

				//Sets text boxes values to cell values of data grid
				txtStudentID.Text = row.Cells[0].Value.ToString();
				txtStudentName.Text = row.Cells[1].Value.ToString(); ;
				txtAge.Text = row.Cells[2].Value.ToString();
				txtCourse.Text = row.Cells[3].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
			}
		}

		/// <summary>
		/// Based on selected id, replaces the students info using the text box values
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void UpdateStudentButton_Click(object sender, EventArgs e)
		{
			if (ValidTextBoxes())
			{
				int id = int.Parse(txtStudentID.Text);
				string name = txtStudentName.Text;
				int age = int.Parse(txtAge.Text);
				string course = txtCourse.Text;

				if (IDFound(id))
				{
					//Searches for student via id and changes information based on changes to the text boxes
					foreach (Student student in students)
					{
						if (student.StudentID == id)
						{
							student.StudentName = name;
							student.StudentAge = age;
							student.Course = course;
							break; //Breaks out once student is found and info has been changed
						}
					}

					//Updates the Data grid with new information
					bs.DataSource = students;
					dgvDisplay.DataSource = bs;
					dgvDisplay.Refresh();

					//Sends to WriteStudentsToFile method to override the text file with updated information
					fh.WriteStudentsToFile(students);
				}
				else
				{
					MessageBox.Show("ID Does Not Exist. Please enter existing ID");
				}
			}
		}

		/// <summary>
		/// Check if any fields are empty
		/// </summary>
		/// <returns></returns>
		private bool ValidTextBoxes()
		{
			if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtStudentName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtCourse.Text))
			{
				MessageBox.Show("All fields must be filled.");
				return false;
			}

			if (txtStudentID.Text.Length != 6) //Validates ID length
			{
				MessageBox.Show("Student ID must be a 6-digit number.");
				return false;
			}

			int age;
			bool isNumber = int.TryParse(txtAge.Text, out age); // Validates age data type
			if (!isNumber)
			{
				MessageBox.Show("Please enter a valid numeric age.");
				return false;
			}

			if (int.Parse(txtAge.Text) <= 0) // Validates age is greater than 0
			{
				MessageBox.Show("Please enter a valid age greater than zero.");
				return false;
			}

			return true;
		}

		/// <summary>
		/// Check if ID already exists
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		private bool IDFound(int id)
		{
			foreach (Student student in students)
			{
				if (student.StudentID == id)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Opens text file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ViewStudentsButton_Click(object sender, EventArgs e)
		{
			fh.OpenFile();
		}
	}
}