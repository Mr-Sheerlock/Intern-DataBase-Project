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

    public partial class Applicant_ExtraInfo : Form
    {
        string AppID;
        Controller controllerObj;
        public Applicant_ExtraInfo(string Appid)
        {
            AppID = Appid;
            InitializeComponent();
            controllerObj = new Controller();


        }

        private void Complete_Registration_Button_Click(object sender, EventArgs e)
        {
            if (CollegeName_Textbox.Text == "" || Years_TextBox.Text == "" || CV_TextBox.Text == "")
            {
                MessageBox.Show("Please Fill the Empty cells.");

            }
            else
            {
                short x;
                if (Int16.TryParse(Years_TextBox.Text, out x) == false || Convert.ToInt16(Years_TextBox.Text)<0)
                {
                    MessageBox.Show("Please write suitable years of experience.");
                }
                else
                {
                    if (CollegeName_Textbox.Text.Any(char.IsDigit))
                    {
                        MessageBox.Show("Names can't contain digits");
                    }
                    else
                    {
                        controllerObj.CompleteRegistration(AppID, CollegeName_Textbox.Text, Convert.ToInt16(Years_TextBox.Text), CV_TextBox.Text);
                        MessageBox.Show("Registration Complete!");
                        this.Close();
                    }
                }
            }
        }
        
    
    }
}
