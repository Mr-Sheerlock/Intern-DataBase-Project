﻿using System;
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
    public partial class InstructorLogin : Form
    {
        Controller controllerObj;
        string instructorUser;
        public InstructorLogin(string insUser)
        {
            //We need to pass certain information here for the instructor, like the associated department and course etc 
            //in order to determine the associated applicants
            InitializeComponent();
            controllerObj = new Controller();
            instructorUser = insUser;

            //Get the correspondng course, if there is no corresponding course, then disable the course functionalities

        }

        private void InstructorLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
