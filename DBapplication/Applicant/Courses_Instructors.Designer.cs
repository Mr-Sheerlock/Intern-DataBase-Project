﻿namespace DBapplication.Applicant
{
    partial class Courses_Instructors
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
            this.Courses_InstructorsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Courses_InstructorsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Courses_InstructorsGrid
            // 
            this.Courses_InstructorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Courses_InstructorsGrid.Location = new System.Drawing.Point(38, 30);
            this.Courses_InstructorsGrid.Name = "Courses_InstructorsGrid";
            this.Courses_InstructorsGrid.Size = new System.Drawing.Size(712, 395);
            this.Courses_InstructorsGrid.TabIndex = 0;
            // 
            // Courses_Instructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Courses_InstructorsGrid);
            this.Name = "Courses_Instructors";
            this.Text = "Courses and Instructors";
            ((System.ComponentModel.ISupportInitialize)(this.Courses_InstructorsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Courses_InstructorsGrid;
    }
}