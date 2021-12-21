
namespace DBapplication.Admin
{
    partial class Users
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
            this.UserIntern_BTN = new System.Windows.Forms.Button();
            this.UserAdmin_BTN = new System.Windows.Forms.Button();
            this.UserInstructor_BTN = new System.Windows.Forms.Button();
            this.UserApplicants_BTN = new System.Windows.Forms.Button();
            this.AddUser_BTN = new System.Windows.Forms.Button();
            this.RemoveUser_BTN = new System.Windows.Forms.Button();
            this.Add_remove_lbl = new System.Windows.Forms.Label();
            this.BacktoUsers_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserIntern_BTN
            // 
            this.UserIntern_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserIntern_BTN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIntern_BTN.ForeColor = System.Drawing.Color.Goldenrod;
            this.UserIntern_BTN.Location = new System.Drawing.Point(419, 173);
            this.UserIntern_BTN.Name = "UserIntern_BTN";
            this.UserIntern_BTN.Size = new System.Drawing.Size(157, 45);
            this.UserIntern_BTN.TabIndex = 8;
            this.UserIntern_BTN.Text = "Interns";
            this.UserIntern_BTN.UseVisualStyleBackColor = true;
            this.UserIntern_BTN.Click += new System.EventHandler(this.UserIntern_BTN_Click);
            // 
            // UserAdmin_BTN
            // 
            this.UserAdmin_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserAdmin_BTN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAdmin_BTN.ForeColor = System.Drawing.Color.Goldenrod;
            this.UserAdmin_BTN.Location = new System.Drawing.Point(419, 23);
            this.UserAdmin_BTN.Name = "UserAdmin_BTN";
            this.UserAdmin_BTN.Size = new System.Drawing.Size(157, 45);
            this.UserAdmin_BTN.TabIndex = 12;
            this.UserAdmin_BTN.Text = "Admins";
            this.UserAdmin_BTN.UseVisualStyleBackColor = true;
            this.UserAdmin_BTN.Click += new System.EventHandler(this.UserAdmin_BTN_Click);
            // 
            // UserInstructor_BTN
            // 
            this.UserInstructor_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserInstructor_BTN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInstructor_BTN.ForeColor = System.Drawing.Color.Goldenrod;
            this.UserInstructor_BTN.Location = new System.Drawing.Point(419, 95);
            this.UserInstructor_BTN.Name = "UserInstructor_BTN";
            this.UserInstructor_BTN.Size = new System.Drawing.Size(157, 45);
            this.UserInstructor_BTN.TabIndex = 13;
            this.UserInstructor_BTN.Text = "Instructors";
            this.UserInstructor_BTN.UseVisualStyleBackColor = true;
            this.UserInstructor_BTN.Click += new System.EventHandler(this.UserInstructor_BTN_Click);
            // 
            // UserApplicants_BTN
            // 
            this.UserApplicants_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserApplicants_BTN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserApplicants_BTN.ForeColor = System.Drawing.Color.Goldenrod;
            this.UserApplicants_BTN.Location = new System.Drawing.Point(419, 249);
            this.UserApplicants_BTN.Name = "UserApplicants_BTN";
            this.UserApplicants_BTN.Size = new System.Drawing.Size(157, 45);
            this.UserApplicants_BTN.TabIndex = 14;
            this.UserApplicants_BTN.Text = "Applicants";
            this.UserApplicants_BTN.UseVisualStyleBackColor = true;
            this.UserApplicants_BTN.Click += new System.EventHandler(this.UserApplicants_BTN_Click);
            // 
            // AddUser_BTN
            // 
            this.AddUser_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddUser_BTN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser_BTN.ForeColor = System.Drawing.Color.LimeGreen;
            this.AddUser_BTN.Location = new System.Drawing.Point(272, 410);
            this.AddUser_BTN.Name = "AddUser_BTN";
            this.AddUser_BTN.Size = new System.Drawing.Size(157, 45);
            this.AddUser_BTN.TabIndex = 15;
            this.AddUser_BTN.Text = "Add";
            this.AddUser_BTN.UseVisualStyleBackColor = true;
            this.AddUser_BTN.Click += new System.EventHandler(this.AddUser_BTN_Click);
            // 
            // RemoveUser_BTN
            // 
            this.RemoveUser_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveUser_BTN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveUser_BTN.ForeColor = System.Drawing.Color.Red;
            this.RemoveUser_BTN.Location = new System.Drawing.Point(548, 410);
            this.RemoveUser_BTN.Name = "RemoveUser_BTN";
            this.RemoveUser_BTN.Size = new System.Drawing.Size(157, 45);
            this.RemoveUser_BTN.TabIndex = 16;
            this.RemoveUser_BTN.Text = "Remove";
            this.RemoveUser_BTN.UseVisualStyleBackColor = true;
            this.RemoveUser_BTN.Click += new System.EventHandler(this.RemoveUser_BTN_Click);
            // 
            // Add_remove_lbl
            // 
            this.Add_remove_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.Add_remove_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_remove_lbl.Location = new System.Drawing.Point(268, 357);
            this.Add_remove_lbl.Name = "Add_remove_lbl";
            this.Add_remove_lbl.Size = new System.Drawing.Size(481, 29);
            this.Add_remove_lbl.TabIndex = 17;
            this.Add_remove_lbl.Text = "Do you want to Add or Remove Selected User ? ";
            // 
            // BacktoUsers_BTN
            // 
            this.BacktoUsers_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BacktoUsers_BTN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacktoUsers_BTN.ForeColor = System.Drawing.Color.Black;
            this.BacktoUsers_BTN.Location = new System.Drawing.Point(808, 497);
            this.BacktoUsers_BTN.Name = "BacktoUsers_BTN";
            this.BacktoUsers_BTN.Size = new System.Drawing.Size(157, 45);
            this.BacktoUsers_BTN.TabIndex = 18;
            this.BacktoUsers_BTN.Text = "Back";
            this.BacktoUsers_BTN.UseVisualStyleBackColor = true;
            this.BacktoUsers_BTN.Click += new System.EventHandler(this.BacktoUsersMainMenu_BTN_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 543);
            this.Controls.Add(this.BacktoUsers_BTN);
            this.Controls.Add(this.Add_remove_lbl);
            this.Controls.Add(this.RemoveUser_BTN);
            this.Controls.Add(this.AddUser_BTN);
            this.Controls.Add(this.UserApplicants_BTN);
            this.Controls.Add(this.UserInstructor_BTN);
            this.Controls.Add(this.UserAdmin_BTN);
            this.Controls.Add(this.UserIntern_BTN);
            this.Name = "Users";
            this.Text = "AccessUsersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserIntern_BTN;
        private System.Windows.Forms.Button UserAdmin_BTN;
        private System.Windows.Forms.Button UserInstructor_BTN;
        private System.Windows.Forms.Button UserApplicants_BTN;
        private System.Windows.Forms.Button AddUser_BTN;
        private System.Windows.Forms.Button RemoveUser_BTN;
        private System.Windows.Forms.Label Add_remove_lbl;
        private System.Windows.Forms.Button BacktoUsers_BTN;
    }
}