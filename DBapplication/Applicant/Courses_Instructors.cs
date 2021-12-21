using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication.Applicant
{
    public partial class Courses_Instructors : Form
    {
        DataTable dt;
        public Courses_Instructors(DataTable Dt)
        {
            InitializeComponent();

            dt = Dt;
        }
    }
}
