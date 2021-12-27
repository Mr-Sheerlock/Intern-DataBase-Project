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
    public partial class Approve_Instructor : Form
    {
        Controller controllerObj;
        int idSelected;
        public Approve_Instructor()
        {
            InitializeComponent();
            controllerObj = new Controller();
            idSelected = -1;
            PendingInstructorsGrid.DataSource = controllerObj.SelectPendingInstructors();
            PendingInstructorsGrid.Refresh();

        }

        private void PendingInstructorsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PendingInstructorsGrid.CurrentCell.RowIndex < ((DataTable)PendingInstructorsGrid.DataSource).Rows.Count )
            {
                idSelected = Int16.Parse(((DataTable)PendingInstructorsGrid.DataSource).Rows[PendingInstructorsGrid.CurrentCell.RowIndex][0].ToString());
            }
            else
            {
                idSelected = -1;
            }
        }
        private void PendingInstructorsGrid_DataBindingComplete(object sender, EventArgs e)
        {
            PendingInstructorsGrid.ClearSelection();
        }
        private void ApproveButton_Click(object sender, EventArgs e)
        {
            if (PendingInstructorsGrid.DataSource == null)
            {
                MessageBox.Show("There are no pending instructor requests");
                return;
            }
            if (idSelected == -1)
            {
                MessageBox.Show("Select an instructor first");
                PendingInstructorsGrid.ClearSelection();
                return;
            }
                controllerObj.approveInstructor(idSelected);
                PendingInstructorsGrid.DataSource = controllerObj.SelectPendingInstructors();
                PendingInstructorsGrid.Refresh();

                PendingInstructorsGrid.ClearSelection();

                idSelected = -1;

            
        }

        private void RejectButton_Click(object sender, EventArgs e)
        {
            if (PendingInstructorsGrid.DataSource == null)
            {
                MessageBox.Show("There are no pending instructor requests");
                return;
            }
            if (idSelected == -1)
            {
                MessageBox.Show("Select an instructor first");
                PendingInstructorsGrid.ClearSelection();
                return;
            }
            controllerObj.deleteInstructor(idSelected);
            PendingInstructorsGrid.DataSource = controllerObj.SelectPendingInstructors();
            PendingInstructorsGrid.Refresh();

            PendingInstructorsGrid.ClearSelection();

            idSelected = -1;
        }
    }
}
