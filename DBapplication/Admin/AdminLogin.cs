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

        

        private void Add_Users_Button_Click(object sender, EventArgs e)
        {
            AddUsers u = new AddUsers();
            u.Show();
        }

        private void Edit_Users_button_Click(object sender, EventArgs e)
        {
            Edit_Users edit = new Edit_Users();
            edit.Show();
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

        private void Approve_Instructor_BTN_Click(object sender, EventArgs e)
        {
            Approve_Instructor instr = new Approve_Instructor();
            instr.Show();

        }

        private void Access_Statistics_Button_Click(object sender, EventArgs e)
        {
            Statistics sts = new Statistics();
            sts.Show();
        }

        
    }
}
