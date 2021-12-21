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
    public partial class InternLogin : Form
    {
        string InternId;
        int CurrentYear;
        Controller controllerObj;
        public InternLogin(string internid, int year)
        {
            InitializeComponent();
            InternId = internid;    
            CurrentYear = year;
            controllerObj = new Controller();
            DataTable dt = new DataTable();
            dt = controllerObj.GetGrade(InternId,CurrentYear);


            if (dt == null || dt.Rows[0][0].ToString() =="")
            {
                //Leave the textbox as is   
            }
            else
            {
               Grade_label.Text =dt.Rows[0][0].ToString();
                if (dt.Rows[0][0].ToString() == "F")
                {
                    Internship_Status_label.Text = "Failed";
                    //Assumes the intern job code will be changed at the end of the year

                }
                else
                {
                    Internship_Status_label.Text = "Completed";

                }
            }

            //The case where there is no course having the intern shouldn't be possible.

            dt = controllerObj.SelectDepHavingCourse(InternId, CurrentYear);

            DepartmentName_label.Text=dt.Rows[0][0].ToString();
            LocationName_label.Text= dt.Rows[0][1].ToString();


            dt = controllerObj.SelectInstructorName(internid, CurrentYear);

            InstructorName_label.Text = dt.Rows[0][0].ToString() +" " +  dt.Rows[0][1].ToString();


        }


        private void View_Lectures_Button_Click(object sender, EventArgs e)
        {

        }

        private void View_DepInfo_Button_Click(object sender, EventArgs e)
        {

        }


        private void Drop_Course_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to drop the internship?", "Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                controllerObj.DropCourse(InternId);
                controllerObj.ChangeFromInterntoApp(InternId);
                MessageBox.Show("Internship Dropped Successfully!");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("No changes have been done."); //You made the right choice :) 
            }
        }

        
    }
}
