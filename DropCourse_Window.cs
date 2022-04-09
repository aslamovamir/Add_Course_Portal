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
    public partial class DropCourse_Window : Form
    {
        public DropCourse_Window()
        {
            InitializeComponent();
        }

        private void Back_From_Drop_BTN_Click(object sender, EventArgs e)
        {
            // when the Back button is clicked, we go back to the Classes Portal Form
            this.DialogResult = DialogResult.OK;
        }
    }
}
