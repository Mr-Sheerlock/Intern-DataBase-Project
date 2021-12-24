
namespace DBapplication.Admin
{
    partial class Statistics
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
            this.operations_LBL = new System.Windows.Forms.Label();
            this.StatOpMenu_cmbox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Year_LBL = new System.Windows.Forms.Label();
            this.Grade_LBL = new System.Windows.Forms.Label();
            this.DEPART_LBL = new System.Windows.Forms.Label();
            this.Course_LBL = new System.Windows.Forms.Label();
            this.Location_LBL = new System.Windows.Forms.Label();
            this.Year_textbox = new System.Windows.Forms.TextBox();
            this.SHOWSTAT_BTN = new System.Windows.Forms.Button();
            this.Grade_cmbox = new System.Windows.Forms.ComboBox();
            this.loc_combox = new System.Windows.Forms.ComboBox();
            this.course_cmbox = new System.Windows.Forms.ComboBox();
            this.Dep_cmbox = new System.Windows.Forms.ComboBox();
            this.DEPID_LBL = new System.Windows.Forms.Label();
            this.DepID_cmbox = new System.Windows.Forms.ComboBox();
            this.BRANCHID_LBL = new System.Windows.Forms.Label();
            this.BranchID_cmbox = new System.Windows.Forms.ComboBox();
            this.depid_panel = new System.Windows.Forms.Panel();
            this.coursepanel = new System.Windows.Forms.Panel();
            this.locationpanel = new System.Windows.Forms.Panel();
            this.gradepanel = new System.Windows.Forms.Panel();
            this.departmentname_panel = new System.Windows.Forms.Panel();
            this.yearpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.depid_panel.SuspendLayout();
            this.coursepanel.SuspendLayout();
            this.locationpanel.SuspendLayout();
            this.gradepanel.SuspendLayout();
            this.departmentname_panel.SuspendLayout();
            this.yearpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // operations_LBL
            // 
            this.operations_LBL.AutoSize = true;
            this.operations_LBL.Location = new System.Drawing.Point(321, 15);
            this.operations_LBL.Name = "operations_LBL";
            this.operations_LBL.Size = new System.Drawing.Size(148, 17);
            this.operations_LBL.TabIndex = 7;
            this.operations_LBL.Text = "Choose an operation: ";
            // 
            // StatOpMenu_cmbox
            // 
            this.StatOpMenu_cmbox.FormattingEnabled = true;
            this.StatOpMenu_cmbox.Items.AddRange(new object[] {
            "Number of Applicants For Each Department",
            "Number of Interns for each Department",
            "Number of Instructors for each Department",
            "Number of Dropped Applicants in All Courses year Y",
            "Number of Grades in Courses in Year Y in a given department D",
            "Available Courses X For Department D and Their Location L",
            "Search for locations L for Course C ",
            "Course X and its Lecture Dates and Time",
            "Courses and Their Instructors Data",
            "Count For Grade G  in Course C in Year Y "});
            this.StatOpMenu_cmbox.Location = new System.Drawing.Point(475, 12);
            this.StatOpMenu_cmbox.Name = "StatOpMenu_cmbox";
            this.StatOpMenu_cmbox.Size = new System.Drawing.Size(424, 24);
            this.StatOpMenu_cmbox.TabIndex = 6;
            this.StatOpMenu_cmbox.SelectedIndexChanged += new System.EventHandler(this.StatOpMenu_cmbox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(368, 522);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 437);
            this.dataGridView1.TabIndex = 8;
            // 
            // Year_LBL
            // 
            this.Year_LBL.AutoSize = true;
            this.Year_LBL.Location = new System.Drawing.Point(3, 19);
            this.Year_LBL.Name = "Year_LBL";
            this.Year_LBL.Size = new System.Drawing.Size(42, 17);
            this.Year_LBL.TabIndex = 9;
            this.Year_LBL.Text = "Year:";
            // 
            // Grade_LBL
            // 
            this.Grade_LBL.AutoSize = true;
            this.Grade_LBL.Location = new System.Drawing.Point(3, 11);
            this.Grade_LBL.Name = "Grade_LBL";
            this.Grade_LBL.Size = new System.Drawing.Size(56, 17);
            this.Grade_LBL.TabIndex = 10;
            this.Grade_LBL.Text = "Grade: ";
            // 
            // DEPART_LBL
            // 
            this.DEPART_LBL.AutoSize = true;
            this.DEPART_LBL.Location = new System.Drawing.Point(9, 10);
            this.DEPART_LBL.Name = "DEPART_LBL";
            this.DEPART_LBL.Size = new System.Drawing.Size(131, 17);
            this.DEPART_LBL.TabIndex = 11;
            this.DEPART_LBL.Text = "Department Name: ";
            // 
            // Course_LBL
            // 
            this.Course_LBL.AutoSize = true;
            this.Course_LBL.Location = new System.Drawing.Point(2, 6);
            this.Course_LBL.Name = "Course_LBL";
            this.Course_LBL.Size = new System.Drawing.Size(61, 17);
            this.Course_LBL.TabIndex = 12;
            this.Course_LBL.Text = "Course: ";
            // 
            // Location_LBL
            // 
            this.Location_LBL.AutoSize = true;
            this.Location_LBL.Location = new System.Drawing.Point(9, 7);
            this.Location_LBL.Name = "Location_LBL";
            this.Location_LBL.Size = new System.Drawing.Size(66, 17);
            this.Location_LBL.TabIndex = 13;
            this.Location_LBL.Text = "Location:";
            // 
            // Year_textbox
            // 
            this.Year_textbox.Location = new System.Drawing.Point(51, 16);
            this.Year_textbox.Name = "Year_textbox";
            this.Year_textbox.Size = new System.Drawing.Size(100, 22);
            this.Year_textbox.TabIndex = 14;
            // 
            // SHOWSTAT_BTN
            // 
            this.SHOWSTAT_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SHOWSTAT_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOWSTAT_BTN.Location = new System.Drawing.Point(912, 472);
            this.SHOWSTAT_BTN.Name = "SHOWSTAT_BTN";
            this.SHOWSTAT_BTN.Size = new System.Drawing.Size(214, 44);
            this.SHOWSTAT_BTN.TabIndex = 15;
            this.SHOWSTAT_BTN.Text = "Show Statistics";
            this.SHOWSTAT_BTN.UseVisualStyleBackColor = true;
            this.SHOWSTAT_BTN.Click += new System.EventHandler(this.SHOWSTAT_BTN_Click);
            // 
            // Grade_cmbox
            // 
            this.Grade_cmbox.FormattingEnabled = true;
            this.Grade_cmbox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "W"});
            this.Grade_cmbox.Location = new System.Drawing.Point(65, 8);
            this.Grade_cmbox.Name = "Grade_cmbox";
            this.Grade_cmbox.Size = new System.Drawing.Size(51, 24);
            this.Grade_cmbox.TabIndex = 16;
            // 
            // loc_combox
            // 
            this.loc_combox.FormattingEnabled = true;
            this.loc_combox.Location = new System.Drawing.Point(81, 7);
            this.loc_combox.Name = "loc_combox";
            this.loc_combox.Size = new System.Drawing.Size(100, 24);
            this.loc_combox.TabIndex = 17;
            // 
            // course_cmbox
            // 
            this.course_cmbox.FormattingEnabled = true;
            this.course_cmbox.Location = new System.Drawing.Point(65, 3);
            this.course_cmbox.Name = "course_cmbox";
            this.course_cmbox.Size = new System.Drawing.Size(62, 24);
            this.course_cmbox.TabIndex = 18;
            // 
            // Dep_cmbox
            // 
            this.Dep_cmbox.FormattingEnabled = true;
            this.Dep_cmbox.Location = new System.Drawing.Point(139, 7);
            this.Dep_cmbox.Name = "Dep_cmbox";
            this.Dep_cmbox.Size = new System.Drawing.Size(95, 24);
            this.Dep_cmbox.TabIndex = 19;
            // 
            // DEPID_LBL
            // 
            this.DEPID_LBL.AutoSize = true;
            this.DEPID_LBL.Location = new System.Drawing.Point(3, 3);
            this.DEPID_LBL.Name = "DEPID_LBL";
            this.DEPID_LBL.Size = new System.Drawing.Size(103, 17);
            this.DEPID_LBL.TabIndex = 20;
            this.DEPID_LBL.Text = "Department ID:";
            // 
            // DepID_cmbox
            // 
            this.DepID_cmbox.FormattingEnabled = true;
            this.DepID_cmbox.Location = new System.Drawing.Point(112, 3);
            this.DepID_cmbox.Name = "DepID_cmbox";
            this.DepID_cmbox.Size = new System.Drawing.Size(53, 24);
            this.DepID_cmbox.TabIndex = 21;
            // 
            // BRANCHID_LBL
            // 
            this.BRANCHID_LBL.AutoSize = true;
            this.BRANCHID_LBL.Location = new System.Drawing.Point(5, 37);
            this.BRANCHID_LBL.Name = "BRANCHID_LBL";
            this.BRANCHID_LBL.Size = new System.Drawing.Size(74, 17);
            this.BRANCHID_LBL.TabIndex = 22;
            this.BRANCHID_LBL.Text = "Branch ID:";
            // 
            // BranchID_cmbox
            // 
            this.BranchID_cmbox.FormattingEnabled = true;
            this.BranchID_cmbox.Location = new System.Drawing.Point(108, 33);
            this.BranchID_cmbox.Name = "BranchID_cmbox";
            this.BranchID_cmbox.Size = new System.Drawing.Size(46, 24);
            this.BranchID_cmbox.TabIndex = 23;
            // 
            // depid_panel
            // 
            this.depid_panel.Controls.Add(this.BranchID_cmbox);
            this.depid_panel.Controls.Add(this.DepID_cmbox);
            this.depid_panel.Controls.Add(this.BRANCHID_LBL);
            this.depid_panel.Controls.Add(this.DEPID_LBL);
            this.depid_panel.Location = new System.Drawing.Point(5, 259);
            this.depid_panel.Name = "depid_panel";
            this.depid_panel.Size = new System.Drawing.Size(184, 68);
            this.depid_panel.TabIndex = 24;
            // 
            // coursepanel
            // 
            this.coursepanel.Controls.Add(this.course_cmbox);
            this.coursepanel.Controls.Add(this.Course_LBL);
            this.coursepanel.Location = new System.Drawing.Point(8, 106);
            this.coursepanel.Name = "coursepanel";
            this.coursepanel.Size = new System.Drawing.Size(200, 48);
            this.coursepanel.TabIndex = 25;
            // 
            // locationpanel
            // 
            this.locationpanel.Controls.Add(this.loc_combox);
            this.locationpanel.Controls.Add(this.Location_LBL);
            this.locationpanel.Location = new System.Drawing.Point(8, 213);
            this.locationpanel.Name = "locationpanel";
            this.locationpanel.Size = new System.Drawing.Size(200, 40);
            this.locationpanel.TabIndex = 25;
            // 
            // gradepanel
            // 
            this.gradepanel.Controls.Add(this.Grade_LBL);
            this.gradepanel.Controls.Add(this.Grade_cmbox);
            this.gradepanel.Location = new System.Drawing.Point(8, 160);
            this.gradepanel.Name = "gradepanel";
            this.gradepanel.Size = new System.Drawing.Size(130, 47);
            this.gradepanel.TabIndex = 25;
            // 
            // departmentname_panel
            // 
            this.departmentname_panel.Controls.Add(this.Dep_cmbox);
            this.departmentname_panel.Controls.Add(this.DEPART_LBL);
            this.departmentname_panel.Location = new System.Drawing.Point(8, 66);
            this.departmentname_panel.Name = "departmentname_panel";
            this.departmentname_panel.Size = new System.Drawing.Size(237, 34);
            this.departmentname_panel.TabIndex = 25;
            // 
            // yearpanel
            // 
            this.yearpanel.Controls.Add(this.Year_textbox);
            this.yearpanel.Controls.Add(this.Year_LBL);
            this.yearpanel.Location = new System.Drawing.Point(8, 12);
            this.yearpanel.Name = "yearpanel";
            this.yearpanel.Size = new System.Drawing.Size(178, 48);
            this.yearpanel.TabIndex = 27;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 971);
            this.Controls.Add(this.yearpanel);
            this.Controls.Add(this.locationpanel);
            this.Controls.Add(this.gradepanel);
            this.Controls.Add(this.departmentname_panel);
            this.Controls.Add(this.coursepanel);
            this.Controls.Add(this.depid_panel);
            this.Controls.Add(this.SHOWSTAT_BTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.operations_LBL);
            this.Controls.Add(this.StatOpMenu_cmbox);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.depid_panel.ResumeLayout(false);
            this.depid_panel.PerformLayout();
            this.coursepanel.ResumeLayout(false);
            this.coursepanel.PerformLayout();
            this.locationpanel.ResumeLayout(false);
            this.locationpanel.PerformLayout();
            this.gradepanel.ResumeLayout(false);
            this.gradepanel.PerformLayout();
            this.departmentname_panel.ResumeLayout(false);
            this.departmentname_panel.PerformLayout();
            this.yearpanel.ResumeLayout(false);
            this.yearpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label operations_LBL;
        private System.Windows.Forms.ComboBox StatOpMenu_cmbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Year_LBL;
        private System.Windows.Forms.Label Grade_LBL;
        private System.Windows.Forms.Label DEPART_LBL;
        private System.Windows.Forms.Label Course_LBL;
        private System.Windows.Forms.Label Location_LBL;
        private System.Windows.Forms.TextBox Year_textbox;
        private System.Windows.Forms.Button SHOWSTAT_BTN;
        private System.Windows.Forms.ComboBox Grade_cmbox;
        private System.Windows.Forms.ComboBox loc_combox;
        private System.Windows.Forms.ComboBox course_cmbox;
        private System.Windows.Forms.ComboBox Dep_cmbox;
        private System.Windows.Forms.Label DEPID_LBL;
        private System.Windows.Forms.ComboBox DepID_cmbox;
        private System.Windows.Forms.Label BRANCHID_LBL;
        private System.Windows.Forms.ComboBox BranchID_cmbox;
        private System.Windows.Forms.Panel depid_panel;
        private System.Windows.Forms.Panel coursepanel;
        private System.Windows.Forms.Panel locationpanel;
        private System.Windows.Forms.Panel gradepanel;
        private System.Windows.Forms.Panel departmentname_panel;
        private System.Windows.Forms.Panel yearpanel;
    }
}