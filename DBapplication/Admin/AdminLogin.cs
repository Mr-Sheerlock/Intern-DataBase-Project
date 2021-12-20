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
        string AdminId;
        int CurrentYear;
        Controller controllerObj;
        public AdminLogin(string Adminid, int year)
        {
            InitializeComponent();
            AdminId = Adminid;
            CurrentYear = year;
            controllerObj = new Controller();
        }

        

        private void Access_Users_Button_Click(object sender, EventArgs e)
        {

        }

        private void Access_Statistics_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
