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
    public partial class Lectures_InstructorView : Form
    {
        Controller controllerObj;
        int LectNo;
        string InstructorId;
        int Year;
        public Lectures_InstructorView(string Userid, int CurYear)
        {
            InitializeComponent();
            InstructorId = Userid;
            Year = CurYear;
            controllerObj = new Controller();
            LectNo = -1;
            TimetableGrid.DataSource = controllerObj.SelectLecturesdate(InstructorId);
            TimetableGrid.Refresh();
        }

        private void InternsGradesGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            TimetableGrid.ClearSelection();
        }

        private void InternsGradesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TimetableGrid.CurrentCell.RowIndex < ((DataTable)TimetableGrid.DataSource).Rows.Count)
            {
                LectNo = Int16.Parse(((DataTable)TimetableGrid.DataSource).Rows[TimetableGrid.CurrentCell.RowIndex][0].ToString());
            }
            else
            {
                LectNo = -1;
            }
        }

        private void Lecture_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateButton_Click(object sender, EventArgs e)
        {
            if (TimetableGrid.DataSource == null)
            {
                MessageBox.Show("There are no pending applicant requests");
                return;
            }
            if (LectNo == -1)
            {
                MessageBox.Show("Select an applicant first");
                TimetableGrid.ClearSelection();
                return;
            }
            TimetableGrid.DataSource = controllerObj.SelectLecturesdate(InstructorId);
            //TimetableGrid.Refresh();

            //TimetableGrid.ClearSelection();

            

            string day = "";
            if (Lecture_Combobox.Text == "")
            {
                MessageBox.Show("Please Select a valid date.");
            }
            else if (Lecture_Combobox.Text == "Sunday")
            {
                day = "Sunday";
            }
            else if (Lecture_Combobox.Text == "Monday")
            {
                day = "Monday";
            }
            else if (Lecture_Combobox.Text == "Tuesday")
            {
                day = "Tuesday";
            }
            else if (Lecture_Combobox.Text == "Wednesday")
            {
                day = "Wednesday";
            }
            else if (Lecture_Combobox.Text == "Thursday")
            {
                day = "Thursday";
            }
            else if (Lecture_Combobox.Text == "Friday")
            {
                day = "Friday";
            }
            else
            {
                day = "Saturday";
            }

            // Changing the date
            controllerObj.ChangeDate(day, InstructorId, LectNo.ToString());
            TimetableGrid.DataSource = controllerObj.SelectLecturesdate(InstructorId);
            TimetableGrid.Refresh();

            LectNo = -1;
        }
    }
}
