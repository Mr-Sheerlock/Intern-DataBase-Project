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
        //bool lol = false;
        public ApplyToCourse(string Appid,int Currentyear)
        {
            //Make a query to check if there are open courses 

            //if not 

            //if(true)
            //{
            //    MessageBox.Show("There are no available courses to apply on right now.");
            //    this.Close();

            //}


            CurrentYear = Currentyear;
            AppID = Appid;
            //We still need to handle the case that there is no courses that satisfy this

            //+ the case where the applicant had already applied before 
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
            //Make a query that applies based on the courseID

            //If the applicant had already applied warn him that he can only choose 1 course


            //else
            controllerObj.ApplytoCourse(AppID, CourseID, CurrentYear);
        }
    }
}
