
namespace DBapplication.Admin
{
    partial class Statistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.StatOpMenu_cmbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose an operation: ";
            // 
            // StatOpMenu_cmbox
            // 
            this.StatOpMenu_cmbox.FormattingEnabled = true;
            this.StatOpMenu_cmbox.Items.AddRange(new object[] {
            "Departments/Interns within ",
            "Course/Instructor ",
            "Course/Department or location ",
            "Courses/Grades",
            "Applicants/Applied Course or Department",
            "Intern/No of Completed Internships",
            "Number of Rejected Applicants ",
            "Number of Interns ",
            "Number of Instructors",
            "Number of Admins ",
            "Availble courses in a semester",
            " "});
            this.StatOpMenu_cmbox.Location = new System.Drawing.Point(430, 12);
            this.StatOpMenu_cmbox.Name = "StatOpMenu_cmbox";
            this.StatOpMenu_cmbox.Size = new System.Drawing.Size(197, 24);
            this.StatOpMenu_cmbox.TabIndex = 6;
            this.StatOpMenu_cmbox.SelectedIndexChanged += new System.EventHandler(this.StatOpMenu_cmbox_SelectedIndexChanged);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatOpMenu_cmbox);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StatOpMenu_cmbox;
    }
}