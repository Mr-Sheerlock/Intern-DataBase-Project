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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // View_Applications_Button
            // 
            this.View_Applications_Button.Location = new System.Drawing.Point(109, 65);
            this.View_Applications_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.View_Applications_Button.Name = "View_Applications_Button";
            this.View_Applications_Button.Size = new System.Drawing.Size(155, 55);
            this.View_Applications_Button.TabIndex = 0;
            this.View_Applications_Button.Text = "View Applications";
            this.View_Applications_Button.UseVisualStyleBackColor = true;
            this.View_Applications_Button.Click += new System.EventHandler(this.View_Applications_Button_Click);
            // 
            // Lectures_Button
            // 
            this.Lectures_Button.Location = new System.Drawing.Point(388, 65);
            this.Lectures_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lectures_Button.Name = "Lectures_Button";
            this.Lectures_Button.Size = new System.Drawing.Size(147, 55);
            this.Lectures_Button.TabIndex = 1;
            this.Lectures_Button.Text = "Lectures";
            this.Lectures_Button.UseVisualStyleBackColor = true;
            this.Lectures_Button.Click += new System.EventHandler(this.Lectures_Button_Click);
            // 
            // View_Admins_Button
            // 
            this.View_Admins_Button.Location = new System.Drawing.Point(388, 172);
            this.View_Admins_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.View_Admins_Button.Name = "View_Admins_Button";
            this.View_Admins_Button.Size = new System.Drawing.Size(147, 55);
            this.View_Admins_Button.TabIndex = 2;
            this.View_Admins_Button.Text = "View Admins";
            this.View_Admins_Button.UseVisualStyleBackColor = true;
            this.View_Admins_Button.Click += new System.EventHandler(this.View_Admins_Button_Click);
            // 
            // Intern_Results_Button
            // 
            this.Intern_Results_Button.Location = new System.Drawing.Point(109, 172);
            this.Intern_Results_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Intern_Results_Button.Name = "Intern_Results_Button";
            this.Intern_Results_Button.Size = new System.Drawing.Size(155, 55);
            this.Intern_Results_Button.TabIndex = 3;
            this.Intern_Results_Button.Text = "Decide Internship Results";
            this.Intern_Results_Button.UseVisualStyleBackColor = true;
            this.Intern_Results_Button.Click += new System.EventHandler(this.Intern_Results_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 275);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 81);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show Statistics";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InstructorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Intern_Results_Button);
            this.Controls.Add(this.View_Admins_Button);
            this.Controls.Add(this.Lectures_Button);
            this.Controls.Add(this.View_Applications_Button);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InstructorLogin";
            this.Text = "Instructor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button View_Applications_Button;
        private System.Windows.Forms.Button Lectures_Button;
        private System.Windows.Forms.Button View_Admins_Button;
        private System.Windows.Forms.Button Intern_Results_Button;
        private System.Windows.Forms.Button button1;
    }
}