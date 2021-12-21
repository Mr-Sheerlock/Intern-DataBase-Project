using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication.Intern
{
    public partial class Lectures_view : Form
    {
        DataTable dt;
        public Lectures_view(DataTable dT)
        {
            InitializeComponent();
            dt = dT;

            LecturesGrid.DataSource= dt;
        }
    }
}
