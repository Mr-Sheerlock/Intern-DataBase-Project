
namespace DBapplication.Admin
{
    partial class Courses
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
            this.CourseOpMenu_cmbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Course_Panel = new System.Windows.Forms.Panel();
            this.AddCourse_BTN = new System.Windows.Forms.Button();
            this.CtrlDep_cmbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InactiveCourseRadBtn1 = new System.Windows.Forms.RadioButton();
            this.ActiveCourseRadBtn1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cid_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cname_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Update_Course_Panel = new System.Windows.Forms.Panel();
            this.UpdateCourse_BTN = new System.Windows.Forms.Button();
            this.updateCourse_cmbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Add_Course_Panel.SuspendLayout();
            this.Update_Course_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseOpMenu_cmbox
            // 
            this.CourseOpMenu_cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseOpMenu_cmbox.FormattingEnabled = true;
            this.CourseOpMenu_cmbox.Items.AddRange(new object[] {
            "Add Course ",
            "Update Course (Activate/Deactivate)"});
            this.CourseOpMenu_cmbox.Location = new System.Drawing.Point(376, 5);
            this.CourseOpMenu_cmbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CourseOpMenu_cmbox.Name = "CourseOpMenu_cmbox";
            this.CourseOpMenu_cmbox.Size = new System.Drawing.Size(294, 21);
            this.CourseOpMenu_cmbox.TabIndex = 0;
            this.CourseOpMenu_cmbox.SelectedIndexChanged += new System.EventHandler(this.CourseOpMenu_cmbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose an operation: ";
            // 
            // Add_Course_Panel
            // 
            this.Add_Course_Panel.Controls.Add(this.AddCourse_BTN);
            this.Add_Course_Panel.Controls.Add(this.CtrlDep_cmbox);
            this.Add_Course_Panel.Controls.Add(this.label5);
            this.Add_Course_Panel.Controls.Add(this.InactiveCourseRadBtn1);
            this.Add_Course_Panel.Controls.Add(this.ActiveCourseRadBtn1);
            this.Add_Course_Panel.Controls.Add(this.label4);
            this.Add_Course_Panel.Controls.Add(this.cid_txtbox);
            this.Add_Course_Panel.Controls.Add(this.label3);
            this.Add_Course_Panel.Controls.Add(this.cname_txtbox);
            this.Add_Course_Panel.Controls.Add(this.label2);
            this.Add_Course_Panel.Location = new System.Drawing.Point(9, 93);
            this.Add_Course_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_Course_Panel.Name = "Add_Course_Panel";
            this.Add_Course_Panel.Size = new System.Drawing.Size(214, 332);
            this.Add_Course_Panel.TabIndex = 2;
            // 
            // AddCourse_BTN
            // 
            this.AddCourse_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCourse_BTN.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCourse_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddCourse_BTN.Location = new System.Drawing.Point(45, 289);
            this.AddCourse_BTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCourse_BTN.Name = "AddCourse_BTN";
            this.AddCourse_BTN.Size = new System.Drawing.Size(166, 40);
            this.AddCourse_BTN.TabIndex = 9;
            this.AddCourse_BTN.Text = "Add";
            this.AddCourse_BTN.UseVisualStyleBackColor = true;
            this.AddCourse_BTN.Click += new System.EventHandler(this.AddCourse_BTN_Click);
            // 
            // CtrlDep_cmbox
            // 
            this.CtrlDep_cmbox.FormattingEnabled = true;
            this.CtrlDep_cmbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CtrlDep_cmbox.Location = new System.Drawing.Point(112, 97);
            this.CtrlDep_cmbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CtrlDep_cmbox.Name = "CtrlDep_cmbox";
            this.CtrlDep_cmbox.Size = new System.Drawing.Size(35, 21);
            this.CtrlDep_cmbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Department Number:";
            // 
            // InactiveCourseRadBtn1
            // 
            this.InactiveCourseRadBtn1.AutoSize = true;
            this.InactiveCourseRadBtn1.Location = new System.Drawing.Point(137, 64);
            this.InactiveCourseRadBtn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InactiveCourseRadBtn1.Name = "InactiveCourseRadBtn1";
            this.InactiveCourseRadBtn1.Size = new System.Drawing.Size(63, 17);
            this.InactiveCourseRadBtn1.TabIndex = 6;
            this.InactiveCourseRadBtn1.TabStop = true;
            this.InactiveCourseRadBtn1.Text = "Inactive";
            this.InactiveCourseRadBtn1.UseVisualStyleBackColor = true;
            // 
            // ActiveCourseRadBtn1
            // 
            this.ActiveCourseRadBtn1.AutoSize = true;
            this.ActiveCourseRadBtn1.Location = new System.Drawing.Point(82, 64);
            this.ActiveCourseRadBtn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ActiveCourseRadBtn1.Name = "ActiveCourseRadBtn1";
            this.ActiveCourseRadBtn1.Size = new System.Drawing.Size(55, 17);
            this.ActiveCourseRadBtn1.TabIndex = 5;
            this.ActiveCourseRadBtn1.TabStop = true;
            this.ActiveCourseRadBtn1.Text = "Active";
            this.ActiveCourseRadBtn1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course Status:";
            // 
            // cid_txtbox
            // 
            this.cid_txtbox.Location = new System.Drawing.Point(86, 32);
            this.cid_txtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cid_txtbox.Name = "cid_txtbox";
            this.cid_txtbox.Size = new System.Drawing.Size(36, 20);
            this.cid_txtbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course ID:";
            // 
            // cname_txtbox
            // 
            this.cname_txtbox.Location = new System.Drawing.Point(86, 7);
            this.cname_txtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cname_txtbox.Name = "cname_txtbox";
            this.cname_txtbox.Size = new System.Drawing.Size(96, 20);
            this.cname_txtbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course Name : ";
            // 
            // Update_Course_Panel
            // 
            this.Update_Course_Panel.Controls.Add(this.UpdateCourse_BTN);
            this.Update_Course_Panel.Controls.Add(this.updateCourse_cmbox);
            this.Update_Course_Panel.Controls.Add(this.label6);
            this.Update_Course_Panel.Location = new System.Drawing.Point(227, 93);
            this.Update_Course_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update_Course_Panel.Name = "Update_Course_Panel";
            this.Update_Course_Panel.Size = new System.Drawing.Size(215, 332);
            this.Update_Course_Panel.TabIndex = 3;
            // 
            // UpdateCourse_BTN
            // 
            this.UpdateCourse_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateCourse_BTN.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCourse_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateCourse_BTN.Location = new System.Drawing.Point(46, 289);
            this.UpdateCourse_BTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateCourse_BTN.Name = "UpdateCourse_BTN";
            this.UpdateCourse_BTN.Size = new System.Drawing.Size(166, 40);
            this.UpdateCourse_BTN.TabIndex = 10;
            this.UpdateCourse_BTN.Text = "Update";
            this.UpdateCourse_BTN.UseVisualStyleBackColor = true;
            this.UpdateCourse_BTN.Click += new System.EventHandler(this.UpdateCourse_BTN_Click);
            // 
            // updateCourse_cmbox
            // 
            this.updateCourse_cmbox.FormattingEnabled = true;
            this.updateCourse_cmbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.updateCourse_cmbox.Location = new System.Drawing.Point(84, 13);
            this.updateCourse_cmbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateCourse_cmbox.Name = "updateCourse_cmbox";
            this.updateCourse_cmbox.Size = new System.Drawing.Size(50, 21);
            this.updateCourse_cmbox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Course ID : ";
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 489);
            this.Controls.Add(this.Update_Course_Panel);
            this.Controls.Add(this.Add_Course_Panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseOpMenu_cmbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Courses";
            this.Text = "Courses";
            this.Add_Course_Panel.ResumeLayout(false);
            this.Add_Course_Panel.PerformLayout();
            this.Update_Course_Panel.ResumeLayout(false);
            this.Update_Course_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CourseOpMenu_cmbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Add_Course_Panel;
        private System.Windows.Forms.ComboBox CtrlDep_cmbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton InactiveCourseRadBtn1;
        private System.Windows.Forms.RadioButton ActiveCourseRadBtn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cid_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cname_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Update_Course_Panel;
        private System.Windows.Forms.ComboBox updateCourse_cmbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddCourse_BTN;
        private System.Windows.Forms.Button UpdateCourse_BTN;
    }
}