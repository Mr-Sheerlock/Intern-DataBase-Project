namespace DBapplication
{
    partial class Register
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
            this.button1 = new System.Windows.Forms.Button();
            this.User_Name_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fname_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lname_Textbox = new System.Windows.Forms.TextBox();
            this.Age_Textbox = new System.Windows.Forms.TextBox();
            this.Gender_Combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Job_Combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // User_Name_Textbox
            // 
            this.User_Name_Textbox.Location = new System.Drawing.Point(138, 44);
            this.User_Name_Textbox.Name = "User_Name_Textbox";
            this.User_Name_Textbox.Size = new System.Drawing.Size(100, 20);
            this.User_Name_Textbox.TabIndex = 2;
            this.User_Name_Textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Location = new System.Drawing.Point(138, 100);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Password_Textbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name";
            // 
            // Fname_Textbox
            // 
            this.Fname_Textbox.Location = new System.Drawing.Point(510, 47);
            this.Fname_Textbox.Name = "Fname_Textbox";
            this.Fname_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Fname_Textbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name";
            // 
            // Lname_Textbox
            // 
            this.Lname_Textbox.Location = new System.Drawing.Point(510, 100);
            this.Lname_Textbox.Name = "Lname_Textbox";
            this.Lname_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Lname_Textbox.TabIndex = 10;
            // 
            // Age_Textbox
            // 
            this.Age_Textbox.Location = new System.Drawing.Point(138, 163);
            this.Age_Textbox.Name = "Age_Textbox";
            this.Age_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Age_Textbox.TabIndex = 12;
            // 
            // Gender_Combobox
            // 
            this.Gender_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_Combobox.FormattingEnabled = true;
            this.Gender_Combobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_Combobox.Location = new System.Drawing.Point(510, 155);
            this.Gender_Combobox.Name = "Gender_Combobox";
            this.Gender_Combobox.Size = new System.Drawing.Size(100, 21);
            this.Gender_Combobox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Job";
            // 
            // Job_Combobox
            // 
            this.Job_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Job_Combobox.FormattingEnabled = true;
            this.Job_Combobox.Items.AddRange(new object[] {
            "Applicant",
            "Instructor"});
            this.Job_Combobox.Location = new System.Drawing.Point(138, 225);
            this.Job_Combobox.Name = "Job_Combobox";
            this.Job_Combobox.Size = new System.Drawing.Size(100, 21);
            this.Job_Combobox.TabIndex = 17;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Job_Combobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Gender_Combobox);
            this.Controls.Add(this.Age_Textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lname_Textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fname_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User_Name_Textbox);
            this.Controls.Add(this.button1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox User_Name_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fname_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Lname_Textbox;
        private System.Windows.Forms.TextBox Age_Textbox;
        private System.Windows.Forms.ComboBox Gender_Combobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Job_Combobox;
    }
}