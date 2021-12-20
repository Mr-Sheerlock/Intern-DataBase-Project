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
    public partial class ApplyToCourse : Form
    { 
        Controller controllerObj;
        string AppID;
        string BranchID;
        string CourseID;
        DataTable dt;
        DataTable dt2;
        int CurrentYear;
        public ApplyToCourse(string Appid,int Currentyear)
        {
            CurrentYear = Currentyear;
            AppID = Appid;


            InitializeComponent();
            controllerObj = new Controller();
            dt = controllerObj.SelectDep_Loc();
            DepartmentBranch_Combobox.DataSource = dt;
            DepartmentBranch_Combobox.DisplayMember = "val";
            
            BranchID = dt.Rows[0][1].ToString();
            dt2 = controllerObj.SelectCourse(BranchID);


            Course_Combobox.DataSource = dt2;
            Course_Combobox.DisplayMember = "CourseName";
            CourseID = dt2.Rows[0][1].ToString();
            
        }
        
        

        private void DepartmentBranch_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Here we will make the change reflect in the second combobox

            //Make a query that determines the available courses given the branchID
            
            int index = ((int)DepartmentBranch_Combobox.SelectedIndex); 

            
            BranchID = dt.Rows[index][1].ToString();

            dt2= controllerObj.SelectCourse(BranchID);


            Course_Combobox.DataSource= dt2;
            Course_Combobox.DisplayMember = "CourseName";
        }

        private void Course_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((int)Course_Combobox.SelectedIndex);
            CourseID = dt2.Rows[index][1].ToString();


        }
        private void Apply_ToCourse_Click(object sender, EventArgs e)
        {


            //DO NOT FORGET TO UPDATE APPLICANT_INTERN TABLE

            //if first time ask for extra info 
            if (false)
            {

                MessageBox.Show("You need to fill in more information before applying to courses");
                Applicant_ExtraInfo a =new Applicant_ExtraInfo(AppID);
                a.Show();   
            }




            if (controllerObj.CheckifApplied(AppID,CurrentYear) == 1)
            {
                DialogResult dialogResult = MessageBox.Show("You have already applied to a course and you can only apply to one course per year. Are you sure you want to change the application?", "Confirmation", MessageBoxButtons.YesNo);
                
                if (dialogResult == DialogResult.Yes)
                {
                    controllerObj.ChangeApplication(AppID, CourseID);
                    MessageBox.Show("Application Updated Successfully!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("The Application wasn't changed.");
                }


            }
            else
            {
                controllerObj.ApplytoCourse(AppID, CourseID, CurrentYear);
                MessageBox.Show("Application Recieved Best of Luck!");
            }

            
        }

        private void Cancel_Application_Button_Click(object sender, EventArgs e)
        {
            if (controllerObj.CancelApplication(AppID,CurrentYear) == 1)
            {
                MessageBox.Show("Deleted Successfully");
            }
            else
            {   
                MessageBox.Show("Already Cancelled or doesn't exist");
            }
        }
    }
}
