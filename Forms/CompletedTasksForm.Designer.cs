namespace ChecklistProject.Forms
{
    partial class CompletedTasksForm
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
            this.completedTasksGridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.completedTasksGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // completedTasksGridview
            // 
            this.completedTasksGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.completedTasksGridview.Location = new System.Drawing.Point(13, 13);
            this.completedTasksGridview.Name = "completedTasksGridview";
            this.completedTasksGridview.Size = new System.Drawing.Size(349, 440);
            this.completedTasksGridview.TabIndex = 0;
            this.completedTasksGridview.AllowUserToAddRows = false;
            // 
            // CompletedTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 462);
            this.Controls.Add(this.completedTasksGridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CompletedTasksForm";
            this.Text = "CompletedTasksForm";
            ((System.ComponentModel.ISupportInitialize)(this.completedTasksGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView completedTasksGridview;
    }
}