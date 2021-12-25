namespace DBapplication.Admin
{
    partial class Approve_Instructor
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
            this.PendingInstructorsGrid = new System.Windows.Forms.DataGridView();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PendingInstructorsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PendingInstructorsGrid
            // 
            this.PendingInstructorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PendingInstructorsGrid.Location = new System.Drawing.Point(29, 33);
            this.PendingInstructorsGrid.Name = "PendingInstructorsGrid";
            this.PendingInstructorsGrid.ReadOnly = true;
            this.PendingInstructorsGrid.Size = new System.Drawing.Size(818, 216);
            this.PendingInstructorsGrid.TabIndex = 0;
            this.PendingInstructorsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PendingInstructorsGrid_CellClick);
            this.PendingInstructorsGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.PendingInstructorsGrid_DataBindingComplete);
            // 
            // ApproveButton
            // 
            this.ApproveButton.Location = new System.Drawing.Point(315, 275);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(107, 34);
            this.ApproveButton.TabIndex = 1;
            this.ApproveButton.Text = "Approve Selected Instructor";
            this.ApproveButton.UseVisualStyleBackColor = true;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButton_Click);
            // 
            // RejectButton
            // 
            this.RejectButton.Location = new System.Drawing.Point(438, 275);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(107, 34);
            this.RejectButton.TabIndex = 2;
            this.RejectButton.Text = "Reject Selected Instructor";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // Approve_Instructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 369);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.PendingInstructorsGrid);
            this.Name = "Approve_Instructor";
            this.Text = "Instructor Requests";
            ((System.ComponentModel.ISupportInitialize)(this.PendingInstructorsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PendingInstructorsGrid;
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.Button RejectButton;
    }
}