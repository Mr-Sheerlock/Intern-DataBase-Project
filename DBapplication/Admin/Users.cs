using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication.Admin
{
    public partial class Users : Form
    {
        //USEFUL FUNCTIONS  ADDED BY OZER 
        int jobCode = -1;
        //1 : Admin , 2:Instructor , 3:Intern , 4:Applicant 
        //Pass it to the next form 
        public void HideAllButtons()
        {
            foreach (Button b in this.Controls.OfType<Button>())
            {
                b.Visible = false;
            }
        }

        static string NullToString(object Value)
        {

            // Value.ToString() allows for Value being DBNull, but will also convert int, double, etc.
            bool emptys = string.IsNullOrEmpty(Value.ToString());
            if (emptys)
            {
                return "null";
            }
            else
            {
                return Value.ToString();
            }
            // If this is not what you want then this form may suit you better, handles 'Null' and DBNull otherwise tries a straight cast
            // which will throw if Value isn't actually a string object.
            //return Value == null || Value == DBNull.Value ? "" : (string)Value;
        }
        public Users()
        {
           
            InitializeComponent();
            AddUser_BTN.Visible = false;
            BacktoUsers_BTN.Visible = false;
            RemoveUser_BTN.Visible = false;
            Add_remove_lbl.Visible = false;
        }

        


        private void UserAdmin_BTN_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            AddUser_BTN.Visible = true;
            RemoveUser_BTN.Visible = true;
            BacktoUsers_BTN.Visible = true;
            Add_remove_lbl.Visible = true;
            jobCode = 1;
        }

       
        private void UserInstructor_BTN_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            AddUser_BTN.Visible = true;
            RemoveUser_BTN.Visible = true;
            Add_remove_lbl.Visible = true;
            BacktoUsers_BTN.Visible = true;
            jobCode = 2;
        }

        private void UserIntern_BTN_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            AddUser_BTN.Visible = true;
            RemoveUser_BTN.Visible = true;
            BacktoUsers_BTN.Visible = true;
            Add_remove_lbl.Visible = true;
            jobCode = 3;
        }

        private void UserApplicants_BTN_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            AddUser_BTN.Visible = true;
            RemoveUser_BTN.Visible = true;
            Add_remove_lbl.Visible = true;
            BacktoUsers_BTN.Visible = true;
            jobCode = 4;
        }

        private void AddUser_BTN_Click(object sender, EventArgs e)
        {

            AddRemoveUsers addUser = new AddRemoveUsers(jobCode, "add");
            addUser.Show();
            
        }

        private void RemoveUser_BTN_Click(object sender, EventArgs e)
        {
            AddRemoveUsers removeUser = new AddRemoveUsers(jobCode, "remove");
            removeUser.Show();
            
        }

        private void BacktoUsersMainMenu_BTN_Click(object sender, EventArgs e)
        {
            UserAdmin_BTN.Visible = true;
            UserIntern_BTN.Visible = true;
            UserInstructor_BTN.Visible = true;
            UserApplicants_BTN.Visible = true;
            AddUser_BTN.Visible = false;
            RemoveUser_BTN.Visible = false;
            Add_remove_lbl.Visible = false;
            BacktoUsers_BTN.Visible = false;
        }
    }
}
