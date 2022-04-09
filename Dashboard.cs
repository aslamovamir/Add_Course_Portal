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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Add_BTN_Click(object sender, EventArgs e)
        {
            // when the Add Class button is clicked, we hide the 
            //Courses Portal Window and show the Add Class Window dialog

            // hide the current window
            this.Hide();

            // add the Add Courses Window object
            AddCourse_Window add_window = new AddCourse_Window();

            // show this window dialog
            add_window.ShowDialog();
        }

        private void Drop_BTN_Click(object sender, EventArgs e)
        {
            // when the Drop Class button is clicked, we hide the 
            //Courses Portal Window and show the Drop Class Window

            // hide the current window
            this.Hide();

            // add the Drop Class Window object
            DropCourse_Window drop_window = new DropCourse_Window();

            // show this window
            drop_window.ShowDialog();
        }

    }
}
