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
            dt = controllerObj.SelectDep_Loc();
            //DepartmentBranch_Combobox.DataSource = dt;
            //DepartmentBranch_Combobox.DisplayMember = "val";

            DepartmentID = dt.Rows[0][1].ToString();
            dt2 = controllerObj.SelectCourse(BranchID);


            //Course_Combobox.DataSource = dt2;
            //Course_Combobox.DisplayMember = "CourseName";
            BranchID = dt2.Rows[0][1].ToString();

        }

        private void ViewCandI_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
