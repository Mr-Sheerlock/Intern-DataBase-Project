namespace DBapplication
{
    partial class AdminLogin
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
            this.Add_Users_Button = new System.Windows.Forms.Button();
            this.Access_Departments_Button = new System.Windows.Forms.Button();
            this.Access_Courses_Button = new System.Windows.Forms.Button();
            this.Access_Lectures_Button = new System.Windows.Forms.Button();
            this.Access_Statistics_Button = new System.Windows.Forms.Button();
            this.Edit_Users_button = new System.Windows.Forms.Button();
            this.Approve_Instructor_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Users_Button
            // 
            this.Add_Users_Button.Location = new System.Drawing.Point(53, 54);
            this.Add_Users_Button.Name = "Add_Users_Button";
            this.Add_Users_Button.Size = new System.Drawing.Size(109, 23);
            this.Add_Users_Button.TabIndex = 0;
            this.Add_Users_Button.Text = "Add Users";
            this.Add_Users_Button.UseVisualStyleBackColor = true;
            this.Add_Users_Button.Click += new System.EventHandler(this.Add_Users_Button_Click);
            // 
            // Access_Departments_Button
            // 
            this.Access_Departments_Button.Location = new System.Drawing.Point(53, 112);
            this.Access_Departments_Button.Name = "Access_Departments_Button";
            this.Access_Departments_Button.Size = new System.Drawing.Size(109, 23);
            this.Access_Departments_Button.TabIndex = 1;
            this.Access_Departments_Button.Text = "Departments";
            this.Access_Departments_Button.UseVisualStyleBackColor = true;
            this.Access_Departments_Button.Click += new System.EventHandler(this.Access_Departments_Button_Click);
            // 
            // Access_Courses_Button
            // 
            this.Access_Courses_Button.Location = new System.Drawing.Point(53, 228);
            this.Access_Courses_Button.Name = "Access_Courses_Button";
            this.Access_Courses_Button.Size = new System.Drawing.Size(109, 23);
            this.Access_Courses_Button.TabIndex = 2;
            this.Access_Courses_Button.Text = "Courses";
            this.Access_Courses_Button.UseVisualStyleBackColor = true;
            this.Access_Courses_Button.Visible = false;
            this.Access_Courses_Button.Click += new System.EventHandler(this.Access_Courses_Button_Click);
            // 
            // Access_Lectures_Button
            // 
            this.Access_Lectures_Button.Location = new System.Drawing.Point(53, 199);
            this.Access_Lectures_Button.Name = "Access_Lectures_Button";
            this.Access_Lectures_Button.Size = new System.Drawing.Size(109, 23);
            this.Access_Lectures_Button.TabIndex = 3;
            this.Access_Lectures_Button.Text = "Lectures";
            this.Access_Lectures_Button.UseVisualStyleBackColor = true;
            this.Access_Lectures_Button.Visible = false;
            // 
            // Access_Statistics_Button
            // 
            this.Access_Statistics_Button.Location = new System.Drawing.Point(53, 170);
            this.Access_Statistics_Button.Name = "Access_Statistics_Button";
            this.Access_Statistics_Button.Size = new System.Drawing.Size(109, 23);
            this.Access_Statistics_Button.TabIndex = 4;
            this.Access_Statistics_Button.Text = "Statistics";
            this.Access_Statistics_Button.UseVisualStyleBackColor = true;
            this.Access_Statistics_Button.Click += new System.EventHandler(this.Access_Statistics_Button_Click);
            // 
            // Edit_Users_button
            // 
            this.Edit_Users_button.Location = new System.Drawing.Point(53, 83);
            this.Edit_Users_button.Name = "Edit_Users_button";
            this.Edit_Users_button.Size = new System.Drawing.Size(109, 23);
            this.Edit_Users_button.TabIndex = 5;
            this.Edit_Users_button.Text = "Edit Users";
            this.Edit_Users_button.UseVisualStyleBackColor = true;
            this.Edit_Users_button.Click += new System.EventHandler(this.Edit_Users_button_Click);
            // 
            // Approve_Instructor_BTN
            // 
            this.Approve_Instructor_BTN.Location = new System.Drawing.Point(53, 141);
            this.Approve_Instructor_BTN.Name = "Approve_Instructor_BTN";
            this.Approve_Instructor_BTN.Size = new System.Drawing.Size(109, 23);
            this.Approve_Instructor_BTN.TabIndex = 6;
            this.Approve_Instructor_BTN.Text = "Approve Instructor";
            this.Approve_Instructor_BTN.UseVisualStyleBackColor = true;
            this.Approve_Instructor_BTN.Click += new System.EventHandler(this.Approve_Instructor_BTN_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 231);
            this.Controls.Add(this.Approve_Instructor_BTN);
            this.Controls.Add(this.Edit_Users_button);
            this.Controls.Add(this.Access_Statistics_Button);
            this.Controls.Add(this.Access_Lectures_Button);
            this.Controls.Add(this.Access_Courses_Button);
            this.Controls.Add(this.Access_Departments_Button);
            this.Controls.Add(this.Add_Users_Button);
            this.Name = "AdminLogin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Users_Button;
        private System.Windows.Forms.Button Access_Departments_Button;
        private System.Windows.Forms.Button Access_Courses_Button;
        private System.Windows.Forms.Button Access_Lectures_Button;
        private System.Windows.Forms.Button Access_Statistics_Button;
        private System.Windows.Forms.Button Edit_Users_button;
        private System.Windows.Forms.Button Approve_Instructor_BTN;
    }
}