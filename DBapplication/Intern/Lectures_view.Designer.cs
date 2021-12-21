namespace DBapplication.Intern
{
    partial class Lectures_view
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
            this.LecturesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LecturesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LecturesGrid
            // 
            this.LecturesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturesGrid.Location = new System.Drawing.Point(44, 28);
            this.LecturesGrid.Name = "LecturesGrid";
            this.LecturesGrid.Size = new System.Drawing.Size(712, 395);
            this.LecturesGrid.TabIndex = 1;
            // 
            // Lectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LecturesGrid);
            this.Name = "Lectures";
            this.Text = "Lectures";
            ((System.ComponentModel.ISupportInitialize)(this.LecturesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LecturesGrid;
    }
}