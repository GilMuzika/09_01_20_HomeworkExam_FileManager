using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_01_20_HomeworkExam_FileManager
{
    public partial class MainForm : Form
    {        
        private DAO currentDAO = new DAO();
        public MainForm()
        {
            InitializeComponent();
            ReadFromFile();
            InitializeSomeControls();
            ResetCourse();
            ResetStudent();
            ResetCombos();
            ResetGrades();
            InitializeStoredSQLCodeButtons();
        }

        private void btnAddNewCourse_Click(object sender, EventArgs e)
        {
            Course course = new Course(txtCourseName.Text, (int)numCourseHours.Value, numCourseAvgGrade.Value, (int)numCourseNumStudents.Value, (int)numCourseHighestGrade.Value);
            currentDAO.InsertValueToTable(course);
            cmbAllTheCourses.Items.Add(new ComboItem<Course>(course));
            cmbAllCourses2.Items.Add(new ComboItem<Course>(course));

            ResetCourse();
        }

        string str = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            (sender as Button).AutoSize = true;
            (sender as Button).Text = currentDAO.IsConnectionEstablished(out string connStr) +"\n";
            (sender as Button).Text += connStr;
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtStudentFirstName.Text, txtStudentLastName.Text, txtStudentAddress.Text, (int)numStudentAge.Value);            
            currentDAO.InsertValueToTable(student);
            cmbAllTheStudents.Items.Add(new ComboItem<Student>(student));
            cmbAllStudents2.Items.Add(new ComboItem<Student>(student));

            ResetStudent();
        }

        private void cmbAllTheCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblShowCourse.Text = ((sender as ComboBox).SelectedItem as ComboItem<Course>).Item.ToString();
        }

        private void cmbAllTheStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblShowStudent.Text = ((sender as ComboBox).SelectedItem as ComboItem<Student>).Item.ToString();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            Course course = null;
            try
            {
                course = (cmbAllTheCourses.SelectedItem as ComboItem<Course>).Item;
                currentDAO.DeleteOne<Course>(course);
                foreach (ComboItem<Course> s in cmbAllTheCourses.Items)
                    if (s.Item.EXTERNAL_ID.Equals(course.EXTERNAL_ID)) { cmbAllTheCourses.Items.Remove(s); break; }
                foreach (ComboItem<Course> s in cmbAllCourses2.Items)
                    if (s.Item.EXTERNAL_ID.Equals(course.EXTERNAL_ID)) { cmbAllCourses2.Items.Remove(s); break; }

                lblShowCourse.Text = string.Empty;
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException) FlexibleMessageBox.Show("Please select a course");
                else FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            Student student = null;
            try
            {
                student = (cmbAllTheStudents.SelectedItem as ComboItem<Student>).Item;
                currentDAO.DeleteOne<Student>(student);
                foreach (ComboItem<Student> s in cmbAllTheStudents.Items)
                    if (s.Item.EXTERNAL_ID.Equals(student.EXTERNAL_ID)) { cmbAllTheStudents.Items.Remove(s); break; }
                foreach (ComboItem<Student> s in cmbAllStudents2.Items)
                    if (s.Item.EXTERNAL_ID.Equals(student.EXTERNAL_ID)) { cmbAllStudents2.Items.Remove(s); break; }

                lblShowStudent.Text = string.Empty;
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException) FlexibleMessageBox.Show("Please select a student");
                else FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }

        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            try
            {
                currentDAO.AddGrade((cmbAllStudents2.SelectedItem as ComboItem<Student>).Item, (cmbAllCourses2.SelectedItem as ComboItem<Course>).Item, (int)numGrade.Value);
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException) FlexibleMessageBox.Show("Please select a course");
                else if (ex is SQLiteException && ex.Message.Contains("UNIQUE constraint failed")) { lblGradeAddingError.Text = $"The student {(cmbAllStudents2.SelectedItem as ComboItem<Student>).Item.FIRST_NAME} {(cmbAllStudents2.SelectedItem as ComboItem<Student>).Item.LAST_NAME} alrady has a grade\n in the course {(cmbAllCourses2.SelectedItem as ComboItem<Course>).Item.NAME}"; }
                //
                else FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            ResetGrades();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            currentDAO.DeleteAllWithDBNull(typeof(Course), typeof(Student));
        }

        private void cmbAllCourses2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course currentCourse = ((sender as ComboBox).SelectedItem as ComboItem<Course>).Item;
            lblShowStatisticsTab2.Text = $"Statistics of the course \n{currentCourse.NAME}\n\n";
            Dictionary<string, int> statistics = currentDAO.ShowCourseStatistics(currentCourse);
            foreach (KeyValuePair<string, int> s in statistics)
            {
                lblShowStatisticsTab2.Text += $"{s.Key}: {s.Value}\n";
            }
        }

        private void btnCreateWordFile_Click(object sender, EventArgs e)
        {
            WordFile wordFile = null;
            try
            {
                wordFile = new WordFile(Statics.GetUniqueKeyOriginal_BIASED(_rnd.Next(10, 20)), $"{Directory.GetCurrentDirectory()}\\{Statics.GetUniqueKeyOriginal_BIASED(5)}.wordFile", _rnd.Next(-5, 5), false, false);
                lblWordFileInfo.Text += wordFile.PrintFile() + "\n";
            }
            catch(InfectedFileDetectedException ex)
            {
                lblWordFileInfo.Text += ex.Message + "\n";
            }

            
        }

        private void btnCreateImageFile_Click(object sender, EventArgs e)
        {
            ImageFile<int> imageFile = null;
            try
            {
                int[,] fileColors = new int[_rnd.Next(30,80),_rnd.Next(30,80)];
                pcbDisplayImageFile.Width = fileColors.GetLength(0);
                pcbDisplayImageFile.Height = fileColors.GetLength(1);
                string filePath = $"{Directory.GetCurrentDirectory()}\\{Statics.GetUniqueKeyOriginal_BIASED(5)}.imageFile";
                imageFile = new ImageFile<int>(fileColors, filePath, _rnd.Next(-5, 5), true, false);
                pcbDisplayImageFile.Image = imageFile.PrintFile() as Bitmap;
            }
            catch
            {
                
            }


        }
    }
}
