using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication.Applicant
{
    public partial class Departments_Info : Form
    {
        Controller controllerObj;
        string DepartmentID;
        string BranchID;
        DataTable dt;
        DataTable dt2;
        int CurrentYear;
        public Departments_Info(int currentYear)
        {
            InitializeComponent();
            CurrentYear = currentYear;

            controllerObj = new Controller();
            dt = controllerObj.SelectDepartments();

            Department_Combobox.DataSource = dt;
            Department_Combobox.DisplayMember= "DepartmentName";

            
            

            DepartmentID = dt.Rows[0][0].ToString();
            
            dt2 = controllerObj.SelectLocations(DepartmentID);


            Branch_Combobox.DataSource = dt2;
            Branch_Combobox.DisplayMember = "LocationName";
            BranchID = dt2.Rows[0][0].ToString();

        }

        
        private void Department_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepartmentID = dt.Rows[(int)Department_Combobox.SelectedIndex][0].ToString();

            dt2 = controllerObj.SelectLocations(DepartmentID);
            Branch_Combobox.DataSource = dt2;
            Branch_Combobox.DisplayMember = "LocationName";
            BranchID = dt2.Rows[0][0].ToString();
        }

        private void Branch_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BranchID = dt2.Rows[(int)Branch_Combobox.SelectedIndex][0].ToString();
        }


        private void ViewCandI_Button_Click(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();

            //Some query here 
            dt3 = controllerObj.SelectCourse_Instructor(DepartmentID, BranchID);


            Courses_Instructors c = new Courses_Instructors(dt3);
            c.Show();
        }

    }
}
