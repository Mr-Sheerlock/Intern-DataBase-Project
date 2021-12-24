namespace DBapplication.Admin
{
    partial class Edit_Users
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
            this.userName_textBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Active_rbtn = new System.Windows.Forms.RadioButton();
            this.pending_rbtn = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Male_rbtn = new System.Windows.Forms.RadioButton();
            this.Female_rbtn = new System.Windows.Forms.RadioButton();
            this.TelephoneNum_textbox = new System.Windows.Forms.TextBox();
            this.Age_textbox = new System.Windows.Forms.TextBox();
            this.Lname_textBox = new System.Windows.Forms.TextBox();
            this.Fname_textBox = new System.Windows.Forms.TextBox();
            this.DepName_textbox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // userName_textBox
            // 
            this.userName_textBox.FormattingEnabled = true;
            this.userName_textBox.Location = new System.Drawing.Point(88, 38);
            this.userName_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.userName_textBox.Name = "userName_textBox";
            this.userName_textBox.Size = new System.Drawing.Size(139, 21);
            this.userName_textBox.TabIndex = 66;
            this.userName_textBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Active_rbtn);
            this.groupBox3.Controls.Add(this.pending_rbtn);
            this.groupBox3.Location = new System.Drawing.Point(106, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 31);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // Active_rbtn
            // 
            this.Active_rbtn.AutoSize = true;
            this.Active_rbtn.Location = new System.Drawing.Point(6, 9);
            this.Active_rbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Active_rbtn.Name = "Active_rbtn";
            this.Active_rbtn.Size = new System.Drawing.Size(55, 17);
            this.Active_rbtn.TabIndex = 26;
            this.Active_rbtn.TabStop = true;
            this.Active_rbtn.Text = "Active";
            this.Active_rbtn.UseVisualStyleBackColor = true;
            // 
            // pending_rbtn
            // 
            this.pending_rbtn.AutoSize = true;
            this.pending_rbtn.Location = new System.Drawing.Point(73, 9);
            this.pending_rbtn.Margin = new System.Windows.Forms.Padding(2);
            this.pending_rbtn.Name = "pending_rbtn";
            this.pending_rbtn.Size = new System.Drawing.Size(63, 17);
            this.pending_rbtn.TabIndex = 27;
            this.pending_rbtn.TabStop = true;
            this.pending_rbtn.Text = "Inactive";
            this.pending_rbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Male_rbtn);
            this.groupBox4.Controls.Add(this.Female_rbtn);
            this.groupBox4.Location = new System.Drawing.Point(71, 166);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(117, 33);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // Male_rbtn
            // 
            this.Male_rbtn.AutoSize = true;
            this.Male_rbtn.Location = new System.Drawing.Point(4, 11);
            this.Male_rbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Male_rbtn.Name = "Male_rbtn";
            this.Male_rbtn.Size = new System.Drawing.Size(48, 17);
            this.Male_rbtn.TabIndex = 24;
            this.Male_rbtn.TabStop = true;
            this.Male_rbtn.Text = "Male";
            this.Male_rbtn.UseVisualStyleBackColor = true;
            // 
            // Female_rbtn
            // 
            this.Female_rbtn.AutoSize = true;
            this.Female_rbtn.Location = new System.Drawing.Point(53, 11);
            this.Female_rbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Female_rbtn.Name = "Female_rbtn";
            this.Female_rbtn.Size = new System.Drawing.Size(59, 17);
            this.Female_rbtn.TabIndex = 25;
            this.Female_rbtn.TabStop = true;
            this.Female_rbtn.Text = "Female";
            this.Female_rbtn.UseVisualStyleBackColor = true;
            // 
            // TelephoneNum_textbox
            // 
            this.TelephoneNum_textbox.Location = new System.Drawing.Point(127, 244);
            this.TelephoneNum_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.TelephoneNum_textbox.Name = "TelephoneNum_textbox";
            this.TelephoneNum_textbox.Size = new System.Drawing.Size(109, 20);
            this.TelephoneNum_textbox.TabIndex = 63;
            this.TelephoneNum_textbox.Visible = false;
            // 
            // Age_textbox
            // 
            this.Age_textbox.Location = new System.Drawing.Point(53, 141);
            this.Age_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Age_textbox.Name = "Age_textbox";
            this.Age_textbox.Size = new System.Drawing.Size(34, 20);
            this.Age_textbox.TabIndex = 62;
            this.Age_textbox.Visible = false;
            // 
            // Lname_textBox
            // 
            this.Lname_textBox.Location = new System.Drawing.Point(86, 108);
            this.Lname_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Lname_textBox.Name = "Lname_textBox";
            this.Lname_textBox.Size = new System.Drawing.Size(141, 20);
            this.Lname_textBox.TabIndex = 61;
            this.Lname_textBox.Visible = false;
            // 
            // Fname_textBox
            // 
            this.Fname_textBox.Location = new System.Drawing.Point(86, 74);
            this.Fname_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Fname_textBox.Name = "Fname_textBox";
            this.Fname_textBox.Size = new System.Drawing.Size(141, 20);
            this.Fname_textBox.TabIndex = 60;
            this.Fname_textBox.Visible = false;
            // 
            // DepName_textbox
            // 
            this.DepName_textbox.FormattingEnabled = true;
            this.DepName_textbox.Location = new System.Drawing.Point(127, 266);
            this.DepName_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.DepName_textbox.Name = "DepName_textbox";
            this.DepName_textbox.Size = new System.Drawing.Size(72, 21);
            this.DepName_textbox.TabIndex = 59;
            this.DepName_textbox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Department Name: ";
            this.label7.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 244);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Telephone Number:";
            this.label10.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 211);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Account Status:";
            this.label12.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 178);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "Gender:";
            this.label18.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 141);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 54;
            this.label19.Text = "Age:";
            this.label19.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 108);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 53;
            this.label20.Text = "Last Name:";
            this.label20.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 76);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 52;
            this.label21.Text = "First Name:";
            this.label21.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 41);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 51;
            this.label23.Text = "User Name:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(193, 291);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 38);
            this.button1.TabIndex = 50;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Type:";
            this.label2.Visible = false;
            // 
            // Edit_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName_textBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.TelephoneNum_textbox);
            this.Controls.Add(this.Age_textbox);
            this.Controls.Add(this.Lname_textBox);
            this.Controls.Add(this.Fname_textBox);
            this.Controls.Add(this.DepName_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.button1);
            this.Name = "Edit_Users";
            this.Text = "Edit Users";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userName_textBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Active_rbtn;
        private System.Windows.Forms.RadioButton pending_rbtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Male_rbtn;
        private System.Windows.Forms.RadioButton Female_rbtn;
        private System.Windows.Forms.TextBox TelephoneNum_textbox;
        private System.Windows.Forms.TextBox Age_textbox;
        private System.Windows.Forms.TextBox Lname_textBox;
        private System.Windows.Forms.TextBox Fname_textBox;
        private System.Windows.Forms.ComboBox DepName_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}