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
    public partial class ApplicantLogin : Form
    {
        string AppId;
        int CurrentYear;
        Controller controllerObj;
        
        public ApplicantLogin(string AppID, int Currentyear)
        {
            controllerObj = new Controller();
            CurrentYear = Currentyear;
            InitializeComponent();
            AppId = AppID;

            //Set the app status : {"Still being reviewed or "Rejected"}


        }

        private void Apply_ToCourse_Click(object sender, EventArgs e)
        {
            //if newly registered, he should first fill in college and years of experience and CVLink

            if(controllerObj.CheckiffullyRegistered(AppId) == 0)
            {
                MessageBox.Show("You should first complete your registration and fill in extra information before you can apply to courses.");
                Applicant_ExtraInfo a = new Applicant_ExtraInfo(AppId);
                a.Show();
            }
            else
            {
                if (controllerObj.CheckAvailableCourse() == 0)
                {
                    MessageBox.Show("There are no available courses to apply to right now.");
                }
                else
                {           
                    ApplyToCourse a = new ApplyToCourse(AppId, CurrentYear);
                    a.Show();
                }
            }


            
        }

        private void View_DepInfo_Button_Click(object sender, EventArgs e)
        {
            Applicant.Departments_Info d = new Applicant.Departments_Info(CurrentYear);
            d.Show();
        }
    }
}
