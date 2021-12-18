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
        public RegistrationChoice()
        {
            InitializeComponent();
        }

        private void Applicant_Reg_Button_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            ApplicantRegistration r = new ApplicantRegistration();
            r.Show();
        }

        private void Instructor_Reg_Button_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            InstructorRegistration r = new InstructorRegistration();
            r.Show();
        }

        private void Change_Password_Button_Click(object sender, EventArgs e)
        {
            Change_Password c = new Change_Password();
            c.Show();
        }
    }
}
