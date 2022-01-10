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
    public partial class ViewAdmins : Form
    {
        Controller controllerObj;
        public ViewAdmins()
        {
            InitializeComponent();
            controllerObj = new Controller();
            AdminDataGrid.DataSource = controllerObj.SelectAdminInfo();
            AdminDataGrid.Refresh();
        }

        private void InternsGradesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
