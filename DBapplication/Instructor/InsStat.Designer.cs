namespace DBapplication.Instructor
{
    partial class InsStat
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
            this.SHOWSTAT_BTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operations_LBL = new System.Windows.Forms.Label();
            this.StatOpMenu_cmbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.yearpanel = new System.Windows.Forms.Panel();
            this.Year_textbox = new System.Windows.Forms.TextBox();
            this.Year_LBL = new System.Windows.Forms.Label();
            this.coursepanel = new System.Windows.Forms.Panel();
            this.course_cmbox = new System.Windows.Forms.ComboBox();
            this.Course_LBL = new System.Windows.Forms.Label();
            this.gradepanel = new System.Windows.Forms.Panel();
            this.Grade_LBL = new System.Windows.Forms.Label();
            this.Grade_cmbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.yearpanel.SuspendLayout();
            this.coursepanel.SuspendLayout();
            this.gradepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SHOWSTAT_BTN
            // 
            this.SHOWSTAT_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SHOWSTAT_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOWSTAT_BTN.Location = new System.Drawing.Point(987, 71);
            this.SHOWSTAT_BTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SHOWSTAT_BTN.Name = "SHOWSTAT_BTN";
            this.SHOWSTAT_BTN.Size = new System.Drawing.Size(213, 44);
            this.SHOWSTAT_BTN.TabIndex = 19;
            this.SHOWSTAT_BTN.Text = "Show Statistics";
            this.SHOWSTAT_BTN.UseVisualStyleBackColor = true;
            this.SHOWSTAT_BTN.Click += new System.EventHandler(this.SHOWSTAT_BTN_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(443, 120);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 515);
            this.dataGridView1.TabIndex = 18;
            // 
            // operations_LBL
            // 
            this.operations_LBL.AutoSize = true;
            this.operations_LBL.Location = new System.Drawing.Point(-2, -245);
            this.operations_LBL.Name = "operations_LBL";
            this.operations_LBL.Size = new System.Drawing.Size(148, 17);
            this.operations_LBL.TabIndex = 17;
            this.operations_LBL.Text = "Choose an operation: ";
            // 
            // StatOpMenu_cmbox
            // 
            this.StatOpMenu_cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.StatOpMenu_cmbox.Location = new System.Drawing.Point(152, -248);
            this.StatOpMenu_cmbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatOpMenu_cmbox.Name = "StatOpMenu_cmbox";
            this.StatOpMenu_cmbox.Size = new System.Drawing.Size(424, 24);
            this.StatOpMenu_cmbox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Choose an operation: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Number of Dropped Applicants in All Courses year Y",
            "Course X and its Lecture Dates and Time",
            "Count For Grade G  in Course C in Year Y "});
            this.comboBox1.Location = new System.Drawing.Point(640, 21);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(424, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // yearpanel
            // 
            this.yearpanel.Controls.Add(this.Year_textbox);
            this.yearpanel.Controls.Add(this.Year_LBL);
            this.yearpanel.Location = new System.Drawing.Point(12, 21);
            this.yearpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearpanel.Name = "yearpanel";
            this.yearpanel.Size = new System.Drawing.Size(179, 48);
            this.yearpanel.TabIndex = 28;
            // 
            // Year_textbox
            // 
            this.Year_textbox.Location = new System.Drawing.Point(51, 16);
            this.Year_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Year_textbox.Name = "Year_textbox";
            this.Year_textbox.Size = new System.Drawing.Size(100, 22);
            this.Year_textbox.TabIndex = 14;
            // 
            // Year_LBL
            // 
            this.Year_LBL.AutoSize = true;
            this.Year_LBL.Location = new System.Drawing.Point(3, 18);
            this.Year_LBL.Name = "Year_LBL";
            this.Year_LBL.Size = new System.Drawing.Size(42, 17);
            this.Year_LBL.TabIndex = 9;
            this.Year_LBL.Text = "Year:";
            // 
            // coursepanel
            // 
            this.coursepanel.Controls.Add(this.course_cmbox);
            this.coursepanel.Controls.Add(this.Course_LBL);
            this.coursepanel.Location = new System.Drawing.Point(12, 102);
            this.coursepanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coursepanel.Name = "coursepanel";
            this.coursepanel.Size = new System.Drawing.Size(200, 48);
            this.coursepanel.TabIndex = 29;
            // 
            // course_cmbox
            // 
            this.course_cmbox.FormattingEnabled = true;
            this.course_cmbox.Location = new System.Drawing.Point(65, 2);
            this.course_cmbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.course_cmbox.Name = "course_cmbox";
            this.course_cmbox.Size = new System.Drawing.Size(63, 24);
            this.course_cmbox.TabIndex = 18;
            // 
            // Course_LBL
            // 
            this.Course_LBL.AutoSize = true;
            this.Course_LBL.Location = new System.Drawing.Point(3, 6);
            this.Course_LBL.Name = "Course_LBL";
            this.Course_LBL.Size = new System.Drawing.Size(61, 17);
            this.Course_LBL.TabIndex = 12;
            this.Course_LBL.Text = "Course: ";
            // 
            // gradepanel
            // 
            this.gradepanel.Controls.Add(this.Grade_LBL);
            this.gradepanel.Controls.Add(this.Grade_cmbox);
            this.gradepanel.Location = new System.Drawing.Point(12, 187);
            this.gradepanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradepanel.Name = "gradepanel";
            this.gradepanel.Size = new System.Drawing.Size(131, 47);
            this.gradepanel.TabIndex = 26;
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
            // Grade_cmbox
            // 
            this.Grade_cmbox.FormattingEnabled = true;
            this.Grade_cmbox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F",
            "W"});
            this.Grade_cmbox.Location = new System.Drawing.Point(65, 7);
            this.Grade_cmbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grade_cmbox.Name = "Grade_cmbox";
            this.Grade_cmbox.Size = new System.Drawing.Size(51, 24);
            this.Grade_cmbox.TabIndex = 16;
            // 
            // InsStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 646);
            this.Controls.Add(this.gradepanel);
            this.Controls.Add(this.coursepanel);
            this.Controls.Add(this.yearpanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SHOWSTAT_BTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.operations_LBL);
            this.Controls.Add(this.StatOpMenu_cmbox);
            this.Name = "InsStat";
            this.Text = "InsStat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.yearpanel.ResumeLayout(false);
            this.yearpanel.PerformLayout();
            this.coursepanel.ResumeLayout(false);
            this.coursepanel.PerformLayout();
            this.gradepanel.ResumeLayout(false);
            this.gradepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SHOWSTAT_BTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label operations_LBL;
        private System.Windows.Forms.ComboBox StatOpMenu_cmbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel yearpanel;
        private System.Windows.Forms.TextBox Year_textbox;
        private System.Windows.Forms.Label Year_LBL;
        private System.Windows.Forms.Panel coursepanel;
        private System.Windows.Forms.ComboBox course_cmbox;
        private System.Windows.Forms.Label Course_LBL;
        private System.Windows.Forms.Panel gradepanel;
        private System.Windows.Forms.Label Grade_LBL;
        private System.Windows.Forms.ComboBox Grade_cmbox;
    }
}