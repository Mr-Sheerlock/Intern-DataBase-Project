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
    public partial class RegistrationChoice : Form
    {

        Controller controllerObj;
        public RegistrationChoice()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Applicant_Reg_Button_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            ApplicantRegistration r = new ApplicantRegistration();
            r.Show();
        }

        private void Instructor_Reg_Button_Click(object sender, EventArgs e)
        {

            if(controllerObj.SelectDepartments() == null)
            {

                MessageBox.Show("There are no departments available.");
                Instructor_Reg_Button.Enabled = false;  
            }
            else
            {
                InitializeComponent();
                InstructorRegistration r = new InstructorRegistration();
                r.Show();

            }
           
        }

   
    }
}
