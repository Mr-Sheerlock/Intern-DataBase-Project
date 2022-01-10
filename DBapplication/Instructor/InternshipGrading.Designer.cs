namespace DBapplication.Instructor
{
    partial class InternshipGrading
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
            this.GradeA = new System.Windows.Forms.Button();
            this.InternsGradesGrid = new System.Windows.Forms.DataGridView();
            this.GradeB = new System.Windows.Forms.Button();
            this.GradeC = new System.Windows.Forms.Button();
            this.GradeD = new System.Windows.Forms.Button();
            this.GradeF = new System.Windows.Forms.Button();
            this.Terminate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InternsGradesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GradeA
            // 
            this.GradeA.Location = new System.Drawing.Point(102, 367);
            this.GradeA.Margin = new System.Windows.Forms.Padding(4);
            this.GradeA.Name = "GradeA";
            this.GradeA.Size = new System.Drawing.Size(143, 42);
            this.GradeA.TabIndex = 6;
            this.GradeA.Text = "Grade A";
            this.GradeA.UseVisualStyleBackColor = true;
            this.GradeA.Click += new System.EventHandler(this.GradeA_Click);
            // 
            // InternsGradesGrid
            // 
            this.InternsGradesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InternsGradesGrid.Location = new System.Drawing.Point(39, 44);
            this.InternsGradesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.InternsGradesGrid.Name = "InternsGradesGrid";
            this.InternsGradesGrid.ReadOnly = true;
            this.InternsGradesGrid.RowHeadersWidth = 51;
            this.InternsGradesGrid.Size = new System.Drawing.Size(1091, 266);
            this.InternsGradesGrid.TabIndex = 5;
            this.InternsGradesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InternsGradesGrid_CellClick);
            this.InternsGradesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InternsGradesGrid_CellContentClick);
            this.InternsGradesGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.InternsGradesGrid_DataBindingComplete);
            // 
            // GradeB
            // 
            this.GradeB.Location = new System.Drawing.Point(286, 367);
            this.GradeB.Margin = new System.Windows.Forms.Padding(4);
            this.GradeB.Name = "GradeB";
            this.GradeB.Size = new System.Drawing.Size(143, 42);
            this.GradeB.TabIndex = 7;
            this.GradeB.Text = "Grade B";
            this.GradeB.UseVisualStyleBackColor = true;
            this.GradeB.Click += new System.EventHandler(this.GradeB_Click);
            // 
            // GradeC
            // 
            this.GradeC.Location = new System.Drawing.Point(468, 367);
            this.GradeC.Margin = new System.Windows.Forms.Padding(4);
            this.GradeC.Name = "GradeC";
            this.GradeC.Size = new System.Drawing.Size(143, 42);
            this.GradeC.TabIndex = 8;
            this.GradeC.Text = "Grade C";
            this.GradeC.UseVisualStyleBackColor = true;
            this.GradeC.Click += new System.EventHandler(this.GradeC_Click);
            // 
            // GradeD
            // 
            this.GradeD.Location = new System.Drawing.Point(642, 367);
            this.GradeD.Margin = new System.Windows.Forms.Padding(4);
            this.GradeD.Name = "GradeD";
            this.GradeD.Size = new System.Drawing.Size(143, 42);
            this.GradeD.TabIndex = 9;
            this.GradeD.Text = "Grade D";
            this.GradeD.UseVisualStyleBackColor = true;
            this.GradeD.Click += new System.EventHandler(this.GradeD_Click);
            // 
            // GradeF
            // 
            this.GradeF.Location = new System.Drawing.Point(820, 367);
            this.GradeF.Margin = new System.Windows.Forms.Padding(4);
            this.GradeF.Name = "GradeF";
            this.GradeF.Size = new System.Drawing.Size(143, 42);
            this.GradeF.TabIndex = 10;
            this.GradeF.Text = "Grade F";
            this.GradeF.UseVisualStyleBackColor = true;
            this.GradeF.Click += new System.EventHandler(this.GradeF_Click);
            // 
            // Terminate
            // 
            this.Terminate.Location = new System.Drawing.Point(468, 463);
            this.Terminate.Margin = new System.Windows.Forms.Padding(4);
            this.Terminate.Name = "Terminate";
            this.Terminate.Size = new System.Drawing.Size(143, 42);
            this.Terminate.TabIndex = 11;
            this.Terminate.Text = "Terminate";
            this.Terminate.UseVisualStyleBackColor = true;
            this.Terminate.Click += new System.EventHandler(this.Terminate_Click);
            // 
            // InternshipGrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 554);
            this.Controls.Add(this.Terminate);
            this.Controls.Add(this.GradeF);
            this.Controls.Add(this.GradeD);
            this.Controls.Add(this.GradeC);
            this.Controls.Add(this.GradeB);
            this.Controls.Add(this.GradeA);
            this.Controls.Add(this.InternsGradesGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InternshipGrading";
            this.Text = "Internship Grading";
            ((System.ComponentModel.ISupportInitialize)(this.InternsGradesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GradeA;
        private System.Windows.Forms.DataGridView InternsGradesGrid;
        private System.Windows.Forms.Button GradeB;
        private System.Windows.Forms.Button GradeC;
        private System.Windows.Forms.Button GradeD;
        private System.Windows.Forms.Button GradeF;
        private System.Windows.Forms.Button Terminate;
    }
}