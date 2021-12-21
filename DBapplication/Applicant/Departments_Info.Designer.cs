namespace DBapplication.Applicant
{
    partial class Departments_Info
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewCandI_Button = new System.Windows.Forms.Button();
            this.Branch_Combobox = new System.Windows.Forms.ComboBox();
            this.Department_Combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Branch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Department";
            // 
            // ViewCandI_Button
            // 
            this.ViewCandI_Button.Location = new System.Drawing.Point(175, 171);
            this.ViewCandI_Button.Name = "ViewCandI_Button";
            this.ViewCandI_Button.Size = new System.Drawing.Size(174, 23);
            this.ViewCandI_Button.TabIndex = 22;
            this.ViewCandI_Button.Text = "View Courses and Instructors";
            this.ViewCandI_Button.UseVisualStyleBackColor = true;
            this.ViewCandI_Button.Click += new System.EventHandler(this.ViewCandI_Button_Click);
            // 
            // Branch_Combobox
            // 
            this.Branch_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Branch_Combobox.FormattingEnabled = true;
            this.Branch_Combobox.Location = new System.Drawing.Point(186, 106);
            this.Branch_Combobox.Name = "Branch_Combobox";
            this.Branch_Combobox.Size = new System.Drawing.Size(153, 21);
            this.Branch_Combobox.TabIndex = 21;
            this.Branch_Combobox.SelectedIndexChanged += new System.EventHandler(this.Branch_Combobox_SelectedIndexChanged);
            // 
            // Department_Combobox
            // 
            this.Department_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Department_Combobox.FormattingEnabled = true;
            this.Department_Combobox.Location = new System.Drawing.Point(186, 54);
            this.Department_Combobox.Name = "Department_Combobox";
            this.Department_Combobox.Size = new System.Drawing.Size(153, 21);
            this.Department_Combobox.TabIndex = 20;
            this.Department_Combobox.SelectedIndexChanged += new System.EventHandler(this.Department_Combobox_SelectedIndexChanged);
            // 
            // Departments_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewCandI_Button);
            this.Controls.Add(this.Branch_Combobox);
            this.Controls.Add(this.Department_Combobox);
            this.Name = "Departments_Info";
            this.Text = "Departments Infromation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewCandI_Button;
        private System.Windows.Forms.ComboBox Branch_Combobox;
        private System.Windows.Forms.ComboBox Department_Combobox;
    }
}