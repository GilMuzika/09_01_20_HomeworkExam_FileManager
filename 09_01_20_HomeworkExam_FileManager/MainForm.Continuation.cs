using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_01_20_HomeworkExam_FileManager
{
    partial class MainForm
    {
        private Random _rnd = new Random();
        private string[] namesToUsing;
        private string[] coursesToUsing;
        private void ReadFromFile()
        {
            string names = string.Empty;
            string courses = string.Empty;
            try
            {
                names = File.ReadAllText("_names.txt");
                courses = File.ReadAllText("_courses.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} \n\nSo the program will use the defult names and courses");
                names = " Alfred Benny Connnor Daniel Eran ";
                courses = " Biology Phisycs Medicine Psycology ";
            }
            namesToUsing = names.Split(new char[] { ' ', '\t', '\n' }).Where(x => !String.IsNullOrEmpty(x)).ToArray();
            coursesToUsing = courses.Split(new char[] { '\n' }).Where(x => !String.IsNullOrEmpty(x)).ToArray();
        }
        private void InitializeSomeControls()
        {
            tbcTabControl.Width = this.ClientRectangle.Width;
            tbcTabControl.Height = this.ClientRectangle.Height;
            tbcTabControl.Location = new System.Drawing.Point(0, 0);
            lblShowCourse.Text = "Course details would appear here";
            lblShowStudent.Text = "Student details would appear here";
            this.ClientSizeChanged += (object sender, EventArgs e) =>
            {
                tbcTabControl.Width = this.ClientRectangle.Width;
                tbcTabControl.Height = this.ClientRectangle.Height;
            };

            lblGradeAddingError.Text = string.Empty;
            lblShowStatisticsTab2.Text = string.Empty;

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(cmbAllCourses2, "Please select a course and see its statistics");

            for(int i = 0; i < tbcTabControl.TabPages.Count; i++)
            {
                if(i < 3) tbcTabControl.TabPages[i].Text = "Databases";
                else tbcTabControl.TabPages[i].Text = "Object Oriented";
            }
            lblWordFileInfo.Text += Environment.NewLine + Environment.NewLine;
            pnlWordFileInfo.AutoSize = true;

        }
        private void ResetCourse()
        {
            txtCourseName.Text = coursesToUsing[_rnd.Next(coursesToUsing.Length - 1)];
            numCourseHours.Value = _rnd.Next((int)numCourseHours.Minimum, (int)numCourseHours.Maximum);
            numCourseAvgGrade.Value = _rnd.Next((int)numCourseAvgGrade.Minimum, (int)numCourseAvgGrade.Maximum);
            numCourseNumStudents.Value = _rnd.Next((int)numCourseNumStudents.Minimum, (int)numCourseNumStudents.Maximum);
            numCourseHighestGrade.Value = _rnd.Next((int)numCourseHighestGrade.Minimum, (int)numCourseHighestGrade.Maximum);
        }
        private void ResetStudent()
        {
            txtStudentFirstName.Text = namesToUsing[_rnd.Next(namesToUsing.Length - 1)];
            txtStudentLastName.Text = namesToUsing[_rnd.Next(namesToUsing.Length - 1)] + "son";
            txtStudentAddress.Text = $"{Statics.GetUniqueKeyOriginal_BIASED(_rnd.Next(5, 10)).ToLower().FirstLetterToupper()} st, {_rnd.Next(1, 100)}/{_rnd.Next(1, 100)}";
            numStudentAge.Value = _rnd.Next((int)numStudentAge.Minimum, (int)numStudentAge.Maximum);
        }
        private void ResetCombos()
        {
            var allCourses = currentDAO.GetAllCourses().Select(x => new ComboItem<Course>(x)).ToArray();
            cmbAllTheCourses.Items.AddRange(allCourses);
            cmbAllTheCourses.Text = "All the courses, please choose one";
            var allStudents = currentDAO.GetAllStudents().Select(x => new ComboItem<Student>(x)).ToArray();
            cmbAllTheStudents.Items.AddRange(allStudents);
            cmbAllTheStudents.Text = "All the students, please choose one";
            cmbAllCourses2.Items.AddRange(allCourses);            
            cmbAllCourses2.Text = "Chose course";
            cmbAllStudents2.Items.AddRange(allStudents);            
            cmbAllStudents2.Text = "Chose student";            
        }
        private void ResetGrades()
        {
            if (cmbAllCourses2.Items.Count > 0) cmbAllCourses2.SelectedIndex = _rnd.Next(cmbAllCourses2.Items.Count - 1);
            if (cmbAllStudents2.Items.Count > 0) cmbAllStudents2.SelectedIndex = _rnd.Next(cmbAllStudents2.Items.Count - 1);
            numGrade.Value = _rnd.Next((int)numGrade.Minimum, (int)numGrade.Maximum);
        }
        private void InitializeStoredSQLCodeButtons()
        {
            Dictionary<string, string> descriptionQueryPair = new Dictionary<string, string>();
            string[] fileQueriestext = File.ReadAllLines($"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\stored_SQL_queries.txt", Encoding.Default);
            for (int i = 0; i < fileQueriestext.Length - 1; i+=2)
                descriptionQueryPair.Add(fileQueriestext[i], fileQueriestext[i + 1]);

            int count = 0;
            int locationX = 10; int locationY = 15;
            List<Button> buttons = new List<Button>();
            foreach(KeyValuePair<string, string> s in descriptionQueryPair)
            {
                Button butt = new Button();
                butt.Name = "procedure_buttton_" + count;
                butt.Text = s.Key;
                butt.Click += (object sender, EventArgs e) => 
                    {
                        CheckDictionary( currentDAO.ExecuteAlekStoredProsedure(s.Value)); 
                    };
                butt.Location = new System.Drawing.Point(locationX, locationY);
                butt.AutoSize = true;
                count++;
                locationY += butt.Height + 5;
                tbcTabControl.TabPages[2].Controls.Add(butt);
            }

        }

        private static void CheckDictionary(Dictionary<string, Object> descriptionQueryPair)
        {
            string str = string.Empty;
            foreach (KeyValuePair<string, Object> s in descriptionQueryPair)
            {
                str += $"{s.Key}: {s.Value}\n";
            }
            FlexibleMessageBox.Show(str);
        }
    }
}
