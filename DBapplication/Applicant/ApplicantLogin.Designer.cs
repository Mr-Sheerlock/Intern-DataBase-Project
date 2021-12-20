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
            this.label2 = new System.Windows.Forms.Label();
            this.Apply_ToCourse = new System.Windows.Forms.Button();
            this.Departments_Combobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ongoing";
            // 
            // Apply_ToCourse
            // 
            this.Apply_ToCourse.Location = new System.Drawing.Point(103, 137);
            this.Apply_ToCourse.Name = "Apply_ToCourse";
            this.Apply_ToCourse.Size = new System.Drawing.Size(120, 23);
            this.Apply_ToCourse.TabIndex = 2;
            this.Apply_ToCourse.Text = "Apply to Course";
            this.Apply_ToCourse.UseVisualStyleBackColor = true;
            this.Apply_ToCourse.Click += new System.EventHandler(this.Apply_ToCourse_Click);
            // 
            // Departments_Combobox
            // 
            this.Departments_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Departments_Combobox.FormattingEnabled = true;
            this.Departments_Combobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Departments_Combobox.Location = new System.Drawing.Point(555, 43);
            this.Departments_Combobox.Name = "Departments_Combobox";
            this.Departments_Combobox.Size = new System.Drawing.Size(100, 21);
            this.Departments_Combobox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Department";
            // 
            // ApplicantLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Departments_Combobox);
            this.Controls.Add(this.Apply_ToCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ApplicantLogin";
            this.Text = "ApplicantLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Apply_ToCourse;
        private System.Windows.Forms.ComboBox Departments_Combobox;
        private System.Windows.Forms.Label label3;
    }
}