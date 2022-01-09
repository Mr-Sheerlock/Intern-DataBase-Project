using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication.Admin
{
    public partial class Departments : Form
    {

        //USEFUL FUNCTIONS  ADDED BY OZER 
        Controller controllerObj;
        bool canRefresh;
        DataRow currentDepInfo;
        public void HideAllPanels()
        {
            foreach (Panel p in this.Controls.OfType<Panel>())
            {
                p.Visible = false;
            }
        }

        static string NullToString(object Value)
        {

            // Value.ToString() allows for Value being DBNull, but will also convert int, double, etc.
            bool emptys = string.IsNullOrEmpty(Value.ToString());
            if (emptys)
            {
                return "null";
            }
            else
            {
                return Value.ToString();
            }
            // If this is not what you want then this form may suit you better, handles 'Null' and DBNull otherwise tries a straight cast
            // which will throw if Value isn't actually a string object.
            //return Value == null || Value == DBNull.Value ? "" : (string)Value;
        }
        public Departments()
        {
            InitializeComponent();
            controllerObj = new Controller();
            HideAllPanels();
            

        }
        private void DepOpMenu_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DepOpMenu_cmbox.SelectedIndex == 0)
            {
                HideAllPanels();
                Add_Department_Panel.Visible = true;
                Add_Department_Panel.Dock = DockStyle.Left;
                 
            }
            //else if (DepOpMenu_cmbox.SelectedIndex == 1)
            //{
            //    HideAllPanels();
            //    Delete_Department_Panel.Visible = true;
            //    Delete_Department_Panel.Dock = DockStyle.Left;
            //    DelDep_cmbox.DataSource = controllerObj.SelectDepartmentNamesandNos();
            //    DelDep_cmbox.DisplayMember = "DepartmentName";
            //    DelDep_cmbox.SelectedIndex = -1;

            //}
            else
            {
                HideAllPanels();
                Edit_Department_Panel.Visible = true;
                Edit_Department_Panel.Dock = DockStyle.Left;
                canRefresh = false;
                EditDep_cmbox.DataSource = controllerObj.SelectDepartmentNamesandNos();
                EditDep_cmbox.DisplayMember = "DepartmentName";
                EditDep_cmbox.SelectedIndex = -1;
                canRefresh = true;
            }
        }
        private void AddDepartment_BTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dname_txtbox.Text))
            {
                MessageBox.Show("Department Name Cannot be Empty");
                return;
            }
            if (controllerObj.CheckifDepNameTaken(dname_txtbox.Text) == 1)
            {
                MessageBox.Show("A department with that name already exists");
                return;
            }
            int id = controllerObj.GetLastDepNumber() + 1;
            controllerObj.insertDepartment(id, dname_txtbox.Text);

            dname_txtbox.Clear();

        }

        private void DeleteDepartment_BTN_Click(object sender, EventArgs e)
        {
            if (DelDep_cmbox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a Department to be Deleted ");
                return;
            }

            controllerObj.deleteDepartment(Int32.Parse((((DataTable)DelDep_cmbox.DataSource).Rows[DelDep_cmbox.SelectedIndex][1].ToString())));

            DelDep_cmbox.DataSource = controllerObj.SelectDepartmentNamesandNos();
            DelDep_cmbox.DisplayMember = "DepartmentName";
            DelDep_cmbox.SelectedIndex = -1;
        }

        private void EditDepartment_BTN_Click(object sender, EventArgs e)
        {
            if (controllerObj.CheckifDepNameTaken(EditDep_cmbox.Text) == 1)
            {
                MessageBox.Show("A department with that name already exists");
                return;
            }

            controllerObj.updateDepartment(Int32.Parse(currentDepInfo[1].ToString()), EditDep_cmbox.Text);



            canRefresh = false;
            EditDep_cmbox.DataSource = controllerObj.SelectDepartmentNamesandNos();
            EditDep_cmbox.DisplayMember = "DepartmentName";
            EditDep_cmbox.SelectedIndex = -1;
            canRefresh = true;
            EditDepartment_BTN.Visible = false;
        }

        private void DelDep_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EditDep_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canRefresh && EditDep_cmbox.SelectedIndex != -1)
            {
                EditDepartment_BTN.Visible = true;
                currentDepInfo = controllerObj.SelectDepartmentNamesandNos().Rows[EditDep_cmbox.SelectedIndex];
            }
        }
    }
}
