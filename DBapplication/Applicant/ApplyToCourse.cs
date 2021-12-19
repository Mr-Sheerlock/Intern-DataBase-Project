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
        string BranchID;
        string CourseID;
        public ApplyToCourse()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectDep_Loc();
            DepartmentBranch_Combobox.DataSource = dt;
            DepartmentBranch_Combobox.DisplayMember = "departmentName";
        }
        //We probably need a join command that gets the deoartmentname and location
        private void Apply_ToCourse_Click(object sender, EventArgs e)
        {
            //Make a query that applies based on the courseID

        }

        private void DepartmentBranch_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Here we will make the change reflect in the second combobox

            //Make a query that determines the available courses given the branchID

        }
    }
}
