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
    public partial class Edit_Users : Form
    {
        Controller controllerObj;

        bool canRefresh;
        public Edit_Users()
        {
            InitializeComponent();

            canRefresh = false;

            controllerObj = new Controller();

            
            userName_textBox.DataSource = controllerObj.SelectAllUsers();
            userName_textBox.DisplayMember = "UserName";
            userName_textBox.SelectedIndex = -1;

            canRefresh = true;


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userName_textBox.SelectedIndex == -1 || !canRefresh) { return; }

            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                t.Visible = false;
            }

            foreach (Label l in this.Controls.OfType<Label>())
            {
                l.Visible = false;
            }

            DepName_textbox.Visible = false;

            label23.Visible = true; 

            DataRow r = ((DataTable)userName_textBox.DataSource).Rows[userName_textBox.SelectedIndex];

            label1.Text = "ID: " + r[0].ToString();
            label2.Text = "Type: " + (r[5].ToString().Equals("1") ? "Admin" : r[5].ToString().Equals("2") ? "Instructor" : r[5].ToString().Equals("3") ? "Intern" : "Applicant");
            Fname_textBox.Text = r[3].ToString();
            Lname_textBox.Text = r[4].ToString();
            Age_textbox.Text = r[6].ToString();
            TelephoneNum_textbox.Text = r[9].ToString();

            DataTable deps = controllerObj.SelectDepartmentNamesandNos();

            DepName_textbox.DataSource = deps;
            DepName_textbox.DisplayMember = "DepartmentName";
            DepName_textbox.SelectedIndex = -1;

            for (int i = 0; i < deps.Rows.Count; i++)
            {
               if( deps.Rows[i][1].ToString() == r[10].ToString())
                {
                    DepName_textbox.SelectedIndex = i;
                    break;
                }
            }

            if (Char.Parse((r[8].ToString()))== '1')
            {
                Active_rbtn.Checked = true;
            }
            else
            {
                pending_rbtn.Checked = true;
            }

            if (Char.Parse((r[7].ToString())) == 'M')
            {
                Male_rbtn.Checked = true;
            }
            else
            {
                Female_rbtn.Checked = true;
            }


            label1.Visible = true;
            label2.Visible = true;
            Fname_textBox.Visible = true;
            Lname_textBox.Visible = true;
            Age_textbox.Visible = true;
            TelephoneNum_textbox.Visible = true;
            DepName_textbox.Visible = r[5].ToString() != "1";
            label7.Visible = r[5].ToString() != "1";
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            button1.Visible = true;
            label10.Visible = true;
            label12.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label23.Visible = true;
            label21.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    MessageBox.Show("Please Fill in all fields");
                    return;
                }
            }

            if (DepName_textbox.SelectedIndex == -1 && label2.Text != "Type: Admin")
            {
                MessageBox.Show("Please choose a department");
                return;
            }

            short parsed;
            long telephonenumbercheck;
            if (Int16.TryParse(userName_textBox.Text, out parsed) || Int16.TryParse(Lname_textBox.Text, out parsed) || Int16.TryParse(Fname_textBox.Text, out parsed)) { MessageBox.Show("Username cannot be Numebrs allowed in username"); return; }
            if (!Int16.TryParse(Age_textbox.Text, out parsed) || parsed < 0 || parsed < 19 || parsed > 70) { MessageBox.Show("Age value is not an accepted value"); return; }
            if (!Int64.TryParse(TelephoneNum_textbox.Text, out telephonenumbercheck) || telephonenumbercheck < 0) { MessageBox.Show("No Negative Numebrs or letters allowed in Telephone Number"); return; }
            if (TelephoneNum_textbox.Text.Length != 11 || !TelephoneNum_textbox.Text.StartsWith("01")) { MessageBox.Show("Invalid Telephone Number"); return; }

            DataRow r = ((DataTable)userName_textBox.DataSource).Rows[userName_textBox.SelectedIndex];
            string depnum = "";
            if (DepName_textbox.SelectedIndex != -1)
            {
                depnum = ((DataTable)DepName_textbox.DataSource).Rows[DepName_textbox.SelectedIndex][1].ToString();
            }

            controllerObj.updateAccount(Int16.Parse(r[0].ToString()), userName_textBox.Text, r[2].ToString(), Fname_textBox.Text, Lname_textBox.Text, Char.Parse(r[5].ToString()), Int16.Parse(Age_textbox.Text), Male_rbtn.Checked ? 'M' : 'F', Active_rbtn.Checked ? '1' : '0', TelephoneNum_textbox.Text, depnum);

            label1.Visible = false;
            Fname_textBox.Visible = false;
            Lname_textBox.Visible = false;
            Age_textbox.Visible = false;
            TelephoneNum_textbox.Visible = false;
            DepName_textbox.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            label7.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            button1.Visible = false;
            label10.Visible = false;
            label12.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label23.Visible = false;
            label21.Visible = false;

            DepName_textbox.Visible = false;

            label23.Visible = true;

            canRefresh = false;
            userName_textBox.DataSource = controllerObj.SelectAllUsers();
            userName_textBox.DisplayMember = "UserName";
            userName_textBox.SelectedIndex = -1;
            canRefresh = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
