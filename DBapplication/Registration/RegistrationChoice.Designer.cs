namespace DBapplication
{
    partial class RegistrationChoice
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
            this.Applicant_Reg_Button = new System.Windows.Forms.Button();
            this.Instructor_Reg_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Applicant_Reg_Button
            // 
            this.Applicant_Reg_Button.Location = new System.Drawing.Point(44, 54);
            this.Applicant_Reg_Button.Name = "Applicant_Reg_Button";
            this.Applicant_Reg_Button.Size = new System.Drawing.Size(75, 23);
            this.Applicant_Reg_Button.TabIndex = 0;
            this.Applicant_Reg_Button.Text = "Applicant";
            this.Applicant_Reg_Button.UseVisualStyleBackColor = true;
            this.Applicant_Reg_Button.Click += new System.EventHandler(this.Applicant_Reg_Button_Click);
            // 
            // Instructor_Reg_Button
            // 
            this.Instructor_Reg_Button.Location = new System.Drawing.Point(303, 54);
            this.Instructor_Reg_Button.Name = "Instructor_Reg_Button";
            this.Instructor_Reg_Button.Size = new System.Drawing.Size(75, 23);
            this.Instructor_Reg_Button.TabIndex = 1;
            this.Instructor_Reg_Button.Text = "Instructor";
            this.Instructor_Reg_Button.UseVisualStyleBackColor = true;
            this.Instructor_Reg_Button.Click += new System.EventHandler(this.Instructor_Reg_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the Type of Registration";
            // 
            // RegistrationChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Instructor_Reg_Button);
            this.Controls.Add(this.Applicant_Reg_Button);
            this.Name = "RegistrationChoice";
            this.Text = "RegistrationChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Applicant_Reg_Button;
        private System.Windows.Forms.Button Instructor_Reg_Button;
        private System.Windows.Forms.Label label1;
    }
}