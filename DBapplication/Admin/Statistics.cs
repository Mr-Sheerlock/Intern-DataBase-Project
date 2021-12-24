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
    public partial class Statistics : Form
    {
        Controller ctrlobj = new Controller();
        //USEFUL FUNCTIONS  ADDED BY OZER 

        public void HideAllPanels()
        {
            foreach (Panel p  in this.Controls.OfType<Panel>())
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
        public Statistics()
        {
            InitializeComponent();
            HideAllPanels();
      

            SHOWSTAT_BTN.Enabled = false;
        }

        private void SHOWSTAT_BTN_Click(object sender, EventArgs e)
        {
            if (StatOpMenu_cmbox.SelectedIndex == 0)
            {
                DataTable dt = ctrlobj.STATS_APPLICANTS_DEPARTMENTS();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            if (StatOpMenu_cmbox.SelectedIndex == 1)
            {
                DataTable dt = ctrlobj.STATS_INTERNS_DEPARTMENTS();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            if (StatOpMenu_cmbox.SelectedIndex == 2)
            {
                DataTable dt = ctrlobj.STATS_INSTRUCTS_DEPARTMENTS();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            if (StatOpMenu_cmbox.SelectedIndex == 3)
            {
                short parsed;
                if (string.IsNullOrEmpty(Year_textbox.Text) || !Int16.TryParse(Year_textbox.Text , out parsed) || parsed < 0)
                {
                    MessageBox.Show("Invalid Input for year");
                    return;
                }
                DataTable dt = ctrlobj.STATS_DROPPED_COURSES(int.Parse(Year_textbox.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }  
            if (StatOpMenu_cmbox.SelectedIndex == 4)
            {
                short parsed;
                if (string.IsNullOrEmpty(Year_textbox.Text) || !Int16.TryParse(Year_textbox.Text, out parsed) || parsed < 0)
                {
                    MessageBox.Show("Invalid Input for year");
                    return;
                }
                DataTable dt = ctrlobj.STATS_GRADES_PER_DEPARTMENT_COURSES(Dep_cmbox.Text, int.Parse(Year_textbox.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            if (StatOpMenu_cmbox.SelectedIndex== 5)
            {
                DataTable dt = ctrlobj.STATS_COURSES_PER_DEPARTMENT(Dep_cmbox.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            } 
            if (StatOpMenu_cmbox.SelectedIndex== 6)
            {
                DataTable dt = ctrlobj.STATS_LOCATION_PER_COURSE(int.Parse(course_cmbox.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            } 
            if (StatOpMenu_cmbox.SelectedIndex== 7)
            {
                DataTable dt = ctrlobj.STATS_COURSE_LECTURES_DATEANDTIMES(int.Parse(course_cmbox.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            } 
            if (StatOpMenu_cmbox.SelectedIndex== 8)
            {
                DataTable dt = ctrlobj.SelectCourse_Instructor(DepID_cmbox.Text, BranchID_cmbox.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            } 
            if (StatOpMenu_cmbox.SelectedIndex== 9)
            {
                
                DataTable dt = ctrlobj.STATS_COURSE_YEAR_GRADE(int.Parse(course_cmbox.Text), int.Parse(Year_textbox.Text), Grade_cmbox.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void StatOpMenu_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatOpMenu_cmbox.SelectedIndex >= 0)
            {
                SHOWSTAT_BTN.Enabled = true;
            }
            else
            {
                SHOWSTAT_BTN.Enabled = false;
            }
            if(StatOpMenu_cmbox.SelectedIndex==0 || StatOpMenu_cmbox.SelectedIndex == 1 || StatOpMenu_cmbox.SelectedIndex == 2) { HideAllPanels(); }
            if (StatOpMenu_cmbox.SelectedIndex == 3)
            {
                HideAllPanels();
                yearpanel.Visible = true;
            } 
            if (StatOpMenu_cmbox.SelectedIndex == 4)
            {
                HideAllPanels();
                departmentname_panel.Visible = true;
                yearpanel.Visible = true;
            
                Dep_cmbox.DataSource = ctrlobj.SelectDepartmentNames();
                Dep_cmbox.DisplayMember = "DepartmentName";
            }
            if (StatOpMenu_cmbox.SelectedIndex == 5)
            {

                HideAllPanels();
                departmentname_panel.Visible = true;
                departmentname_panel.Dock = DockStyle.Left;
                Dep_cmbox.DataSource = ctrlobj.SelectDepartmentNames();
                Dep_cmbox.DisplayMember = "DepartmentName";
            } 
            if (StatOpMenu_cmbox.SelectedIndex == 6)
            {

                HideAllPanels();
                coursepanel.Visible = true;
                coursepanel.Dock = DockStyle.Left;
                course_cmbox.DataSource = ctrlobj.SelectCourseID();
                course_cmbox.DisplayMember = "CourseID";
            }
            if (StatOpMenu_cmbox.SelectedIndex == 7)
            {

                HideAllPanels();
                coursepanel.Visible = true;
                coursepanel.Dock = DockStyle.Left;
                course_cmbox.DataSource = ctrlobj.SelectCourseID();
                course_cmbox.DisplayMember = "CourseID";
            } 
            if (StatOpMenu_cmbox.SelectedIndex == 8)
            {

                HideAllPanels();
                depid_panel.Visible = true;
                depid_panel.Dock = DockStyle.Left;
                DepID_cmbox.DataSource = ctrlobj.SelectDepNos();
                DepID_cmbox.DisplayMember = "Department_Number";
                BranchID_cmbox.DataSource = ctrlobj.SelectBranchIDs();
                BranchID_cmbox.DisplayMember = "Branch_ID";
            } 
            if (StatOpMenu_cmbox.SelectedIndex == 9)
            {

                HideAllPanels();
                coursepanel.Visible = true;
                yearpanel.Visible = true;
                gradepanel.Visible = true;
                course_cmbox.DataSource = ctrlobj.SelectCourseID();
                course_cmbox.DisplayMember = "CourseID";
            }

        }
    }
}
