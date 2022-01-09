
namespace DBapplication.Admin
{
    partial class Departments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteDepartment_BTN = new System.Windows.Forms.Button();
            this.Delete_Department_Panel = new System.Windows.Forms.Panel();
            this.DelDep_cmbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DepOpMenu_cmbox = new System.Windows.Forms.ComboBox();
            this.Add_Department_Panel = new System.Windows.Forms.Panel();
            this.AddDepartment_BTN = new System.Windows.Forms.Button();
            this.dname_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Edit_Department_Panel = new System.Windows.Forms.Panel();
            this.EditDepartment_BTN = new System.Windows.Forms.Button();
            this.EditDep_cmbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete_Department_Panel.SuspendLayout();
            this.Add_Department_Panel.SuspendLayout();
            this.Edit_Department_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Department Name: ";
            // 
            // DeleteDepartment_BTN
            // 
            this.DeleteDepartment_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteDepartment_BTN.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteDepartment_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteDepartment_BTN.Location = new System.Drawing.Point(20, 48);
            this.DeleteDepartment_BTN.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteDepartment_BTN.Name = "DeleteDepartment_BTN";
            this.DeleteDepartment_BTN.Size = new System.Drawing.Size(167, 40);
            this.DeleteDepartment_BTN.TabIndex = 10;
            this.DeleteDepartment_BTN.Text = "Delete";
            this.DeleteDepartment_BTN.UseVisualStyleBackColor = true;
            this.DeleteDepartment_BTN.Click += new System.EventHandler(this.DeleteDepartment_BTN_Click);
            // 
            // Delete_Department_Panel
            // 
            this.Delete_Department_Panel.Controls.Add(this.DeleteDepartment_BTN);
            this.Delete_Department_Panel.Controls.Add(this.DelDep_cmbox);
            this.Delete_Department_Panel.Controls.Add(this.label6);
            this.Delete_Department_Panel.Location = new System.Drawing.Point(11, 183);
            this.Delete_Department_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_Department_Panel.Name = "Delete_Department_Panel";
            this.Delete_Department_Panel.Size = new System.Drawing.Size(215, 111);
            this.Delete_Department_Panel.TabIndex = 7;
            // 
            // DelDep_cmbox
            // 
            this.DelDep_cmbox.FormattingEnabled = true;
            this.DelDep_cmbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.DelDep_cmbox.Location = new System.Drawing.Point(105, 12);
            this.DelDep_cmbox.Margin = new System.Windows.Forms.Padding(2);
            this.DelDep_cmbox.Name = "DelDep_cmbox";
            this.DelDep_cmbox.Size = new System.Drawing.Size(82, 21);
            this.DelDep_cmbox.TabIndex = 1;
            this.DelDep_cmbox.SelectedIndexChanged += new System.EventHandler(this.DelDep_cmbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose an operation: ";
            // 
            // DepOpMenu_cmbox
            // 
            this.DepOpMenu_cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepOpMenu_cmbox.FormattingEnabled = true;
            this.DepOpMenu_cmbox.Items.AddRange(new object[] {
            "Add Department ",
            "Edit Department"});
            this.DepOpMenu_cmbox.Location = new System.Drawing.Point(344, 36);
            this.DepOpMenu_cmbox.Margin = new System.Windows.Forms.Padding(2);
            this.DepOpMenu_cmbox.Name = "DepOpMenu_cmbox";
            this.DepOpMenu_cmbox.Size = new System.Drawing.Size(149, 21);
            this.DepOpMenu_cmbox.TabIndex = 4;
            this.DepOpMenu_cmbox.SelectedIndexChanged += new System.EventHandler(this.DepOpMenu_cmbox_SelectedIndexChanged);
            // 
            // Add_Department_Panel
            // 
            this.Add_Department_Panel.Controls.Add(this.AddDepartment_BTN);
            this.Add_Department_Panel.Controls.Add(this.dname_txtbox);
            this.Add_Department_Panel.Controls.Add(this.label2);
            this.Add_Department_Panel.Location = new System.Drawing.Point(11, 23);
            this.Add_Department_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Department_Panel.Name = "Add_Department_Panel";
            this.Add_Department_Panel.Size = new System.Drawing.Size(213, 112);
            this.Add_Department_Panel.TabIndex = 8;
            // 
            // AddDepartment_BTN
            // 
            this.AddDepartment_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddDepartment_BTN.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDepartment_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddDepartment_BTN.Location = new System.Drawing.Point(21, 54);
            this.AddDepartment_BTN.Margin = new System.Windows.Forms.Padding(2);
            this.AddDepartment_BTN.Name = "AddDepartment_BTN";
            this.AddDepartment_BTN.Size = new System.Drawing.Size(166, 40);
            this.AddDepartment_BTN.TabIndex = 9;
            this.AddDepartment_BTN.Text = "Add";
            this.AddDepartment_BTN.UseVisualStyleBackColor = true;
            this.AddDepartment_BTN.Click += new System.EventHandler(this.AddDepartment_BTN_Click);
            // 
            // dname_txtbox
            // 
            this.dname_txtbox.Location = new System.Drawing.Point(108, 8);
            this.dname_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.dname_txtbox.Name = "dname_txtbox";
            this.dname_txtbox.Size = new System.Drawing.Size(96, 20);
            this.dname_txtbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Department Name : ";
            // 
            // Edit_Department_Panel
            // 
            this.Edit_Department_Panel.Controls.Add(this.EditDepartment_BTN);
            this.Edit_Department_Panel.Controls.Add(this.EditDep_cmbox);
            this.Edit_Department_Panel.Controls.Add(this.label3);
            this.Edit_Department_Panel.Location = new System.Drawing.Point(249, 183);
            this.Edit_Department_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Edit_Department_Panel.Name = "Edit_Department_Panel";
            this.Edit_Department_Panel.Size = new System.Drawing.Size(215, 111);
            this.Edit_Department_Panel.TabIndex = 9;
            // 
            // EditDepartment_BTN
            // 
            this.EditDepartment_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditDepartment_BTN.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDepartment_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditDepartment_BTN.Location = new System.Drawing.Point(20, 48);
            this.EditDepartment_BTN.Margin = new System.Windows.Forms.Padding(2);
            this.EditDepartment_BTN.Name = "EditDepartment_BTN";
            this.EditDepartment_BTN.Size = new System.Drawing.Size(167, 40);
            this.EditDepartment_BTN.TabIndex = 10;
            this.EditDepartment_BTN.Text = "Edit";
            this.EditDepartment_BTN.UseVisualStyleBackColor = true;
            this.EditDepartment_BTN.Visible = false;
            this.EditDepartment_BTN.Click += new System.EventHandler(this.EditDepartment_BTN_Click);
            // 
            // EditDep_cmbox
            // 
            this.EditDep_cmbox.FormattingEnabled = true;
            this.EditDep_cmbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.EditDep_cmbox.Location = new System.Drawing.Point(105, 12);
            this.EditDep_cmbox.Margin = new System.Windows.Forms.Padding(2);
            this.EditDep_cmbox.Name = "EditDep_cmbox";
            this.EditDep_cmbox.Size = new System.Drawing.Size(82, 21);
            this.EditDep_cmbox.TabIndex = 1;
            this.EditDep_cmbox.SelectedIndexChanged += new System.EventHandler(this.EditDep_cmbox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Department Name: ";
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 143);
            this.Controls.Add(this.Edit_Department_Panel);
            this.Controls.Add(this.Add_Department_Panel);
            this.Controls.Add(this.Delete_Department_Panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepOpMenu_cmbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Departments";
            this.Text = "Departments";
            this.Delete_Department_Panel.ResumeLayout(false);
            this.Delete_Department_Panel.PerformLayout();
            this.Add_Department_Panel.ResumeLayout(false);
            this.Add_Department_Panel.PerformLayout();
            this.Edit_Department_Panel.ResumeLayout(false);
            this.Edit_Department_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeleteDepartment_BTN;
        private System.Windows.Forms.Panel Delete_Department_Panel;
        private System.Windows.Forms.ComboBox DelDep_cmbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DepOpMenu_cmbox;
        private System.Windows.Forms.Panel Add_Department_Panel;
        private System.Windows.Forms.Button AddDepartment_BTN;
        private System.Windows.Forms.TextBox dname_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Edit_Department_Panel;
        private System.Windows.Forms.Button EditDepartment_BTN;
        private System.Windows.Forms.ComboBox EditDep_cmbox;
        private System.Windows.Forms.Label label3;
    }
}