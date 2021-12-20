namespace DBapplication
{
    partial class Applicant_ExtraInfo
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CV_TextBox = new System.Windows.Forms.TextBox();
            this.CollegeName_Textbox = new System.Windows.Forms.MaskedTextBox();
            this.Years_TextBox = new System.Windows.Forms.TextBox();
            this.Complete_Registration_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "CV Link";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Years of Experience";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "College";
            // 
            // CV_TextBox
            // 
            this.CV_TextBox.Location = new System.Drawing.Point(317, 188);
            this.CV_TextBox.Name = "CV_TextBox";
            this.CV_TextBox.Size = new System.Drawing.Size(328, 20);
            this.CV_TextBox.TabIndex = 28;
            // 
            // CollegeName_Textbox
            // 
            this.CollegeName_Textbox.Location = new System.Drawing.Point(317, 50);
            this.CollegeName_Textbox.Name = "CollegeName_Textbox";
            this.CollegeName_Textbox.Size = new System.Drawing.Size(100, 20);
            this.CollegeName_Textbox.TabIndex = 27;
            // 
            // Years_TextBox
            // 
            this.Years_TextBox.Location = new System.Drawing.Point(317, 123);
            this.Years_TextBox.Name = "Years_TextBox";
            this.Years_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Years_TextBox.TabIndex = 26;
            // 
            // Complete_Registration_Button
            // 
            this.Complete_Registration_Button.Location = new System.Drawing.Point(275, 291);
            this.Complete_Registration_Button.Name = "Complete_Registration_Button";
            this.Complete_Registration_Button.Size = new System.Drawing.Size(175, 23);
            this.Complete_Registration_Button.TabIndex = 32;
            this.Complete_Registration_Button.Text = "Complete Your Registration";
            this.Complete_Registration_Button.UseVisualStyleBackColor = true;
            this.Complete_Registration_Button.Click += new System.EventHandler(this.Complete_Registration_Button_Click);
            // 
            // Applicant_ExtraInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Complete_Registration_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CV_TextBox);
            this.Controls.Add(this.CollegeName_Textbox);
            this.Controls.Add(this.Years_TextBox);
            this.Name = "Applicant_ExtraInfo";
            this.Text = "Extra Information Required";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CV_TextBox;
        private System.Windows.Forms.MaskedTextBox CollegeName_Textbox;
        private System.Windows.Forms.TextBox Years_TextBox;
        private System.Windows.Forms.Button Complete_Registration_Button;
    }
}