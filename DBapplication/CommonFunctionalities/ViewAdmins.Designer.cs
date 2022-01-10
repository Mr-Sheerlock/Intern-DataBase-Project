namespace DBapplication
{
    partial class ViewAdmins
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
            this.AdminDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminDataGrid
            // 
            this.AdminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminDataGrid.Location = new System.Drawing.Point(25, 29);
            this.AdminDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.AdminDataGrid.Name = "AdminDataGrid";
            this.AdminDataGrid.ReadOnly = true;
            this.AdminDataGrid.RowHeadersWidth = 51;
            this.AdminDataGrid.Size = new System.Drawing.Size(1091, 266);
            this.AdminDataGrid.TabIndex = 6;
            this.AdminDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InternsGradesGrid_CellContentClick);
            // 
            // ViewAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 554);
            this.Controls.Add(this.AdminDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewAdmins";
            this.Text = "ViewAdmins";
            ((System.ComponentModel.ISupportInitialize)(this.AdminDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminDataGrid;
    }
}