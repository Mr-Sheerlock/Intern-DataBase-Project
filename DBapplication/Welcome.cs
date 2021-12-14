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
            dt=controllerObj.SelectPassword(ID_TextBox.Text);

            if (dt == null)
            {
                MessageBox.Show("Wrong ID");
            }
            else
            {
                string pas = dt.Rows[0][0].ToString();
                if (pas == Password_TextBox.Text)
                {
                    AdminLogin a = new AdminLogin();
                    a.Show();
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
        }
    }
}
