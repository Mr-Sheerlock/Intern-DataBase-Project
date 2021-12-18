namespace DBapplication
{
    partial class InstructorLogin
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
            this.View_Applications_Button = new System.Windows.Forms.Button();
            this.Lectures_Button = new System.Windows.Forms.Button();
            this.View_Admins_Button = new System.Windows.Forms.Button();
            this.Intern_Results_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // View_Applications_Button
            // 
            this.View_Applications_Button.Location = new System.Drawing.Point(82, 57);
            this.View_Applications_Button.Name = "View_Applications_Button";
            this.View_Applications_Button.Size = new System.Drawing.Size(115, 23);
            this.View_Applications_Button.TabIndex = 0;
            this.View_Applications_Button.Text = "View Applications";
            this.View_Applications_Button.UseVisualStyleBackColor = true;
            // 
            // Lectures_Button
            // 
            this.Lectures_Button.Location = new System.Drawing.Point(312, 57);
            this.Lectures_Button.Name = "Lectures_Button";
            this.Lectures_Button.Size = new System.Drawing.Size(89, 23);
            this.Lectures_Button.TabIndex = 1;
            this.Lectures_Button.Text = "Lectures";
            this.Lectures_Button.UseVisualStyleBackColor = true;
            // 
            // View_Admins_Button
            // 
            this.View_Admins_Button.Location = new System.Drawing.Point(312, 327);
            this.View_Admins_Button.Name = "View_Admins_Button";
            this.View_Admins_Button.Size = new System.Drawing.Size(75, 23);
            this.View_Admins_Button.TabIndex = 2;
            this.View_Admins_Button.Text = "View Admins";
            this.View_Admins_Button.UseVisualStyleBackColor = true;
            // 
            // Intern_Results_Button
            // 
            this.Intern_Results_Button.Location = new System.Drawing.Point(82, 284);
            this.Intern_Results_Button.Name = "Intern_Results_Button";
            this.Intern_Results_Button.Size = new System.Drawing.Size(75, 66);
            this.Intern_Results_Button.TabIndex = 3;
            this.Intern_Results_Button.Text = "Decide Internship Results";
            this.Intern_Results_Button.UseVisualStyleBackColor = true;
            // 
            // InstructorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 554);
            this.Controls.Add(this.Intern_Results_Button);
            this.Controls.Add(this.View_Admins_Button);
            this.Controls.Add(this.Lectures_Button);
            this.Controls.Add(this.View_Applications_Button);
            this.Name = "InstructorLogin";
            this.Text = "Instructor";
            this.Load += new System.EventHandler(this.InstructorLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button View_Applications_Button;
        private System.Windows.Forms.Button Lectures_Button;
        private System.Windows.Forms.Button View_Admins_Button;
        private System.Windows.Forms.Button Intern_Results_Button;
    }
}