using DBapplication.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        

        private void Access_Users_Button_Click(object sender, EventArgs e)
        {
            Users u = new Users();
                u.Show();
        }

        private void Access_Courses_Button_Click(object sender, EventArgs e)
        {
            Courses s = new Courses();
                s.Show(); 
        }

        private void Access_Departments_Button_Click(object sender, EventArgs e)
        {
            Departments d = new Departments();
            d.Show();
        }

        private void Access_Statistics_Button_Click(object sender, EventArgs e)
        {
            Statistics sts = new Statistics();
            sts.Show();
        }
    }
}
