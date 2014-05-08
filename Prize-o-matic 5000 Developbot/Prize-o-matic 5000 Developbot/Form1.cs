using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Prize
{
    public partial class Form1 : Form
    {
        private static List<Student> studentList = new List<Student>();
        // Create a studentlist 

        Random random = new Random();
        //  Create a random object

        int uaddedDuplicateStudent = 0;
        int studentlistinMem = 0;
        int numOfStudents = 0;
        int studentsminusDuplicates = 0;
        // Keeps track of various user counter variables such as duplicate students added to the list.

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = StudentNameTb;
            // Set the focus to the student name textbox for assisted user guided entry.
        }

        public void determineWinBtn_Click(object sender, EventArgs e)
        {
            // Where the action happens.  
            int studentsInWinningList = 0;
            int isDuplicateStudentInList = 0;
            string randomTbText = "";
            string holdDuplicateString = "";
            string getName = "";
            string getCourse;
            int numberOfTimesRolled = 0;
            duplicatesTb.Text = "";

            // Check that the NumericUpDown control's value + duplicates to make sure it is not higher than the total list of students, because we
            // we can't have more prizes than students to give them to.

            if (SetWinnersUd.Value + uaddedDuplicateStudent > studentList.Count)
            {
                consoleLbl.Text = "You can't have more prizes than students!";
                if (studentsminusDuplicates > 0)
                {
                    SetWinnersUd.Value = studentsminusDuplicates;
                }
            }
            else
            {
                RandWinnersTb.Text = "";
                consoleLbl.Text = "";
                try
                {
                    while (!(studentsInWinningList == SetWinnersUd.Value ))
                    {
                        foreach (Student student in studentList)
                        {
                                Student randomStudent = studentList.ElementAt(random.Next(0, studentList.Count));
                                getName = randomStudent.getName();
                                getCourse = randomStudent.getCourse();
                                randomTbText = randomStudent.getName() + ": " + randomStudent.getCourse() + "\r" + "\n";
                                numberOfTimesRolled++;
                                // After getting the random element from the Student object, this function formats the string and assign it to a string variable.
                                // In addition i'm keeping track of how many times we make rolls.
                        }

                        if (!(RandWinnersTb.Text.Contains(getName) && (studentsInWinningList < SetWinnersUd.Value)))
                        {
                            RandWinnersTb.Text += randomTbText;
                            studentsInWinningList++;
                            // This checks that the studentsInWinningList iterator is less than the NumericUpDownControl value designated by the user.
                            // and if so it checks if the Random winners textbox already contains the value being passed to it
                            // If it doesn't it will add the string to the textbox and increment the counter. It also keeps track of how many students
                            // are in the winning list.
                        }

                        else if (RandWinnersTb.Text.Contains(getName))
                        {
                            isDuplicateStudentInList++;
                            duplicatesTb.Text = "Duplicates Rolled: " + isDuplicateStudentInList + "\r" + "\n" + "Number of Rolls: " 
                                                + numberOfTimesRolled + "\r" + "\n";
                            holdDuplicateString += randomTbText;
                            duplicatesTb.Text += holdDuplicateString + "\n";
                            numberOfTimesRolled++;

                            // If the random object is not a winner, I keep track of how many duplicates there were and store them in a seperate area to account for
                            // the difference in the prize count. 
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ah ah ah...You didn't say the magic word...", "Nedry says...");
                    // I'm a jurassic park fan so I put this in for good measure...just in case something happens during the winner determination.
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
            {
                if (StudentNameTb.Text == "" && StudentCourseTb.Text == "")
                {
                    consoleLbl.Text = "You must fill out the " + StudentNameTb.Tag + " and " + "\n" + StudentCourseTb.Tag;
                }
                else if (StudentNameTb.Text == "")
                {
                    consoleLbl.Text = "You must fill out the " + StudentNameTb.Tag;
                }
                else if (StudentCourseTb.Text == "")
                {
                    consoleLbl.Text = "You must fill out the " + StudentCourseTb.Tag;
                }
                else
                { 
                    Student student = new Student(StudentNameTb.Text, StudentCourseTb.Text);
                    if (StudentNameAndCourseTb.Text.Contains(StudentNameTb.Text))
                    {
                        uaddedDuplicateStudent++;
                        // If the student textbox being added to the list is not already in the list
                        // track of the duplicate students in memory as they are added to the list.
                    }
                    studentList.Add(student);
                    studentlistinMem++;
                    numOfStudents++;
                    DisplayCurrentList();
                    SetDefaultFormControls();
                    StudentNameTb.Focus();
                    studentsminusDuplicates = numOfStudents - uaddedDuplicateStudent;
                    StudentListCtLbl.Text = studentsminusDuplicates.ToString();
                }
            }

        private void SetDefaultFormControls()
        {
            StudentNameTb.Clear();
            StudentCourseTb.Clear();
            Course1Cb.Enabled = true;
            Course2Cb.Enabled = true;
            Course1Cb.Checked = false;
            Course2Cb.Checked = false;
            consoleLbl.Text = "";
            RandWinnersTb.Text = "";
            duplicatesTb.Text = "";
        }

        private void DisplayCurrentList()
        {
            // Updates the StudentNameAndCourse textbox to display the current student list in memory in the viewer.

            string holdCurrentNames = "";
            foreach (Student stud in studentList)
            {
              holdCurrentNames = stud.getName().ToString() + ": " + stud.getCourse().ToString() + "\r" + "\n";
            }
            StudentNameAndCourseTb.Text += holdCurrentNames;
        }

        // In order to simplify things if the user wants to be on the list twice they need to enter themselves twice on the list.
        private void Course1Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Course1Cb.Checked)
            {
                Course2Cb.Enabled = false;
                StudentCourseTb.Text = (string)Course1Cb.Tag;
            }
            else
            {
                StudentCourseTb.Text = "";
                Course2Cb.Enabled = true;
            }
        }

        private void Course2Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Course2Cb.Checked)
            {
                Course1Cb.Enabled = false;
                StudentCourseTb.Text = (string)Course2Cb.Tag;
            }
            else
            {
                StudentCourseTb.Text = "";
                Course1Cb.Enabled = true;
            }
        }
        public void ClearCurrentForm()
        {
            SetDefaultFormControls();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            // Reset most of the form to the default values, clear the student list in memory and clears the winners and duplicates list.
            ClearCurrentForm();
            studentList.Clear();
            StudentNameAndCourseTb.Clear();
            RandWinnersTb.Clear();
            SetWinnersUd.Value = SetWinnersUd.Minimum;
            studentsminusDuplicates = 0;
            StudentListCtLbl.Text = "0";
            studentlistinMem = 0;
            numOfStudents = 0;
            uaddedDuplicateStudent = 0;
        }
    }
}
