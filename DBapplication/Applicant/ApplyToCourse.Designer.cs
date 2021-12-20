namespace DBapplication
{
    partial class ApplyToCourse
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
            this.DepartmentBranch_Combobox = new System.Windows.Forms.ComboBox();
            this.Course_Combobox = new System.Windows.Forms.ComboBox();
            this.Apply_ToCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DepartmentBranch_Combobox
            // 
            this.DepartmentBranch_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentBranch_Combobox.FormattingEnabled = true;
            this.DepartmentBranch_Combobox.Location = new System.Drawing.Point(305, 113);
            this.DepartmentBranch_Combobox.Name = "DepartmentBranch_Combobox";
            this.DepartmentBranch_Combobox.Size = new System.Drawing.Size(153, 21);
            this.DepartmentBranch_Combobox.TabIndex = 15;
            this.DepartmentBranch_Combobox.SelectedIndexChanged += new System.EventHandler(this.DepartmentBranch_Combobox_SelectedIndexChanged);
            // 
            // Course_Combobox
            // 
            this.Course_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Course_Combobox.FormattingEnabled = true;
            this.Course_Combobox.Location = new System.Drawing.Point(305, 165);
            this.Course_Combobox.Name = "Course_Combobox";
            this.Course_Combobox.Size = new System.Drawing.Size(100, 21);
            this.Course_Combobox.TabIndex = 16;
            this.Course_Combobox.SelectedIndexChanged += new System.EventHandler(this.Course_Combobox_SelectedIndexChanged);
            // 
            // Apply_ToCourse
            // 
            this.Apply_ToCourse.Location = new System.Drawing.Point(296, 273);
            this.Apply_ToCourse.Name = "Apply_ToCourse";
            this.Apply_ToCourse.Size = new System.Drawing.Size(120, 23);
            this.Apply_ToCourse.TabIndex = 17;
            this.Apply_ToCourse.Text = "Apply to Course";
            this.Apply_ToCourse.UseVisualStyleBackColor = true;
            this.Apply_ToCourse.Click += new System.EventHandler(this.Apply_ToCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Department Branch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Course";
            // 
            // ApplyToCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Apply_ToCourse);
            this.Controls.Add(this.Course_Combobox);
            this.Controls.Add(this.DepartmentBranch_Combobox);
            this.Name = "ApplyToCourse";
            this.RightToLeftLayout = true;
            this.Text = "Apply To Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DepartmentBranch_Combobox;
        private System.Windows.Forms.ComboBox Course_Combobox;
        private System.Windows.Forms.Button Apply_ToCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}