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
    public partial class Register : Form
    {
        Controller controllerObj;

        int lastID;  //Represents the last ID in the DB
        public Register()
        {
            lastID = 0;  //General Initialization
            InitializeComponent();
            controllerObj = new Controller();

            lastID = controllerObj.GetID();
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (User_Name_Textbox.Text == "" || Password_Textbox.Text=="" || Lname_Textbox.Text == "" || 
                Fname_Textbox.Text == "" || Age_Textbox.Text == "" )
            {
                MessageBox.Show("Please Fill the Empty cells.");

            }
            else
            {
                if (Job_Combobox.Text=="" || Gender_Combobox.Text=="")
                {
                    MessageBox.Show("Please Select the approporiate choice in the comboboxes.");
                }
                else
                {
                    short x;
                    if (Int16.TryParse(Age_Textbox.Text, out x)==false) {

                        MessageBox.Show("Please Write a suitable Age.");
                    }
                    else {
                        if(Lname_Textbox.Text.Any(char.IsDigit) || Fname_Textbox.Text.Any(char.IsDigit))
                        {
                            MessageBox.Show("Names can't contain digits");
                        }
                        else
                        {
                            int Job = 0;
                            char Gender = ' ';
                            if (Job_Combobox.Text == "Applicant")
                            {
                                Job = 4 +48;   //48=30h it's used for the later casting
                            }
                            else
                            {
                                Job = 2 +48;   //48=30h it's used for the later casting
                            }

                            if (Gender_Combobox.Text == "Male")
                            {
                                Gender = 'M';
                            }
                            else
                            {
                                Gender = 'F';
                            }

                            int ret= controllerObj.InsertAccount(lastID + 1, User_Name_Textbox.Text, Password_Textbox.Text, Fname_Textbox.Text, Lname_Textbox.Text, (char)(Job), Convert.ToInt16(Age_Textbox.Text), Gender);
                            if (ret != 0)
                            {
                                lastID++;
                                MessageBox.Show("Registration Successful.");
                                //this.Close();  //used to prevent the user from multiple clicking and spamming the db
                            }
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
