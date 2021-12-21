namespace DBapplication
{
    partial class ApplicantLogin
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
            this.Application_Status_label = new System.Windows.Forms.Label();
            this.Apply_ToCourse = new System.Windows.Forms.Button();
            this.View_DepInfo_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application Progress:";
            // 
            // Application_Status_label
            // 
            this.Application_Status_label.AutoSize = true;
            this.Application_Status_label.Location = new System.Drawing.Point(176, 46);
            this.Application_Status_label.Name = "Application_Status_label";
            this.Application_Status_label.Size = new System.Drawing.Size(78, 13);
            this.Application_Status_label.TabIndex = 1;
            this.Application_Status_label.Text = "Not applied yet";
            // 
            // Apply_ToCourse
            // 
            this.Apply_ToCourse.Location = new System.Drawing.Point(146, 156);
            this.Apply_ToCourse.Name = "Apply_ToCourse";
            this.Apply_ToCourse.Size = new System.Drawing.Size(120, 23);
            this.Apply_ToCourse.TabIndex = 2;
            this.Apply_ToCourse.Text = "Apply to Course";
            this.Apply_ToCourse.UseVisualStyleBackColor = true;
            this.Apply_ToCourse.Click += new System.EventHandler(this.Apply_ToCourse_Click);
            // 
            // View_DepInfo_Button
            // 
            this.View_DepInfo_Button.Location = new System.Drawing.Point(431, 156);
            this.View_DepInfo_Button.Name = "View_DepInfo_Button";
            this.View_DepInfo_Button.Size = new System.Drawing.Size(180, 23);
            this.View_DepInfo_Button.TabIndex = 17;
            this.View_DepInfo_Button.Text = "View Department Information";
            this.View_DepInfo_Button.UseVisualStyleBackColor = true;
            this.View_DepInfo_Button.Click += new System.EventHandler(this.View_DepInfo_Button_Click);
            // 
            // ApplicantLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.View_DepInfo_Button);
            this.Controls.Add(this.Apply_ToCourse);
            this.Controls.Add(this.Application_Status_label);
            this.Controls.Add(this.label1);
            this.Name = "ApplicantLogin";
            this.Text = "ApplicantLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Application_Status_label;
        private System.Windows.Forms.Button Apply_ToCourse;
        private System.Windows.Forms.Button View_DepInfo_Button;
    }
}