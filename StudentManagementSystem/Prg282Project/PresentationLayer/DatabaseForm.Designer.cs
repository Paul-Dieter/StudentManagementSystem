using System.Windows.Forms;

namespace Prg282Project
{
    partial class DataBaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label Newtudent;
            Label label1;
            Label UpdateStudents;
            Label DeleteStudent;
            Label label2;
            Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseForm));
            dgvDisplay = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            AddStudentButton = new Button();
            ViewStudentsButton = new Button();
            UpdateStudentButton = new Button();
            DeleteStudentDetailsButton = new Button();
            GenerateSummaryButton = new Button();
            NameLabel = new Label();
            SurnameLabel = new Label();
            AgeLabel = new Label();
            IDLabel = new Label();
            groupBox1 = new GroupBox();
            StudentsInListTextBox = new TextBox();
            AverageAgeTextBox = new TextBox();
            txtCourse = new TextBox();
            txtAge = new TextBox();
            txtStudentName = new TextBox();
            txtStudentID = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ExitButton = new Button();
            pictureBox2 = new PictureBox();
            Newtudent = new Label();
            label1 = new Label();
            UpdateStudents = new Label();
            DeleteStudent = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Newtudent
            // 
            Newtudent.AutoEllipsis = true;
            Newtudent.AutoSize = true;
            Newtudent.Location = new Point(64, 149);
            Newtudent.Name = "Newtudent";
            Newtudent.Size = new Size(0, 15);
            Newtudent.TabIndex = 2;
            Newtudent.Tag = "";
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Location = new Point(212, 149);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            label1.Tag = "";
            // 
            // UpdateStudents
            // 
            UpdateStudents.AutoEllipsis = true;
            UpdateStudents.AutoSize = true;
            UpdateStudents.Location = new Point(328, 149);
            UpdateStudents.Name = "UpdateStudents";
            UpdateStudents.Size = new Size(0, 15);
            UpdateStudents.TabIndex = 6;
            UpdateStudents.Tag = "";
            // 
            // DeleteStudent
            // 
            DeleteStudent.AutoEllipsis = true;
            DeleteStudent.AutoSize = true;
            DeleteStudent.Location = new Point(431, 149);
            DeleteStudent.Name = "DeleteStudent";
            DeleteStudent.Size = new Size(0, 15);
            DeleteStudent.TabIndex = 8;
            DeleteStudent.Tag = "";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Location = new Point(481, 42);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 31;
            label2.Tag = "";
            label2.Text = "Average Age";
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Location = new Point(572, 42);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 32;
            label3.Tag = "";
            label3.Text = "Students in List";
            // 
            // dgvDisplay
            // 
            dgvDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDisplay.BackgroundColor = SystemColors.ButtonShadow;
            dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplay.Location = new Point(12, 98);
            dgvDisplay.Name = "dgvDisplay";
            dgvDisplay.RowTemplate.Height = 25;
            dgvDisplay.Size = new Size(993, 274);
            dgvDisplay.TabIndex = 0;
            dgvDisplay.CellClick += dgvDisplay_CellClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AddStudentButton
            // 
            AddStudentButton.BackColor = Color.White;
            AddStudentButton.ForeColor = SystemColors.ActiveCaptionText;
            AddStudentButton.Location = new Point(24, 98);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(100, 23);
            AddStudentButton.TabIndex = 1;
            AddStudentButton.Text = "Add";
            AddStudentButton.UseVisualStyleBackColor = false;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // ViewStudentsButton
            // 
            ViewStudentsButton.BackColor = Color.White;
            ViewStudentsButton.ForeColor = SystemColors.ActiveCaptionText;
            ViewStudentsButton.Location = new Point(130, 98);
            ViewStudentsButton.Name = "ViewStudentsButton";
            ViewStudentsButton.Size = new Size(101, 23);
            ViewStudentsButton.TabIndex = 3;
            ViewStudentsButton.Text = "View";
            ViewStudentsButton.UseVisualStyleBackColor = false;
            ViewStudentsButton.Click += ViewStudentsButton_Click;
            // 
            // UpdateStudentButton
            // 
            UpdateStudentButton.BackColor = Color.White;
            UpdateStudentButton.ForeColor = SystemColors.ActiveCaptionText;
            UpdateStudentButton.Location = new Point(237, 98);
            UpdateStudentButton.Name = "UpdateStudentButton";
            UpdateStudentButton.Size = new Size(100, 23);
            UpdateStudentButton.TabIndex = 5;
            UpdateStudentButton.Text = "Update";
            UpdateStudentButton.UseVisualStyleBackColor = false;
            UpdateStudentButton.Click += UpdateStudentButton_Click;
            // 
            // DeleteStudentDetailsButton
            // 
            DeleteStudentDetailsButton.BackColor = Color.White;
            DeleteStudentDetailsButton.ForeColor = Color.Black;
            DeleteStudentDetailsButton.Location = new Point(343, 98);
            DeleteStudentDetailsButton.Name = "DeleteStudentDetailsButton";
            DeleteStudentDetailsButton.Size = new Size(100, 23);
            DeleteStudentDetailsButton.TabIndex = 7;
            DeleteStudentDetailsButton.Text = "Delete";
            DeleteStudentDetailsButton.UseVisualStyleBackColor = false;
            DeleteStudentDetailsButton.Click += DeleteStudentDetailsButton_Click;
            // 
            // GenerateSummaryButton
            // 
            GenerateSummaryButton.BackColor = Color.White;
            GenerateSummaryButton.ForeColor = SystemColors.ActiveCaptionText;
            GenerateSummaryButton.Location = new Point(517, 98);
            GenerateSummaryButton.Name = "GenerateSummaryButton";
            GenerateSummaryButton.Size = new Size(102, 23);
            GenerateSummaryButton.TabIndex = 9;
            GenerateSummaryButton.Text = "Generate";
            GenerateSummaryButton.UseVisualStyleBackColor = false;
            GenerateSummaryButton.Click += GenerateSummaryButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.ForeColor = SystemColors.ButtonFace;
            NameLabel.Location = new Point(131, 42);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 16;
            NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(343, 42);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(44, 15);
            SurnameLabel.TabIndex = 17;
            SurnameLabel.Text = "Course";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(237, 42);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(28, 15);
            AgeLabel.TabIndex = 18;
            AgeLabel.Text = "Age";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(24, 42);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(18, 15);
            IDLabel.TabIndex = 19;
            IDLabel.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(StudentsInListTextBox);
            groupBox1.Controls.Add(AverageAgeTextBox);
            groupBox1.Controls.Add(txtCourse);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtStudentName);
            groupBox1.Controls.Add(txtStudentID);
            groupBox1.Controls.Add(IDLabel);
            groupBox1.Controls.Add(AgeLabel);
            groupBox1.Controls.Add(SurnameLabel);
            groupBox1.Controls.Add(NameLabel);
            groupBox1.Controls.Add(GenerateSummaryButton);
            groupBox1.Controls.Add(DeleteStudent);
            groupBox1.Controls.Add(DeleteStudentDetailsButton);
            groupBox1.Controls.Add(UpdateStudents);
            groupBox1.Controls.Add(UpdateStudentButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ViewStudentsButton);
            groupBox1.Controls.Add(Newtudent);
            groupBox1.Controls.Add(AddStudentButton);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Cursor = Cursors.Hand;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 378);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1020, 149);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Data";
            // 
            // StudentsInListTextBox
            // 
            StudentsInListTextBox.Cursor = Cursors.IBeam;
            StudentsInListTextBox.Location = new Point(572, 69);
            StudentsInListTextBox.Name = "StudentsInListTextBox";
            StudentsInListTextBox.Size = new Size(100, 23);
            StudentsInListTextBox.TabIndex = 30;
            // 
            // AverageAgeTextBox
            // 
            AverageAgeTextBox.Cursor = Cursors.IBeam;
            AverageAgeTextBox.Location = new Point(466, 69);
            AverageAgeTextBox.Name = "AverageAgeTextBox";
            AverageAgeTextBox.Size = new Size(100, 23);
            AverageAgeTextBox.TabIndex = 29;
            // 
            // txtCourse
            // 
            txtCourse.Cursor = Cursors.IBeam;
            txtCourse.Location = new Point(343, 69);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(100, 23);
            txtCourse.TabIndex = 23;
            // 
            // txtAge
            // 
            txtAge.Cursor = Cursors.IBeam;
            txtAge.Location = new Point(237, 69);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 22;
            // 
            // txtStudentName
            // 
            txtStudentName.Cursor = Cursors.IBeam;
            txtStudentName.Location = new Point(131, 69);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(100, 23);
            txtStudentName.TabIndex = 21;
            // 
            // txtStudentID
            // 
            txtStudentID.Cursor = Cursors.IBeam;
            txtStudentID.Location = new Point(24, 69);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(100, 23);
            txtStudentID.TabIndex = 20;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(678, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(336, 188);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-438, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.White;
            ExitButton.BackgroundImage = (Image)resources.GetObject("ExitButton.BackgroundImage");
            ExitButton.BackgroundImageLayout = ImageLayout.Stretch;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Location = new Point(978, 32);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(27, 25);
            ExitButton.TabIndex = 29;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-24, -25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // DataBaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1044, 539);
            Controls.Add(ExitButton);
            Controls.Add(pictureBox1);
            Controls.Add(dgvDisplay);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DataBaseForm";
            Text = "Student Entry Form";
            Load += StudentEntryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDisplay;
        private ContextMenuStrip contextMenuStrip1;
        private Button AddStudentButton;
        private Button ViewStudentsButton;
        private Button UpdateStudentButton;
        private Button DeleteStudentDetailsButton;
        private Button GenerateSummaryButton;
        private Label NameLabel;
        private Label SurnameLabel;
        private Label AgeLabel;
        private Label IDLabel;
        protected GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox txtCourse;
        private TextBox txtAge;
        private TextBox txtStudentName;
        private TextBox txtStudentID;
        private Button ExitButton;
        private PictureBox pictureBox2;
        private TextBox StudentsInListTextBox;
        public TextBox AverageAgeTextBox;
    }
}