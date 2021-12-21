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
    public partial class Courses : Form
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
        public Courses()
        {
            InitializeComponent();
            HideAllPanels();
        }

        private void CourseOpMenu_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseOpMenu_cmbox.SelectedIndex ==0)
            {
                HideAllPanels();
                Add_Course_Panel.Visible = true;
                Add_Course_Panel.Dock = DockStyle.Left;
                //TODO : FILL THE COMBOBOX WITH THE AVAILABLE DEPARTMENTS 
            }
            else if(CourseOpMenu_cmbox.SelectedIndex == 1)
            {
                HideAllPanels();
                Update_Course_Panel.Visible = true;
                Update_Course_Panel.Dock = DockStyle.Left;
                //TODO : FILL THE COMBOBOX WITH AVAILABLE COURSES 
            }
        }

        private void AddCourse_BTN_Click(object sender, EventArgs e)
        {
            short parsed;
            if (string.IsNullOrEmpty(cname_txtbox.Text))
            {
                MessageBox.Show("Course Name Cannot be Empty");
                return;
            }
            if (string.IsNullOrEmpty(cid_txtbox.Text))
            {
                MessageBox.Show("Course ID Cannot be Empty");
                return;
            }
            if (!Int16.TryParse(cid_txtbox.Text,out parsed) || parsed < 0)
            {
                MessageBox.Show("Course ID Cannot be Letters or Negative numbers");
                return;
            }
            if (ActiveCourseRadBtn1.Checked==false && InactiveCourseRadBtn1.Checked == false)
            {
                MessageBox.Show("Course status must be determined");
                return;
            }
            if (CtrlDep_cmbox.SelectedIndex < 0)
            {
                MessageBox.Show("Course Department must be determined");
                return;
            }
            bool stats = (ActiveCourseRadBtn1.Checked) ? true : false;
            //TODO : Put the functions of the addition 
            cname_txtbox.Clear();
            cid_txtbox.Clear();
            ActiveCourseRadBtn1.Checked = false;
            InactiveCourseRadBtn1.Checked = false;
            CtrlDep_cmbox.SelectedIndex = -1;

        }

        private void UpdateCourse_BTN_Click(object sender, EventArgs e)
        {
            if (updateCourse_cmbox.SelectedIndex < 0)
            {
                MessageBox.Show("Choose a valid Course to be updated ");
                return;
            }
           
            //TODO : Implement the update functions 
            updateCourse_cmbox.SelectedIndex = -1;
         
        }

       
    }
}
