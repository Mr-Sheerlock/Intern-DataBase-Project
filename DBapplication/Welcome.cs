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
    public partial class Welcome : Form
    {
        Controller controllerObj;
        public Welcome()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            DataTable dt= new DataTable();
            dt=controllerObj.SelectPassword(UserName_TextBox.Text);

            if (dt == null)
            {
                MessageBox.Show("Wrong UserName");
            }
            else
            {
                string pas = dt.Rows[0][0].ToString();
               

                string key = "b14ca5898a4e4133bbce2ea2315a1916";


                //Encrypted
                pas = EncryptionClass.DecryptString(key, pas);


                if (pas == Password_TextBox.Text)
                {
                    if (dt.Rows[0][1].ToString() == "0")
                    {
                        MessageBox.Show("Sorry Your account is currently inactive");
                    }
                    else
                    {
                        //Now we check for every user type
                        if (dt.Rows[0][2].ToString() == "1")
                        {
                            //Admin
                            AdminLogin a = new AdminLogin();
                            a.Show();
                        }else if(dt.Rows[0][2].ToString() == "2")
                        {
                            //Instructor
                            InstructorLogin i = new InstructorLogin(UserName_TextBox.Text);
                            i.Show();

                        }
                        else if (dt.Rows[0][2].ToString() == "3")
                        {
                            //Intern
                            InternLogin i = new InternLogin();
                            i.Show();
                        }
                        else
                        {
                            //Applicant
                            ApplicantLogin i = new ApplicantLogin();
                            i.Show();

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            //Here we need to decide how to make other users register and if we will redirect them to a tab each
            RegistrationChoice r = new RegistrationChoice();
            r.Show();
        }
    }
}
