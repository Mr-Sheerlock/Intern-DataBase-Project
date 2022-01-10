using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication.Instructor
{
    public partial class InsStat : Form
    {
        Controller ctrlobj = new Controller();
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
        public InsStat()
        {
            InitializeComponent();
            HideAllPanels();


            SHOWSTAT_BTN.Enabled = false;
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                SHOWSTAT_BTN.Enabled = true;
            }
            else
            {
                SHOWSTAT_BTN.Enabled = false;
            }
            if (comboBox1.SelectedIndex == 0)
            {

                HideAllPanels();

                yearpanel.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 1)
            {

                HideAllPanels();
                coursepanel.Visible = true;
                //coursepanel.Dock = DockStyle.Left;
                course_cmbox.DataSource = ctrlobj.SelectCourseID();
                course_cmbox.DisplayMember = "CourseID";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                //EDITED 27/12 By ozer 

                HideAllPanels();
                coursepanel.Visible = true;
                yearpanel.Visible = true;
                gradepanel.Visible = true;
                course_cmbox.DataSource = ctrlobj.SelectCourseID();
                course_cmbox.DisplayMember = "CourseID";

            }
        }

        private void SHOWSTAT_BTN_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                short parsed;
                if (string.IsNullOrEmpty(Year_textbox.Text) || !Int16.TryParse(Year_textbox.Text, out parsed) || parsed < 0)
                {
                    MessageBox.Show("Invalid Input for year");
                    return;
                }
                DataTable dt = ctrlobj.STATS_DROPPED_COURSES(int.Parse(Year_textbox.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                DataTable dt = ctrlobj.STATS_COURSE_LECTURES_DATEANDTIMES(int.Parse(course_cmbox.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                short parsed;
                if (string.IsNullOrEmpty(Year_textbox.Text) || !Int16.TryParse(Year_textbox.Text, out parsed) || parsed < 0)
                {
                    MessageBox.Show("Invalid Input for year");
                    return;
                }
                if (Grade_cmbox.SelectedIndex == -1) { MessageBox.Show("Invalid Input for grade"); }
                DataTable dt = ctrlobj.STATS_COURSE_YEAR_GRADE(int.Parse(course_cmbox.Text), int.Parse(Year_textbox.Text), Grade_cmbox.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }
    }
}
