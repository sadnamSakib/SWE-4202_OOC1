namespace IUTLMS
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.courseTitleComboBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.courseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.courseSemesterComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.courseTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.studentSemesterComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.studentCourseComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.teacherTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.showStudentListBox = new System.Windows.Forms.ListBox();
            this.showTeacherListBox = new System.Windows.Forms.ListBox();
            this.showStudentComboBox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.showTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.courseCodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.Location = new System.Drawing.Point(124, 61);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.teacherNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.teacherNameTextBox.TabIndex = 1;
            // 
            // courseTitleComboBox
            // 
            this.courseTitleComboBox.Location = new System.Drawing.Point(430, 145);
            this.courseTitleComboBox.Name = "courseTitleComboBox";
            this.courseTitleComboBox.Size = new System.Drawing.Size(121, 22);
            this.courseTitleComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Title";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(710, 61);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.studentNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Course Code";
            // 
            // courseTypeComboBox
            // 
            this.courseTypeComboBox.FormattingEnabled = true;
            this.courseTypeComboBox.Items.AddRange(new object[] {
            "",
            "Lab",
            "Theory"});
            this.courseTypeComboBox.Location = new System.Drawing.Point(430, 100);
            this.courseTypeComboBox.Name = "courseTypeComboBox";
            this.courseTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.courseTypeComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Course Type";
            // 
            // courseSemesterComboBox
            // 
            this.courseSemesterComboBox.FormattingEnabled = true;
            this.courseSemesterComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.courseSemesterComboBox.Location = new System.Drawing.Point(430, 189);
            this.courseSemesterComboBox.Name = "courseSemesterComboBox";
            this.courseSemesterComboBox.Size = new System.Drawing.Size(121, 24);
            this.courseSemesterComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Semester";
            // 
            // courseTeacherComboBox
            // 
            this.courseTeacherComboBox.FormattingEnabled = true;
            this.courseTeacherComboBox.Location = new System.Drawing.Point(430, 234);
            this.courseTeacherComboBox.Name = "courseTeacherComboBox";
            this.courseTeacherComboBox.Size = new System.Drawing.Size(121, 24);
            this.courseTeacherComboBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Teacher";
            // 
            // studentSemesterComboBox
            // 
            this.studentSemesterComboBox.FormattingEnabled = true;
            this.studentSemesterComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.studentSemesterComboBox.Location = new System.Drawing.Point(710, 101);
            this.studentSemesterComboBox.Name = "studentSemesterComboBox";
            this.studentSemesterComboBox.Size = new System.Drawing.Size(121, 24);
            this.studentSemesterComboBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(643, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Semester";
            // 
            // studentCourseComboBox
            // 
            this.studentCourseComboBox.FormattingEnabled = true;
            this.studentCourseComboBox.Location = new System.Drawing.Point(710, 149);
            this.studentCourseComboBox.Name = "studentCourseComboBox";
            this.studentCourseComboBox.Size = new System.Drawing.Size(121, 24);
            this.studentCourseComboBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(643, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Course";
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Location = new System.Drawing.Point(124, 145);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.addTeacherButton.TabIndex = 18;
            this.addTeacherButton.Text = "Add";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // teacherTypeComboBox
            // 
            this.teacherTypeComboBox.FormattingEnabled = true;
            this.teacherTypeComboBox.Items.AddRange(new object[] {
            "",
            "Lecturer",
            "Professor"});
            this.teacherTypeComboBox.Location = new System.Drawing.Point(124, 101);
            this.teacherTypeComboBox.Name = "teacherTypeComboBox";
            this.teacherTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.teacherTypeComboBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Teacher Type";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(710, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // showStudentListBox
            // 
            this.showStudentListBox.FormattingEnabled = true;
            this.showStudentListBox.ItemHeight = 16;
            this.showStudentListBox.Location = new System.Drawing.Point(39, 322);
            this.showStudentListBox.Name = "showStudentListBox";
            this.showStudentListBox.Size = new System.Drawing.Size(298, 180);
            this.showStudentListBox.TabIndex = 23;
            // 
            // showTeacherListBox
            // 
            this.showTeacherListBox.FormattingEnabled = true;
            this.showTeacherListBox.ItemHeight = 16;
            this.showTeacherListBox.Location = new System.Drawing.Point(533, 322);
            this.showTeacherListBox.Name = "showTeacherListBox";
            this.showTeacherListBox.Size = new System.Drawing.Size(298, 180);
            this.showTeacherListBox.TabIndex = 24;
            // 
            // showStudentComboBox
            // 
            this.showStudentComboBox.FormattingEnabled = true;
            this.showStudentComboBox.Location = new System.Drawing.Point(39, 510);
            this.showStudentComboBox.Name = "showStudentComboBox";
            this.showStudentComboBox.Size = new System.Drawing.Size(121, 24);
            this.showStudentComboBox.TabIndex = 25;
            this.showStudentComboBox.SelectedIndexChanged += new System.EventHandler(this.showStudentComboBox_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(201, 511);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Show Student Info";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(696, 511);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "Show Teacher Info";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // showTeacherComboBox
            // 
            this.showTeacherComboBox.FormattingEnabled = true;
            this.showTeacherComboBox.Location = new System.Drawing.Point(533, 510);
            this.showTeacherComboBox.Name = "showTeacherComboBox";
            this.showTeacherComboBox.Size = new System.Drawing.Size(121, 24);
            this.showTeacherComboBox.TabIndex = 27;
            this.showTeacherComboBox.SelectedIndexChanged += new System.EventHandler(this.showTeacherComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "Teacher Info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(329, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "Course Info";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(651, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "Student Info";
            // 
            // courseCodeTextBox
            // 
            this.courseCodeTextBox.Location = new System.Drawing.Point(430, 58);
            this.courseCodeTextBox.Name = "courseCodeTextBox";
            this.courseCodeTextBox.Size = new System.Drawing.Size(121, 22);
            this.courseCodeTextBox.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 546);
            this.Controls.Add(this.courseCodeTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.showTeacherComboBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.showStudentComboBox);
            this.Controls.Add(this.showTeacherListBox);
            this.Controls.Add(this.showStudentListBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.teacherTypeComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addTeacherButton);
            this.Controls.Add(this.studentCourseComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.studentSemesterComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.courseTeacherComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.courseSemesterComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.courseTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.courseTitleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teacherNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.TextBox courseTitleComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox courseTypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox courseSemesterComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox courseTeacherComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox studentSemesterComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox studentCourseComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.ComboBox teacherTypeComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox showStudentListBox;
        private System.Windows.Forms.ListBox showTeacherListBox;
        private System.Windows.Forms.ComboBox showStudentComboBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox showTeacherComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox courseCodeTextBox;
    }
}

