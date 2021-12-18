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
    
    public partial class Change_Password : Form
    {
        Controller controllerObj;
        public Change_Password()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Change_Password_Button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controllerObj.SelectPassword(UserName_TextBox.Text);

            if (dt == null)
            {
                MessageBox.Show("Wrong UserName");
            }
            else
            {
                string oldpas = dt.Rows[0][0].ToString();


                string key = "b14ca5898a4e4133bbce2ea2315a1916";


                //Encrypted
                oldpas = EncryptionClass.DecryptString(key, oldpas);


                if (oldpas == Password_TextBox.Text)
                {
                    //Update Password

                    string newpas = EncryptionClass.EncryptString(key, NewPassword_Textbox.Text);

                    controllerObj.ChangePassword(UserName_TextBox.Text , newpas);

                    MessageBox.Show("Password Changed Successfully!");

                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
        }
    }
}
