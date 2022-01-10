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
    public partial class ViewApplications : Form
    {
        Controller controllerObj;
        int idSelected;
        //int Dnombre;
        string InstructorId;
        DataTable dt;

        public ViewApplications(string Userid)
        {
            InitializeComponent();
            // ha-call hena el query elly bt3ml display lel 7agat el gowa el datagrid
            InstructorId = Userid;
            controllerObj = new Controller();
            idSelected = -1;
            //Dnombre = -1;
            PendingApplicantsGrid.DataSource = controllerObj.SelectApplicants(InstructorId);
            PendingApplicantsGrid.Refresh();
            

        }

        private void PendingApplicantsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PendingApplicantsGrid.CurrentCell.RowIndex < ((DataTable)PendingApplicantsGrid.DataSource).Rows.Count)
            {
                idSelected = Int16.Parse(((DataTable)PendingApplicantsGrid.DataSource).Rows[PendingApplicantsGrid.CurrentCell.RowIndex][0].ToString());
                //Dnombre = Int16.Parse(((DataTable)PendingApplicantsGrid.DataSource).Rows[PendingApplicantsGrid.CurrentCell.RowIndex][1].ToString());
                // hal 1 dh kda tany element?
            }
            else
            {
                idSelected = -1;
            }
        }


        private void ApproveButton_Click(object sender, EventArgs e)
        {
            if (PendingApplicantsGrid.DataSource == null)
            {
                MessageBox.Show("There are no pending applicant requests");
                return;
            }
            if (idSelected == -1)
            {
                MessageBox.Show("Select an applicant first");
                PendingApplicantsGrid.ClearSelection();
                return;
            }
            controllerObj.approveApplicant(idSelected);
            controllerObj.AppToIntern(idSelected);      // sets applicant as intern again
            //controllerObj.AppToIntern(idSelected, Dnombre);      // sets applicant as intern again
            PendingApplicantsGrid.DataSource = controllerObj.SelectApplicants(InstructorId);
            PendingApplicantsGrid.Refresh();

            PendingApplicantsGrid.ClearSelection();

            idSelected = -1;


        }



        private void RejectButton_Click(object sender, EventArgs e)
        {

            if (PendingApplicantsGrid.DataSource == null)
            {
                MessageBox.Show("There are no pending applicant requests");
                return;
            }
            if (idSelected == -1)
            {
                MessageBox.Show("Select an applicant first");
                PendingApplicantsGrid.ClearSelection();
                return;
            }
            controllerObj.RejectApplicant(idSelected);
            PendingApplicantsGrid.DataSource = controllerObj.SelectApplicants(InstructorId);
            PendingApplicantsGrid.Refresh();

            PendingApplicantsGrid.ClearSelection();

            idSelected = -1;

        }

        private void PendingApplicantsGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PendingApplicantsGrid.ClearSelection();
        }

        private void PendingApplicantsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetAppNumber_Click(object sender, EventArgs e)
        {
            //lblResult.Text = themeaningoflifeuniverseandeverything.ToString();
            if (PendingApplicantsGrid.DataSource == null)
            {
                label2.Text = "0";
            }
            else
            {
                dt = controllerObj.Countapplicants(InstructorId);
                label2.Text = (dt.Rows[0][0].ToString());
            }
            

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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
