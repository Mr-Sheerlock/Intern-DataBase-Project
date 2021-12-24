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


    public partial class AddRemoveUsers : Form
    {

        //USEFUL FUNCTIONS  ADDED BY OZER 
        int jobCode;
        Controller controllerObj;

        public void HideAllPanels()
        {
            foreach (Panel p in this.Controls.OfType<Panel>())
            {
                p.Visible = false;
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
        public AddRemoveUsers(int jobCode,string operation)
        {
            InitializeComponent();

            this.jobCode = jobCode;
            controllerObj = new Controller();
            DepName_textbox.DataSource = controllerObj.SelectDepartmentNamesandNos();
            DepName_textbox.DisplayMember = "DepartmentName";
            DepName_textbox.SelectedIndex = -1;

            HideAllPanels();
            BacktoUsers_BTN.Dock = (DockStyle.Right & DockStyle.Bottom);
            if (jobCode == 1 && operation == "add") { HideAllPanels(); AddUsers_panel.Visible = true; AddUsers_panel.Dock = DockStyle.Left; groupBox2.Enabled = groupBox2.Visible = label15.Visible = label17.Visible = DepName_textbox.Visible = DepName_textbox.Enabled = false;   }
            if (jobCode == 2 && operation == "add") { HideAllPanels(); AddUsers_panel.Visible = true; AddUsers_panel.Dock = DockStyle.Left; groupBox2.Enabled = groupBox2.Visible = label15.Visible = false; }
            if (jobCode == 3 && operation == "add") { HideAllPanels(); AddUsers_panel.Visible = true; AddUsers_panel.Dock = DockStyle.Left; }
            if (jobCode == 4 && operation == "add") { HideAllPanels(); AddApplicant_panel.Visible = true; AddApplicant_panel.Dock = DockStyle.Left; }
            if (jobCode == 1 && operation == "remove") { HideAllPanels(); RemoveAdmin_panel.Visible = true; RemoveAdmin_panel.Dock = DockStyle.Left; }
            if (jobCode == 2 && operation == "remove") { HideAllPanels(); RemoveInstructor_panel.Visible = true; RemoveInstructor_panel.Dock = DockStyle.Left; }
            if (jobCode == 3 && operation == "remove") { HideAllPanels(); RemoveIntern_panel.Visible = true; RemoveIntern_panel.Dock = DockStyle.Left; }
            if (jobCode == 4 && operation == "remove") { HideAllPanels(); RemoveApplicant_panel.Visible = true; RemoveApplicant_panel.Dock = DockStyle.Left; }
            //TODO : FILL REMOVE COMBOBOXES WITH DATA FROM DATABASE 
        }

        private void BacktoUsers_BTN_Click(object sender, EventArgs e)
        {
            //IT WON'T OPEN ANOTHER FORM IF THE FIRST IS ALREADY ACTIVE 

            var form = Application.OpenForms.OfType<AddUsers>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                new AddUsers().Show();
            }

            this.Close();

        }

        private void RemoveAdmin_BTN_Click(object sender, EventArgs e)
        {
            if (RemoveAdmin_cmbox.SelectedIndex <0) { MessageBox.Show("Please Choose a valid entry"); return; }
            string message = "Do you want to Remove this admin?";
            string title = "Remove Admin";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Cancel || result== DialogResult.No)
            {
                return;
            }
            else if(result == DialogResult.Yes)
            {
                //TODO : IMPLEMENT REMOVE FUNCTION
            }
            RemoveAdmin_cmbox.SelectedIndex = -1;

        }



        private void RemoveApplicant_BTN_Click(object sender, EventArgs e)
        {
            if (RemoveApplicant_cmbox.SelectedIndex == -1) { MessageBox.Show("Please Choose a valid entry"); return; }
            string message = "Do you want to remove this Applicant?";
            string title = "Reject Applicant";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Cancel || result == DialogResult.No)
            {
                return;
            }
            else if (result == DialogResult.Yes)
            {
                //TODO : IMPLEMENT REMOVE FUNCTION
            }
            RemoveApplicant_cmbox.SelectedIndex = -1;
        }

        private void RemoveIntern_BTN_Click(object sender, EventArgs e)
        {
            if (RemoveIntern_cmbox.SelectedIndex < 0) { MessageBox.Show("Please Choose a valid entry"); return; }
            string message = "Do you want to remove this Intern?";
            string title = "Remove Intern";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Cancel || result == DialogResult.No)
            {
                return;
            }
            else if (result == DialogResult.Yes)
            {
                //TODO : IMPLEMENT REMOVE FUNCTION
            }
            RemoveIntern_cmbox.SelectedIndex = -1;
        }

        private void RemoveInstructor_BTN_Click(object sender, EventArgs e)
        {
            if (RemoveInstructor_cmbox.SelectedIndex < 0) { MessageBox.Show("Please Choose a valid entry"); return; }
            string message = "Do you want to remove this Instructor?";
            string title = "Remove Instructor";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Cancel || result == DialogResult.No)
            {
                return;
            }
            else if (result == DialogResult.Yes)
            {
                //TODO : IMPLEMENT REMOVE FUNCTION
            }
            RemoveInstructor_cmbox.SelectedIndex = -1;
        }

        private void AddUsers_BTN_Click(object sender, EventArgs e)
        {
            //BEHOLD THE TON OF VERIFICATIONS AND FUNCTIONS DEPENDING ON THEM 
            char gender, status = '1';
            foreach (var control in AddUsers_panel.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    MessageBox.Show("Please Fill in all fields");
                    return;
                }
            }
            if (DepName_textbox.SelectedIndex == -1 && jobCode != 1) 
            {
                 MessageBox.Show("Please choose a department");
                 return;
            }
            if (Male_rbtn.Checked == false && Female_rbtn.Checked == false) { MessageBox.Show("Choose Gender"); return; }
            else { gender = (Male_rbtn.Checked == true ?'M' : 'F'); }
            if (groupBox2.Enabled && Active_rbtn.Checked == false && pending_rbtn.Checked == false) { MessageBox.Show("Choose Status"); return; }
            else if (groupBox2.Enabled) { status = (Active_rbtn.Checked == true ? '1' : '0'); }
            short parsed;
            long telephonenumbercheck;
            if (Int16.TryParse(userName_textBox.Text,out parsed) || Int16.TryParse(Lname_textBox.Text, out parsed) || Int16.TryParse(Fname_textBox.Text, out parsed)) { MessageBox.Show("Username cannot be Numebrs allowed in username"); return; }
            if (!Int16.TryParse(Age_textbox.Text,out parsed) || parsed < 0 || parsed < 19 || parsed > 70 ) { MessageBox.Show("Age value is not an accepted value"); return; }
            if (!Int64.TryParse(TelephoneNum_textbox.Text,out telephonenumbercheck) || telephonenumbercheck < 0) { MessageBox.Show("No Negative Numebrs or letters allowed in Telephone Number"); return; }
            if (TelephoneNum_textbox.Text.Length != 11 || !TelephoneNum_textbox.Text.StartsWith("01")) { MessageBox.Show("Invalid Telephone Number"); return; }
            if (controllerObj.CheckifUserTaken(userName_textBox.Text) == 1){ MessageBox.Show("User Name Already Taken!"); return; }

            int lastID = controllerObj.GetLastUserID();
            string key = "b14ca5898a4e4133bbce2ea2315a1916";
            string pas = EncryptionClass.EncryptString(key, Pass_textBox.Text.ToString());
            string depnum = "";
            if (jobCode != 1)
            {
                depnum = ((DataTable)DepName_textbox.DataSource).Rows[DepName_textbox.SelectedIndex][1].ToString();
            }

            controllerObj.InsertAccount(lastID + 1, userName_textBox.Text, pas, Fname_textBox.Text, Lname_textBox.Text, Char.Parse(jobCode.ToString()), Int16.Parse(Age_textbox.Text), gender, status, TelephoneNum_textbox.Text, depnum);

            foreach (var control in AddUsers_panel.Controls.OfType<TextBox>())
            {
                control.Clear();
            }
            foreach (var control in AddUsers_panel.Controls.OfType<ComboBox>())
            {
                control.SelectedIndex = -1;
            }
            foreach (var control in AddUsers_panel.Controls.OfType<RadioButton>())
            {
                control.Checked = false;
            }


        }

        private void AddApplicant_BTN_Click(object sender, EventArgs e)
        {
            if (AddApplicant_cmbox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a valid entry");
                return;
            }
            else
            {
                //EXECUTE ACCEPT 
            }
        }

        private void JBcode_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                


        }

        private void Active_rbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void DepNum_textbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pass_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
