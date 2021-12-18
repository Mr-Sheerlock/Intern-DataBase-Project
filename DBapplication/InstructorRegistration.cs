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
    public partial class InstructorRegistration : Form
    {
        Controller controllerObj;
        int lastID;  //Represents the last ID in the DB
        bool bypass = false;
        public InstructorRegistration()
        {
            lastID = 0;  //General Initialization
            InitializeComponent();
            controllerObj = new Controller();

            lastID = controllerObj.GetID();

            DataTable dt = controllerObj.SelectDepNos();
            Departments_Combobox.DataSource = dt;
            Departments_Combobox.DisplayMember= "Department_Number";
            if (dt == null)
            {
                bypass= true;
            }

        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            if (User_Name_Textbox.Text == "" || Password_Textbox.Text == "" || Lname_Textbox.Text == "" ||
                Fname_Textbox.Text == "" || Age_Textbox.Text == "" || Telephone_Number_Textbox.Text == "")
            {
                MessageBox.Show("Please Fill the empty cells.");

            }
            else
            {
                if ( Gender_Combobox.Text == "" || (Departments_Combobox.Text =="" && !bypass) )
                {
                    MessageBox.Show("Please make the approporiate selections in the drop down lists.");
                }
                else
                {
                    short x;
                    if (Int16.TryParse(Age_Textbox.Text, out x) == false)
                    {

                        MessageBox.Show("Please write a suitable Age.");
                    }
                    else
                    {
                        long y;
                        if (Int64.TryParse(Telephone_Number_Textbox.Text, out y) == false)
                        {
                            MessageBox.Show("Please Write a suitable Telephone Number.");
                        }
                        else
                        {
                            if (Lname_Textbox.Text.Any(char.IsDigit) || Fname_Textbox.Text.Any(char.IsDigit))
                            {
                                MessageBox.Show("Names can't contain digits");
                            }
                            else
                            {
                                //check if the user is already taken
                                if (controllerObj.CheckifUserTaken(User_Name_Textbox.Text) == 1)
                                {
                                    MessageBox.Show("User Name Already Taken!");
                                }
                                else
                                {

                                    char Gender = ' ';

                                    int Job = 2 + 48;   //48=30h it's used for the later casting


                                    if (Gender_Combobox.Text == "Male")
                                    {
                                        Gender = 'M';
                                    }
                                    else
                                    {
                                        Gender = 'F';
                                    }


                                    //Encrypted Version
                                    string key = "b14ca5898a4e4133bbce2ea2315a1916";
                                    string pas = EncryptionClass.EncryptString(key, Password_Textbox.Text.ToString());
                                    int ret = controllerObj.InsertAccount(lastID + 1, User_Name_Textbox.Text, pas, Fname_Textbox.Text, Lname_Textbox.Text, (char)(Job), Convert.ToInt16(Age_Textbox.Text), Gender, Telephone_Number_Textbox.Text, Departments_Combobox.Text);

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
            }
        }
    }
}
 
