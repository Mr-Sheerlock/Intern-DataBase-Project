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
    public partial class InternshipGrading : Form
    {
        Controller controllerObj;
        int idSelected;
        string InstructorId;
        int Year;
        int Remaining;
        DataTable dt;
        public InternshipGrading(string Userid, int CurYear)
        {
            InitializeComponent();
            InstructorId = Userid;
            Year = CurYear;
            Remaining = 1;      // or any number other than 0
            controllerObj = new Controller();
            idSelected = -1;
            InternsGradesGrid.DataSource = controllerObj.SelectInterns(InstructorId);
            InternsGradesGrid.Refresh();
        }


        private void InternsGradesGrid_DataBindingComplete(object sender, EventArgs e)
        {
            InternsGradesGrid.ClearSelection();
        }
        //private void InternsGradesGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //{

        //}

        private void InternsGradesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternsGradesGrid.CurrentCell.RowIndex < ((DataTable)InternsGradesGrid.DataSource).Rows.Count)
            {
                idSelected = Int16.Parse(((DataTable)InternsGradesGrid.DataSource).Rows[InternsGradesGrid.CurrentCell.RowIndex][0].ToString());
            }
            else
            {
                idSelected = -1;
            }
        }

        private void GradeA_Click(object sender, EventArgs e)
        {

            if (InternsGradesGrid.DataSource == null)
            {
                MessageBox.Show("There are no pending Intern");
                return;
            }
            if (idSelected == -1)
            {
                MessageBox.Show("There are no un-graded Interns");
                InternsGradesGrid.ClearSelection();
                return;
            }
            controllerObj.SetGradeA(idSelected, Year);      // Sets intern grade
            controllerObj.InternToApp(idSelected);          // sets intern as applicant again
            ////controllerObj.ChangetoCompl(idSelected);
            ////// Checks whether all interns have been graded, if so, then the year has ended
            ////// and we will now enter the new year
            ////dt = controllerObj.CheckYearEnd();
            ////Remaining = Int16.Parse((dt.Rows[0][0].ToString()));
            ////if (Remaining == 0)     // Year has ended, as all interns have been graded
            ////{
            ////    // Change year here
            ////    // Also do this in the rest of the grade buttons
            ////}
            InternsGradesGrid.DataSource = controllerObj.SelectInterns(InstructorId);
            InternsGradesGrid.Refresh();

            InternsGradesGrid.ClearSelection();

            idSelected = -1;

        }

        private void GradeB_Click(object sender, EventArgs e)
        {

            if (InternsGradesGrid.DataSource == null)
            {
                MessageBox.Show("There are no pending Intern");
                return;
            }
            if (idSelected == -1)
            {
                MessageBox.Show("There are no un-graded Interns");
                InternsGradesGrid.ClearSelection();
                return;
            }
            controllerObj.SetGradeB(idSelected, Year);
            controllerObj.InternToApp(idSelected);          // sets intern as applicant again
            controllerObj.ChangetoCompl(idSelected);         // Removes intern from applicant/intern table
            InternsGradesGrid.DataSource = controllerObj.SelectInterns(InstructorId);
            InternsGradesGrid.Refresh();

            InternsGradesGrid.ClearSelection();

            idSelected = -1;

        }

        private void GradeC_Click(object sender, EventArgs e)
        {

            if (InternsGradesGrid.DataSource == null)
            {
                MessageBox.Show("There are no pending Intern");
                return;
            }
            if (idSelected == -1)
            {
                MessageBox.Show("There are no un-graded Interns");
                InternsGradesGrid.ClearSelection();
                return;
            }
            controllerObj.SetGradeC(idSelected, Year);
            controllerObj.InternToApp(idSelected);          // sets intern as applicant again
            controllerObj.ChangetoCompl(idSelected);         // Removes intern from applicant/intern table
            InternsGradesGrid.DataSource = controllerObj.SelectInterns(InstructorId);
            InternsGradesGrid.Refresh();

            InternsGradesGrid.ClearSelection();

            idSelected = -1;

        }

        private void GradeD_Click(object sender, EventArgs e)
        {

            if (InternsGradesGrid.DataSource == null)
            {
                MessageBox.Show("There are no pending Intern");
                return;
            }
            if (idSelected == -1)
            {
                MessageBox.Show("There are no un-graded Interns");
                InternsGradesGrid.ClearSelection();
                return;
            }
            controllerObj.SetGradeD(idSelected, Year);
            controllerObj.InternToApp(idSelected);          // sets intern as applicant again
            controllerObj.ChangetoCompl(idSelected);         // Removes intern from applicant/intern table
            InternsGradesGrid.DataSource = controllerObj.SelectInterns(InstructorId);
            InternsGradesGrid.Refresh();

            InternsGradesGrid.ClearSelection();

            idSelected = -1;

        }

        private void GradeF_Click(object sender, EventArgs e)
        {

            if (InternsGradesGrid.DataSource == null)
            {
                MessageBox.Show("There are no pending Intern");
                return;
            }
            if (idSelected == -1)
            {
                MessageBox.Show("There are no un-graded Interns");
                InternsGradesGrid.ClearSelection();
                return;
            }
            controllerObj.SetGradeF(idSelected, Year);
            controllerObj.InternToApp(idSelected);          // sets intern as applicant again
            controllerObj.ChangetoCompl(idSelected);         // Removes intern from applicant/intern table
            InternsGradesGrid.DataSource = controllerObj.SelectInterns(InstructorId);
            InternsGradesGrid.Refresh();

            InternsGradesGrid.ClearSelection();

            idSelected = -1;

        }

        private void Terminate_Click(object sender, EventArgs e)
        {

            if (InternsGradesGrid.DataSource == null)
            {
                MessageBox.Show("There are no pending Intern");
                return;
            }
            if (idSelected == -1)
            {
                MessageBox.Show("There are no un-graded Interns");
                InternsGradesGrid.ClearSelection();
                return;
            }
            controllerObj.SetGradeT(idSelected, Year);
            controllerObj.InternToApp(idSelected);          // sets intern as applicant again
            controllerObj.ChangetoCompl(idSelected);         // Removes intern from applicant/intern table
            InternsGradesGrid.DataSource = controllerObj.SelectInterns(InstructorId);
            InternsGradesGrid.Refresh();

            InternsGradesGrid.ClearSelection();

            idSelected = -1;

        }

        private void InternsGradesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
