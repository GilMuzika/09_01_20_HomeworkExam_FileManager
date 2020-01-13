using System;
using System.Windows.Forms;

namespace _09_01_20_HomeworkExam_FileManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.lblShowStudent = new System.Windows.Forms.Label();
            this.cmbAllTheStudents = new System.Windows.Forms.ComboBox();
            this.lblShowCourse = new System.Windows.Forms.Label();
            this.cmbAllTheCourses = new System.Windows.Forms.ComboBox();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.numStudentAge = new System.Windows.Forms.NumericUpDown();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.lblStudentAge = new System.Windows.Forms.Label();
            this.lblStudentAddress = new System.Windows.Forms.Label();
            this.lblStudentLastName = new System.Windows.Forms.Label();
            this.lblStudentFirstName = new System.Windows.Forms.Label();
            this.btnAddNewCourse = new System.Windows.Forms.Button();
            this.numCourseHighestGrade = new System.Windows.Forms.NumericUpDown();
            this.numCourseNumStudents = new System.Windows.Forms.NumericUpDown();
            this.numCourseAvgGrade = new System.Windows.Forms.NumericUpDown();
            this.numCourseHours = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfStudents = new System.Windows.Forms.Label();
            this.lblAvgGrade = new System.Windows.Forms.Label();
            this.lblCourseHours = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblHighestGrade = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblGradeAddingError = new System.Windows.Forms.Label();
            this.btnDeleteAllWithZeroValues = new System.Windows.Forms.Button();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numGrade = new System.Windows.Forms.NumericUpDown();
            this.cmbAllStudents2 = new System.Windows.Forms.ComboBox();
            this.cmbAllCourses2 = new System.Windows.Forms.ComboBox();
            this.lblShowStatisticsTab2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCreateWordFile = new System.Windows.Forms.Button();
            this.pnlWordFileInfo = new _09_01_20_HomeworkExam_FileManager.ScrollablePanel();
            this.lblWordFileInfo = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnCreateImageFile = new System.Windows.Forms.Button();
            this.pcbDisplayImageFile = new System.Windows.Forms.PictureBox();
            this.tbcTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStudentAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCourseHighestGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCourseNumStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCourseAvgGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCourseHours)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGrade)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.pnlWordFileInfo.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDisplayImageFile)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcTabControl
            // 
            this.tbcTabControl.Controls.Add(this.tabPage1);
            this.tbcTabControl.Controls.Add(this.tabPage2);
            this.tbcTabControl.Controls.Add(this.tabPage3);
            this.tbcTabControl.Controls.Add(this.tabPage4);
            this.tbcTabControl.Controls.Add(this.tabPage5);
            this.tbcTabControl.Location = new System.Drawing.Point(1, 2);
            this.tbcTabControl.Name = "tbcTabControl";
            this.tbcTabControl.SelectedIndex = 0;
            this.tbcTabControl.Size = new System.Drawing.Size(803, 447);
            this.tbcTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeleteStudent);
            this.tabPage1.Controls.Add(this.btnDeleteCourse);
            this.tabPage1.Controls.Add(this.lblShowStudent);
            this.tabPage1.Controls.Add(this.cmbAllTheStudents);
            this.tabPage1.Controls.Add(this.lblShowCourse);
            this.tabPage1.Controls.Add(this.cmbAllTheCourses);
            this.tabPage1.Controls.Add(this.btnAddNewStudent);
            this.tabPage1.Controls.Add(this.numStudentAge);
            this.tabPage1.Controls.Add(this.txtStudentAddress);
            this.tabPage1.Controls.Add(this.txtStudentLastName);
            this.tabPage1.Controls.Add(this.txtStudentFirstName);
            this.tabPage1.Controls.Add(this.lblStudentAge);
            this.tabPage1.Controls.Add(this.lblStudentAddress);
            this.tabPage1.Controls.Add(this.lblStudentLastName);
            this.tabPage1.Controls.Add(this.lblStudentFirstName);
            this.tabPage1.Controls.Add(this.btnAddNewCourse);
            this.tabPage1.Controls.Add(this.numCourseHighestGrade);
            this.tabPage1.Controls.Add(this.numCourseNumStudents);
            this.tabPage1.Controls.Add(this.numCourseAvgGrade);
            this.tabPage1.Controls.Add(this.numCourseHours);
            this.tabPage1.Controls.Add(this.lblNumberOfStudents);
            this.tabPage1.Controls.Add(this.lblAvgGrade);
            this.tabPage1.Controls.Add(this.lblCourseHours);
            this.tabPage1.Controls.Add(this.txtCourseName);
            this.tabPage1.Controls.Add(this.lblCourseName);
            this.tabPage1.Controls.Add(this.lblHighestGrade);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(402, 379);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteStudent.TabIndex = 26;
            this.btnDeleteStudent.Text = "Delete student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(14, 379);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteCourse.TabIndex = 25;
            this.btnDeleteCourse.Text = "Delete course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // lblShowStudent
            // 
            this.lblShowStudent.AutoSize = true;
            this.lblShowStudent.Location = new System.Drawing.Point(399, 286);
            this.lblShowStudent.Name = "lblShowStudent";
            this.lblShowStudent.Size = new System.Drawing.Size(35, 13);
            this.lblShowStudent.TabIndex = 24;
            this.lblShowStudent.Text = "label1";
            // 
            // cmbAllTheStudents
            // 
            this.cmbAllTheStudents.FormattingEnabled = true;
            this.cmbAllTheStudents.Location = new System.Drawing.Point(399, 249);
            this.cmbAllTheStudents.Name = "cmbAllTheStudents";
            this.cmbAllTheStudents.Size = new System.Drawing.Size(209, 21);
            this.cmbAllTheStudents.TabIndex = 23;
            this.cmbAllTheStudents.SelectedIndexChanged += new System.EventHandler(this.cmbAllTheStudents_SelectedIndexChanged);
            // 
            // lblShowCourse
            // 
            this.lblShowCourse.AutoSize = true;
            this.lblShowCourse.Location = new System.Drawing.Point(10, 286);
            this.lblShowCourse.Name = "lblShowCourse";
            this.lblShowCourse.Size = new System.Drawing.Size(35, 13);
            this.lblShowCourse.TabIndex = 22;
            this.lblShowCourse.Text = "label1";
            // 
            // cmbAllTheCourses
            // 
            this.cmbAllTheCourses.FormattingEnabled = true;
            this.cmbAllTheCourses.Location = new System.Drawing.Point(10, 249);
            this.cmbAllTheCourses.Name = "cmbAllTheCourses";
            this.cmbAllTheCourses.Size = new System.Drawing.Size(212, 21);
            this.cmbAllTheCourses.TabIndex = 21;
            this.cmbAllTheCourses.SelectedIndexChanged += new System.EventHandler(this.cmbAllTheCourses_SelectedIndexChanged);
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.Location = new System.Drawing.Point(399, 178);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(112, 23);
            this.btnAddNewStudent.TabIndex = 20;
            this.btnAddNewStudent.Text = "Add a new student";
            this.btnAddNewStudent.UseVisualStyleBackColor = true;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // numStudentAge
            // 
            this.numStudentAge.Location = new System.Drawing.Point(579, 107);
            this.numStudentAge.Minimum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numStudentAge.Name = "numStudentAge";
            this.numStudentAge.Size = new System.Drawing.Size(59, 20);
            this.numStudentAge.TabIndex = 19;
            this.numStudentAge.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Location = new System.Drawing.Point(492, 71);
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(147, 20);
            this.txtStudentAddress.TabIndex = 18;
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Location = new System.Drawing.Point(492, 43);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(147, 20);
            this.txtStudentLastName.TabIndex = 17;
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Location = new System.Drawing.Point(492, 9);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(147, 20);
            this.txtStudentFirstName.TabIndex = 16;
            // 
            // lblStudentAge
            // 
            this.lblStudentAge.AutoSize = true;
            this.lblStudentAge.Location = new System.Drawing.Point(396, 107);
            this.lblStudentAge.Name = "lblStudentAge";
            this.lblStudentAge.Size = new System.Drawing.Size(29, 13);
            this.lblStudentAge.TabIndex = 15;
            this.lblStudentAge.Text = "Age:";
            // 
            // lblStudentAddress
            // 
            this.lblStudentAddress.AutoSize = true;
            this.lblStudentAddress.Location = new System.Drawing.Point(396, 74);
            this.lblStudentAddress.Name = "lblStudentAddress";
            this.lblStudentAddress.Size = new System.Drawing.Size(48, 13);
            this.lblStudentAddress.TabIndex = 14;
            this.lblStudentAddress.Text = "Address:";
            // 
            // lblStudentLastName
            // 
            this.lblStudentLastName.AutoSize = true;
            this.lblStudentLastName.Location = new System.Drawing.Point(396, 46);
            this.lblStudentLastName.Name = "lblStudentLastName";
            this.lblStudentLastName.Size = new System.Drawing.Size(61, 13);
            this.lblStudentLastName.TabIndex = 13;
            this.lblStudentLastName.Text = "Last Name:";
            // 
            // lblStudentFirstName
            // 
            this.lblStudentFirstName.AutoSize = true;
            this.lblStudentFirstName.Location = new System.Drawing.Point(396, 12);
            this.lblStudentFirstName.Name = "lblStudentFirstName";
            this.lblStudentFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblStudentFirstName.TabIndex = 12;
            this.lblStudentFirstName.Text = "First Name:";
            // 
            // btnAddNewCourse
            // 
            this.btnAddNewCourse.Location = new System.Drawing.Point(10, 178);
            this.btnAddNewCourse.Name = "btnAddNewCourse";
            this.btnAddNewCourse.Size = new System.Drawing.Size(112, 23);
            this.btnAddNewCourse.TabIndex = 10;
            this.btnAddNewCourse.Text = "Add a new course";
            this.btnAddNewCourse.UseVisualStyleBackColor = true;
            this.btnAddNewCourse.Click += new System.EventHandler(this.btnAddNewCourse_Click);
            // 
            // numCourseHighestGrade
            // 
            this.numCourseHighestGrade.Location = new System.Drawing.Point(168, 133);
            this.numCourseHighestGrade.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numCourseHighestGrade.Minimum = new decimal(new int[] {
            56,
            0,
            0,
            0});
            this.numCourseHighestGrade.Name = "numCourseHighestGrade";
            this.numCourseHighestGrade.Size = new System.Drawing.Size(54, 20);
            this.numCourseHighestGrade.TabIndex = 9;
            this.numCourseHighestGrade.Value = new decimal(new int[] {
            56,
            0,
            0,
            0});
            // 
            // numCourseNumStudents
            // 
            this.numCourseNumStudents.Location = new System.Drawing.Point(168, 100);
            this.numCourseNumStudents.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numCourseNumStudents.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numCourseNumStudents.Name = "numCourseNumStudents";
            this.numCourseNumStudents.Size = new System.Drawing.Size(54, 20);
            this.numCourseNumStudents.TabIndex = 8;
            this.numCourseNumStudents.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numCourseAvgGrade
            // 
            this.numCourseAvgGrade.Location = new System.Drawing.Point(168, 65);
            this.numCourseAvgGrade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCourseAvgGrade.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCourseAvgGrade.Name = "numCourseAvgGrade";
            this.numCourseAvgGrade.Size = new System.Drawing.Size(54, 20);
            this.numCourseAvgGrade.TabIndex = 7;
            this.numCourseAvgGrade.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numCourseHours
            // 
            this.numCourseHours.Location = new System.Drawing.Point(168, 39);
            this.numCourseHours.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCourseHours.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numCourseHours.Name = "numCourseHours";
            this.numCourseHours.Size = new System.Drawing.Size(54, 20);
            this.numCourseHours.TabIndex = 6;
            this.numCourseHours.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblNumberOfStudents
            // 
            this.lblNumberOfStudents.AutoSize = true;
            this.lblNumberOfStudents.Location = new System.Drawing.Point(7, 107);
            this.lblNumberOfStudents.Name = "lblNumberOfStudents";
            this.lblNumberOfStudents.Size = new System.Drawing.Size(104, 13);
            this.lblNumberOfStudents.TabIndex = 5;
            this.lblNumberOfStudents.Text = "Number of Students:";
            // 
            // lblAvgGrade
            // 
            this.lblAvgGrade.AutoSize = true;
            this.lblAvgGrade.Location = new System.Drawing.Point(7, 74);
            this.lblAvgGrade.Name = "lblAvgGrade";
            this.lblAvgGrade.Size = new System.Drawing.Size(82, 13);
            this.lblAvgGrade.TabIndex = 4;
            this.lblAvgGrade.Text = "Average Grade:";
            // 
            // lblCourseHours
            // 
            this.lblCourseHours.AutoSize = true;
            this.lblCourseHours.Location = new System.Drawing.Point(7, 46);
            this.lblCourseHours.Name = "lblCourseHours";
            this.lblCourseHours.Size = new System.Drawing.Size(72, 13);
            this.lblCourseHours.TabIndex = 3;
            this.lblCourseHours.Text = "Course hours:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(87, 9);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(135, 20);
            this.txtCourseName.TabIndex = 2;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(7, 12);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(74, 13);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblHighestGrade
            // 
            this.lblHighestGrade.AutoSize = true;
            this.lblHighestGrade.Location = new System.Drawing.Point(7, 140);
            this.lblHighestGrade.Name = "lblHighestGrade";
            this.lblHighestGrade.Size = new System.Drawing.Size(78, 13);
            this.lblHighestGrade.TabIndex = 0;
            this.lblHighestGrade.Text = "Highest Grade:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblShowStatisticsTab2);
            this.tabPage2.Controls.Add(this.lblGradeAddingError);
            this.tabPage2.Controls.Add(this.btnDeleteAllWithZeroValues);
            this.tabPage2.Controls.Add(this.btnAddGrade);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.numGrade);
            this.tabPage2.Controls.Add(this.cmbAllStudents2);
            this.tabPage2.Controls.Add(this.cmbAllCourses2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblGradeAddingError
            // 
            this.lblGradeAddingError.AutoSize = true;
            this.lblGradeAddingError.Location = new System.Drawing.Point(3, 131);
            this.lblGradeAddingError.Name = "lblGradeAddingError";
            this.lblGradeAddingError.Size = new System.Drawing.Size(39, 13);
            this.lblGradeAddingError.TabIndex = 6;
            this.lblGradeAddingError.Text = "Label1";
            // 
            // btnDeleteAllWithZeroValues
            // 
            this.btnDeleteAllWithZeroValues.Location = new System.Drawing.Point(6, 155);
            this.btnDeleteAllWithZeroValues.Name = "btnDeleteAllWithZeroValues";
            this.btnDeleteAllWithZeroValues.Size = new System.Drawing.Size(169, 23);
            this.btnDeleteAllWithZeroValues.TabIndex = 5;
            this.btnDeleteAllWithZeroValues.Text = "Delete all with empty values";
            this.btnDeleteAllWithZeroValues.UseVisualStyleBackColor = true;
            this.btnDeleteAllWithZeroValues.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(8, 91);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(75, 23);
            this.btnAddGrade.TabIndex = 4;
            this.btnAddGrade.Text = "Add Grade";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grade:";
            // 
            // numGrade
            // 
            this.numGrade.Location = new System.Drawing.Point(156, 94);
            this.numGrade.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numGrade.Minimum = new decimal(new int[] {
            56,
            0,
            0,
            0});
            this.numGrade.Name = "numGrade";
            this.numGrade.Size = new System.Drawing.Size(60, 20);
            this.numGrade.TabIndex = 2;
            this.numGrade.Value = new decimal(new int[] {
            56,
            0,
            0,
            0});
            // 
            // cmbAllStudents2
            // 
            this.cmbAllStudents2.FormattingEnabled = true;
            this.cmbAllStudents2.Location = new System.Drawing.Point(8, 55);
            this.cmbAllStudents2.Name = "cmbAllStudents2";
            this.cmbAllStudents2.Size = new System.Drawing.Size(209, 21);
            this.cmbAllStudents2.TabIndex = 1;
            // 
            // cmbAllCourses2
            // 
            this.cmbAllCourses2.FormattingEnabled = true;
            this.cmbAllCourses2.Location = new System.Drawing.Point(8, 16);
            this.cmbAllCourses2.Name = "cmbAllCourses2";
            this.cmbAllCourses2.Size = new System.Drawing.Size(209, 21);
            this.cmbAllCourses2.TabIndex = 0;
            this.cmbAllCourses2.SelectedIndexChanged += new System.EventHandler(this.cmbAllCourses2_SelectedIndexChanged);
            // 
            // lblShowStatisticsTab2
            // 
            this.lblShowStatisticsTab2.AutoSize = true;
            this.lblShowStatisticsTab2.Location = new System.Drawing.Point(240, 16);
            this.lblShowStatisticsTab2.Name = "lblShowStatisticsTab2";
            this.lblShowStatisticsTab2.Size = new System.Drawing.Size(35, 13);
            this.lblShowStatisticsTab2.TabIndex = 7;
            this.lblShowStatisticsTab2.Text = "label2";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(795, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pnlWordFileInfo);
            this.tabPage4.Controls.Add(this.btnCreateWordFile);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(795, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCreateWordFile
            // 
            this.btnCreateWordFile.Location = new System.Drawing.Point(27, 33);
            this.btnCreateWordFile.Name = "btnCreateWordFile";
            this.btnCreateWordFile.Size = new System.Drawing.Size(96, 23);
            this.btnCreateWordFile.TabIndex = 0;
            this.btnCreateWordFile.Text = "Create word file";
            this.btnCreateWordFile.UseVisualStyleBackColor = true;
            this.btnCreateWordFile.Click += new System.EventHandler(this.btnCreateWordFile_Click);
            // 
            // pnlWordFileInfo
            // 
            this.pnlWordFileInfo.AutoScroll = true;
            this.pnlWordFileInfo.AutoScrollHorizontalMaximum = 100;
            this.pnlWordFileInfo.AutoScrollHorizontalMinimum = 0;
            this.pnlWordFileInfo.AutoScrollHPos = 0;
            this.pnlWordFileInfo.AutoScrollVerticalMaximum = 100;
            this.pnlWordFileInfo.AutoScrollVerticalMinimum = 0;
            this.pnlWordFileInfo.AutoScrollVPos = 0;
            this.pnlWordFileInfo.Controls.Add(this.lblWordFileInfo);
            this.pnlWordFileInfo.EnableAutoScrollHorizontal = true;
            this.pnlWordFileInfo.EnableAutoScrollVertical = true;
            this.pnlWordFileInfo.Location = new System.Drawing.Point(27, 82);
            this.pnlWordFileInfo.Name = "pnlWordFileInfo";
            this.pnlWordFileInfo.Size = new System.Drawing.Size(233, 312);
            this.pnlWordFileInfo.TabIndex = 1;
            this.pnlWordFileInfo.VisibleAutoScrollHorizontal = true;
            this.pnlWordFileInfo.VisibleAutoScrollVertical = true;
            // 
            // lblWordFileInfo
            // 
            this.lblWordFileInfo.AutoSize = true;
            this.lblWordFileInfo.Location = new System.Drawing.Point(3, 3);
            this.lblWordFileInfo.Name = "lblWordFileInfo";
            this.lblWordFileInfo.Size = new System.Drawing.Size(75, 13);
            this.lblWordFileInfo.TabIndex = 0;
            this.lblWordFileInfo.Text = "WordFile  info:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pcbDisplayImageFile);
            this.tabPage5.Controls.Add(this.btnCreateImageFile);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(795, 421);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnCreateImageFile
            // 
            this.btnCreateImageFile.Location = new System.Drawing.Point(18, 18);
            this.btnCreateImageFile.Name = "btnCreateImageFile";
            this.btnCreateImageFile.Size = new System.Drawing.Size(115, 23);
            this.btnCreateImageFile.TabIndex = 0;
            this.btnCreateImageFile.Text = "Create Image File";
            this.btnCreateImageFile.UseVisualStyleBackColor = true;
            this.btnCreateImageFile.Click += new System.EventHandler(this.btnCreateImageFile_Click);
            // 
            // pcbDisplayImageFile
            // 
            this.pcbDisplayImageFile.Location = new System.Drawing.Point(18, 64);
            this.pcbDisplayImageFile.Name = "pcbDisplayImageFile";
            this.pcbDisplayImageFile.Size = new System.Drawing.Size(265, 251);
            this.pcbDisplayImageFile.TabIndex = 1;
            this.pcbDisplayImageFile.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcTabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tbcTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStudentAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCourseHighestGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCourseNumStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCourseAvgGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCourseHours)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGrade)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.pnlWordFileInfo.ResumeLayout(false);
            this.pnlWordFileInfo.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbDisplayImageFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Label lblHighestGrade;
        private Label lblNumberOfStudents;
        private Label lblAvgGrade;
        private Label lblCourseHours;
        private TextBox txtCourseName;
        private Label lblCourseName;
        private NumericUpDown numCourseHighestGrade;
        private NumericUpDown numCourseNumStudents;
        private NumericUpDown numCourseAvgGrade;
        private NumericUpDown numCourseHours;
        private Button btnAddNewCourse;
        private NumericUpDown numStudentAge;
        private TextBox txtStudentAddress;
        private TextBox txtStudentLastName;
        private TextBox txtStudentFirstName;
        private Label lblStudentAge;
        private Label lblStudentAddress;
        private Label lblStudentLastName;
        private Label lblStudentFirstName;
        private Button btnAddNewStudent;
        private ComboBox cmbAllTheCourses;
        private Label lblShowCourse;
        private Label lblShowStudent;
        private ComboBox cmbAllTheStudents;
        private Button btnDeleteStudent;
        private Button btnDeleteCourse;
        private ComboBox cmbAllStudents2;
        private ComboBox cmbAllCourses2;
        private Button btnAddGrade;
        private Label label1;
        private NumericUpDown numGrade;
        private Button btnDeleteAllWithZeroValues;
        private Label lblGradeAddingError;
        private Label lblShowStatisticsTab2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btnCreateWordFile;
        private ScrollablePanel pnlWordFileInfo;
        private Label lblWordFileInfo;
        private TabPage tabPage5;
        private PictureBox pcbDisplayImageFile;
        private Button btnCreateImageFile;
    }
}

