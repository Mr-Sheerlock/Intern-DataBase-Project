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
            this.Access_Users_Button = new System.Windows.Forms.Button();
            this.Access_Departments_Button = new System.Windows.Forms.Button();
            this.Access_Courses_Button = new System.Windows.Forms.Button();
            this.Access_Lectures_Button = new System.Windows.Forms.Button();
            this.Access_Statistics_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Access_Users_Button
            // 
            this.Access_Users_Button.Location = new System.Drawing.Point(142, 48);
            this.Access_Users_Button.Name = "Access_Users_Button";
            this.Access_Users_Button.Size = new System.Drawing.Size(109, 23);
            this.Access_Users_Button.TabIndex = 0;
            this.Access_Users_Button.Text = "Access Users";
            this.Access_Users_Button.UseVisualStyleBackColor = true;
            this.Access_Users_Button.Click += new System.EventHandler(this.Access_Users_Button_Click);
            // 
            // Access_Departments_Button
            // 
            this.Access_Departments_Button.Location = new System.Drawing.Point(142, 88);
            this.Access_Departments_Button.Name = "Access_Departments_Button";
            this.Access_Departments_Button.Size = new System.Drawing.Size(109, 24);
            this.Access_Departments_Button.TabIndex = 1;
            this.Access_Departments_Button.Text = "Departments";
            this.Access_Departments_Button.UseVisualStyleBackColor = true;
            // 
            // Access_Courses_Button
            // 
            this.Access_Courses_Button.Location = new System.Drawing.Point(142, 135);
            this.Access_Courses_Button.Name = "Access_Courses_Button";
            this.Access_Courses_Button.Size = new System.Drawing.Size(109, 23);
            this.Access_Courses_Button.TabIndex = 2;
            this.Access_Courses_Button.Text = "Courses";
            this.Access_Courses_Button.UseVisualStyleBackColor = true;
            this.Access_Courses_Button.Click += new System.EventHandler(this.Access_Courses_Button_Click);
            // 
            // Access_Lectures_Button
            // 
            this.Access_Lectures_Button.Location = new System.Drawing.Point(142, 176);
            this.Access_Lectures_Button.Name = "Access_Lectures_Button";
            this.Access_Lectures_Button.Size = new System.Drawing.Size(109, 24);
            this.Access_Lectures_Button.TabIndex = 3;
            this.Access_Lectures_Button.Text = "Lectures";
            this.Access_Lectures_Button.UseVisualStyleBackColor = true;
            // 
            // Access_Statistics_Button
            // 
            this.Access_Statistics_Button.Location = new System.Drawing.Point(142, 219);
            this.Access_Statistics_Button.Name = "Access_Statistics_Button";
            this.Access_Statistics_Button.Size = new System.Drawing.Size(109, 25);
            this.Access_Statistics_Button.TabIndex = 4;
            this.Access_Statistics_Button.Text = "Statistics";
            this.Access_Statistics_Button.UseVisualStyleBackColor = true;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 304);
            this.Controls.Add(this.Access_Statistics_Button);
            this.Controls.Add(this.Access_Lectures_Button);
            this.Controls.Add(this.Access_Courses_Button);
            this.Controls.Add(this.Access_Departments_Button);
            this.Controls.Add(this.Access_Users_Button);
            this.Name = "AdminLogin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Access_Users_Button;
        private System.Windows.Forms.Button Access_Departments_Button;
        private System.Windows.Forms.Button Access_Courses_Button;
        private System.Windows.Forms.Button Access_Lectures_Button;
        private System.Windows.Forms.Button Access_Statistics_Button;
    }
}