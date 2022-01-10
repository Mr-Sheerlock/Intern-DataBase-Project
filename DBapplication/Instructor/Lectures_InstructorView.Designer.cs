namespace DBapplication
{
    partial class Lectures_InstructorView
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
            this.TimetableGrid = new System.Windows.Forms.DataGridView();
            this.Lecture_Combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TimetableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TimetableGrid
            // 
            this.TimetableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimetableGrid.Location = new System.Drawing.Point(60, 50);
            this.TimetableGrid.Margin = new System.Windows.Forms.Padding(4);
            this.TimetableGrid.Name = "TimetableGrid";
            this.TimetableGrid.ReadOnly = true;
            this.TimetableGrid.RowHeadersWidth = 51;
            this.TimetableGrid.Size = new System.Drawing.Size(1091, 266);
            this.TimetableGrid.TabIndex = 12;
            this.TimetableGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InternsGradesGrid_CellClick);
            this.TimetableGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.InternsGradesGrid_DataBindingComplete);
            // 
            // Lecture_Combobox
            // 
            this.Lecture_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Lecture_Combobox.FormattingEnabled = true;
            this.Lecture_Combobox.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.Lecture_Combobox.Location = new System.Drawing.Point(296, 381);
            this.Lecture_Combobox.Margin = new System.Windows.Forms.Padding(4);
            this.Lecture_Combobox.Name = "Lecture_Combobox";
            this.Lecture_Combobox.Size = new System.Drawing.Size(132, 24);
            this.Lecture_Combobox.TabIndex = 20;
            this.Lecture_Combobox.SelectedIndexChanged += new System.EventHandler(this.Lecture_Combobox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 384);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Lecture Day";
            // 
            // DateButton
            // 
            this.DateButton.Location = new System.Drawing.Point(521, 365);
            this.DateButton.Margin = new System.Windows.Forms.Padding(4);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(145, 55);
            this.DateButton.TabIndex = 22;
            this.DateButton.Text = "Confirm Date";
            this.DateButton.UseVisualStyleBackColor = true;
            this.DateButton.Click += new System.EventHandler(this.DateButton_Click);
            // 
            // Lectures_InstructorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 554);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lecture_Combobox);
            this.Controls.Add(this.TimetableGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lectures_InstructorView";
            this.Text = "Lectures Timetable";
            ((System.ComponentModel.ISupportInitialize)(this.TimetableGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TimetableGrid;
        private System.Windows.Forms.ComboBox Lecture_Combobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DateButton;
    }
}