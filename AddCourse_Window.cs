using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace USF_Student_Registration
{
    public partial class AddCourse_Window : Form
    {
        public AddCourse_Window()
        {
            InitializeComponent();
        }

        // we create a list of Course objects to store courses added
        List<Course> CoursesAdded = new List<Course>();

        // we also create a dynamic list data structure to store the list of Course objects from the database
        List<Course> AllCourses = new List<Course>();

        // we will write an algorithm to store all course from the database inside the AllCourses structure
        // It will basically be a File read function to read data from a CSV file, which server as a database

        // we will also initialize another dunamic list data structure to contain the list of all the classes 
        //the student has already taken; this data can come from the Student class
        List<Course> CoursesTaken = new List<Course>();

        // we will create a Dictionary data structure to store the list of prerequisites for all courses
        // the key will be the CRN, becuase it is unique for each course, while the value will be this list
        // of Course objects that are prerequisite to the course with that CRN
        Dictionary<string, List<Course>> PrerequisiteMap = new Dictionary<string, List<Course>>();

        // we will also create a Dictionary data structure to store the semester the course has been offered 
        // over the past 5 years, how many students were enrolled, and who taught the class; this is a key-value
        // data structure and in our use-case, the key will be the semeseter, while the value will a list of lists:
        // the first list will list all the courses taken that semester, while the inner list will contain 
        // infirmation on the number of students enrolled and who taught the class
        Dictionary<string, List<List<string>>> CoursesTakenLately;

        // this method will help in initializing the struct and the dictionary structures above
        public void InitializeStructAndDictionary()
        {
            // we will write some algorithm or hardcoded statements to initialize "PrerequisiteMap" and 
            // "CoursesTakenLately"
            //
            //
            //
        }

        private void Back_From_Add_BTN_Click(object sender, EventArgs e)
        {
            // when the Back button is clicked, we go back to the Classes Portal Form
            this.DialogResult = DialogResult.OK;
        }

        private void AddClass_BTN_Click(object sender, EventArgs e)
        {

            // if the add button is clicked, we take the text value of 
            //the textbox CRN_TXTBX and search for the corresponding class
            Course selected_course = new Course();
            bool found_class = false;
            if (CRN_TXTBX.Text != "")
            {
                // first let's find out what course corresponds to this CRN
                // we will find that from the list of all the courses
                foreach (var course in AllCourses)
                {
                    if (String.Equals(course.Get_CRN(), CRN_TXTBX.Text))
                    {
                        found_class = true;
                        selected_course = course;
                    }
                }
                bool already_added = false;
                // we now check if this course is already added
                foreach (var course in CoursesAdded)
                {
                    if (String.Equals(selected_course.Get_CRN(), course.Get_CRN())) {
                        already_added = true;
                    }
                }

                if (already_added)
                {
                    MessageBox.Show("Error! This course has already been added!");
                }

                // if we found the class, we continue checking other 
                // conditions, otherwise we let the user know CRN is invalid
                if (found_class && !already_added)
                {
                    // we now check if this course has not already been taken before
                    bool course_already_taken = false;
                    foreach (var course in CoursesTaken)
                    {
                        if (course == selected_course)
                        {
                            course_already_taken = true;
                        }
                    }
                    // if this is not yet taken, we continue checking other conditions
                    if (!course_already_taken)
                    {
                        // we now check if all the prerequisites of this selected class are among all the courses taken already
                        // we check the Prerequisite Map against the list of all the courses taken
                        bool all_prerequisites_taken = true;
                        bool prerequisite_taken = false;
                        foreach (var course in PrerequisiteMap[selected_course.Get_CRN()])
                        {
                            foreach (var course_taken in CoursesTaken)
                            {
                                if (course.Get_CRN() == course_taken.Get_CRN())
                                {
                                    prerequisite_taken = true;
                                    break;
                                }
                            }

                            if (prerequisite_taken)
                            {
                                // if this course is taken already, we reset the boolean and continue checking the rest of the
                                // prerequisite courses
                                prerequisite_taken = false;
                            }
                            else
                            {
                                // otherwise, we break and let the user know this particular prerequisite class has not yet been
                                // taken
                                all_prerequisites_taken = false;
                                MessageBox.Show("Error! The prerequisite class, " + course.Get_CRN() + ", " + course.Get_Title() + "," +
                                    " has not yet been taken!");
                                break;
                            }
                        }
                        if (all_prerequisites_taken)
                        {
                            // if all the prerquisites have been taken, we successfully add this selected 
                            // course to the list of courses added
                            CoursesAdded.Add(selected_course);

                            // we now add the course to the ListView element in the UI
                            ListViewItem lvitem = new ListViewItem(selected_course.Get_CRN());
                            lvitem.SubItems.Add(selected_course.Get_Subj());
                            lvitem.SubItems.Add(selected_course.Get_Crse());
                            lvitem.SubItems.Add(selected_course.Get_Sec());
                            lvitem.SubItems.Add(selected_course.Get_Level());
                            lvitem.SubItems.Add(selected_course.Get_Title());
                            lvitem.SubItems.Add(selected_course.Get_Credits());
                            lvitem.SubItems.Add(selected_course.Get_Group());
                            lvitem.SubItems.Add(selected_course.Get_Professor());
                            AddedClasses_LTVW.Items.Add(lvitem);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error! Invalid CRN, no class has this CRN! Try again.");
                    CRN_TXTBX.Clear();
                }
            }
            else
            {
                MessageBox.Show("Error! Invalid entry! Try again.");
                CRN_TXTBX.Clear();
            }
        }
    }
}
