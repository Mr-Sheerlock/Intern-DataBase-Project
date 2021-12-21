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
            else if (DepOpMenu_cmbox.SelectedIndex == 1)
            {
                HideAllPanels();
                Delete_Department_Panel.Visible = true;
                Delete_Department_Panel.Dock = DockStyle.Left;
                 
            }
        }
        private void AddDepartment_BTN_Click(object sender, EventArgs e)
        {
            short parsed;
            if (string.IsNullOrEmpty(dname_txtbox.Text))
            {
                MessageBox.Show("Department Name Cannot be Empty");
                return;
            }
            if (string.IsNullOrEmpty(did_txtbox.Text))
            {
                MessageBox.Show("Department ID Cannot be Empty");
                return;
            }
            if (!Int16.TryParse(did_txtbox.Text, out parsed) || parsed<0)
            {
                MessageBox.Show("Department ID Cannot be Letters or negative numbers ");
                return;
            }
            //TODO : IMPLEMENT THE ADD DEPARTMENT FUNCTION 
            dname_txtbox.Clear();
            did_txtbox.Clear();
        }

        private void DeleteDepartment_BTN_Click(object sender, EventArgs e)
        {
            if (DelDep_cmbox.SelectedIndex < 0)
            {
                MessageBox.Show("Choose a valid Department to be Deleted ");
                return;
            }

            //TODO : IMPLEMENT DEPARTMENT DELETION 
            DelDep_cmbox.SelectedIndex = -1;
        }
    }
}
