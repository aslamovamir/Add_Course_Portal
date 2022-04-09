using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USF_Student_Registration
{
    class Course
    {
        // let's add attributes
        private string CRN, Subj, Crse, Sec, Level, Title, Credits, Group, Professor;

        // parametrized constructor with all the attributes assigned
        public Course(string CRN, string Subj, string Crse, string Sec, 
            string Level, string Title, string Credits, string Group,
            string Professor) 
        {
            this.CRN = CRN;
            this.Subj = Subj;
            this.Crse = Crse;
            this.Sec = Sec;
            this.Level = Level;
            this.Title = Title;
            this.Credits = Credits;
            this.Group = Group;
            this.Professor = Professor;
        }

        // custom constructor with no parameters
        public Course()
        {
            this.CRN = null;
            this.Subj = null;
            this.Crse = null;
            this.Sec = null;
            this.Level = null;
            this.Title = null;
            this.Credits = null;
            this.Group = null;
            this.Professor = null;
        }

        // We do not need Setters, only Getters
        // Getters
        public string Get_CRN()
        {
            return this.CRN;
        }
        public string Get_Subj()
        {
            return this.Subj;
        }
        public string Get_Crse()
        {
            return this.Crse;
        }
        public string Get_Sec()
        {
            return this.Sec;
        }
        public string Get_Level()
        {
            return this.Level;
        }
        public string Get_Title()
        {
            return this.Title;
        }
        public string Get_Credits()
        {
            return this.Credits;
        }
        public string Get_Group()
        {
            return this.Group;
        }
        public string Get_Professor()
        {
            return this.Professor;
        }
    }
}
