using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DBapplication
{
    public partial class InstructorLogin : Form
    {
        Controller controllerObj;
        string instructorUser;
        string InstructorId;
        int CurrentYear;
        public InstructorLogin(string Instructorid,int year)
        {
            //We need to pass certain information here for the instructor, like the associated department and course etc 
            //in order to determine the associated applicants
            InitializeComponent();
            controllerObj = new Controller();
            CurrentYear = year;
            InstructorId=Instructorid;

            //Get the correspondng course, if there is no corresponding course, then disable the course functionalities

        }

        private void View_Admins_Button_Click(object sender, EventArgs e)
        {
            ViewAdmins v= new ViewAdmins();
            v.Show();
        }

        private void Lectures_Button_Click(object sender, EventArgs e)
        {
            Lectures_InstructorView l= new Lectures_InstructorView(InstructorId, CurrentYear);
            l.Show();
        }

        private void Intern_Results_Button_Click(object sender, EventArgs e)
        {
            Instructor.InternshipGrading g = new Instructor.InternshipGrading(InstructorId, CurrentYear);
            g.Show();
        }

        private void View_Applications_Button_Click(object sender, EventArgs e)
        {
            Instructor.ViewApplications a = new Instructor.ViewApplications(InstructorId);
            a.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Instructor.InsStat h = new Instructor.InsStat();
            h.Show();

        }
    }
}
