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
            DataTable dt = new DataTable();

            //Set the app status : {"Still being reviewed or "Rejected"} 
            if (controllerObj.CheckifApplied(AppID, Currentyear) == 0) //checks on takes 
            {
                
                
            }
            else
            {

                //Applicant only shows still not applied, Still being reviewd, terminated, withdrawn
                //Because accepted will be on the intern side
                //THERE ARE STILL CASES FOR TERMINATED OR WITHDRAWN
                //only handle if terminated or withdrawn in current year. Otherwise should be not applied yet
                dt = controllerObj.GetGrade(AppID, Currentyear);
                if(dt.Rows[0][0].ToString() != "") //if the applicant has a grade this year
                {
                    //We should disable the apply button
                    Apply_ToCourse.Enabled = false;
                    if (dt.Rows[0][0].ToString() == "T")
                    {
                        Application_Status_label.Text = "Terminated";
                    }
                    else
                    {
                        Application_Status_label.Text = "Withdrawn";
                    }

                }
                else
                {   //if the applicant has no grade this year
                    dt = controllerObj.GetApplicationStatus(AppID, Currentyear);
                    if (dt.Rows[0][0].ToString() == "0")
                    {
                        Application_Status_label.Text = "Still Being Reviewd";
                    }
                    else
                    {

                        Application_Status_label.Text = "Rejected";

                        //Notice that there won't be a case where applicant has status "2" 
                    }
                }
                
            }

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
