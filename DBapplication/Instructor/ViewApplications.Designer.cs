namespace DBapplication.Instructor
{
    partial class ViewApplications
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
            this.RejectButton = new System.Windows.Forms.Button();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.PendingApplicantsGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.GetAppNumber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PendingApplicantsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RejectButton
            // 
            this.RejectButton.Location = new System.Drawing.Point(292, 345);
            this.RejectButton.Margin = new System.Windows.Forms.Padding(4);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(143, 42);
            this.RejectButton.TabIndex = 5;
            this.RejectButton.Text = "Reject Selected Applicant";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // ApproveButton
            // 
            this.ApproveButton.Location = new System.Drawing.Point(85, 345);
            this.ApproveButton.Margin = new System.Windows.Forms.Padding(4);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(143, 42);
            this.ApproveButton.TabIndex = 4;
            this.ApproveButton.Text = "Approve Selected Applicant";
            this.ApproveButton.UseVisualStyleBackColor = true;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButton_Click);
            // 
            // PendingApplicantsGrid
            // 
            this.PendingApplicantsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PendingApplicantsGrid.Location = new System.Drawing.Point(46, 49);
            this.PendingApplicantsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.PendingApplicantsGrid.Name = "PendingApplicantsGrid";
            this.PendingApplicantsGrid.ReadOnly = true;
            this.PendingApplicantsGrid.RowHeadersWidth = 51;
            this.PendingApplicantsGrid.Size = new System.Drawing.Size(1091, 266);
            this.PendingApplicantsGrid.TabIndex = 3;
            this.PendingApplicantsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PendingApplicantsGrid_CellClick);
            this.PendingApplicantsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PendingApplicantsGrid_CellContentClick);
            this.PendingApplicantsGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.PendingApplicantsGrid_DataBindingComplete);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(947, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 7;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GetAppNumber
            // 
            this.GetAppNumber.Location = new System.Drawing.Point(764, 345);
            this.GetAppNumber.Margin = new System.Windows.Forms.Padding(4);
            this.GetAppNumber.Name = "GetAppNumber";
            this.GetAppNumber.Size = new System.Drawing.Size(143, 42);
            this.GetAppNumber.TabIndex = 8;
            this.GetAppNumber.Text = "Number of applicants";
            this.GetAppNumber.UseVisualStyleBackColor = true;
            this.GetAppNumber.Click += new System.EventHandler(this.GetAppNumber_Click);
            // 
            // ViewApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 486);
            this.Controls.Add(this.GetAppNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.PendingApplicantsGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewApplications";
            this.Text = "View Applications";
            ((System.ComponentModel.ISupportInitialize)(this.PendingApplicantsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.DataGridView PendingApplicantsGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetAppNumber;
    }
}