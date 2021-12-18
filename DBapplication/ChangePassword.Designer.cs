namespace DBapplication
{
    partial class Change_Password
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
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.UserName_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewPassword_Textbox = new System.Windows.Forms.TextBox();
            this.Change_Password_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Old Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Name";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(151, 124);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Password_TextBox.TabIndex = 7;
            // 
            // UserName_TextBox
            // 
            this.UserName_TextBox.Location = new System.Drawing.Point(151, 44);
            this.UserName_TextBox.Name = "UserName_TextBox";
            this.UserName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.UserName_TextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "New Password";
            // 
            // NewPassword_Textbox
            // 
            this.NewPassword_Textbox.Location = new System.Drawing.Point(151, 190);
            this.NewPassword_Textbox.Name = "NewPassword_Textbox";
            this.NewPassword_Textbox.PasswordChar = '*';
            this.NewPassword_Textbox.Size = new System.Drawing.Size(100, 20);
            this.NewPassword_Textbox.TabIndex = 10;
            // 
            // Change_Password_Button
            // 
            this.Change_Password_Button.Location = new System.Drawing.Point(245, 295);
            this.Change_Password_Button.Name = "Change_Password_Button";
            this.Change_Password_Button.Size = new System.Drawing.Size(118, 23);
            this.Change_Password_Button.TabIndex = 12;
            this.Change_Password_Button.Text = "Change Password";
            this.Change_Password_Button.UseVisualStyleBackColor = true;
            this.Change_Password_Button.Click += new System.EventHandler(this.Change_Password_Button_Click);
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.Change_Password_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPassword_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.UserName_TextBox);
            this.Name = "Change_Password";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.TextBox UserName_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPassword_Textbox;
        private System.Windows.Forms.Button Change_Password_Button;
    }
}