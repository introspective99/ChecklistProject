namespace ChecklistProject
{
    partial class ChecklistForm
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
            this.checklistDisplayGridView = new System.Windows.Forms.DataGridView();
            this.newTaskButton = new System.Windows.Forms.Button();
            this.removeTaskButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.checklistDisplayGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // checklistDisplayGridView
            // 
            this.checklistDisplayGridView.AllowUserToAddRows = false;
            this.checklistDisplayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checklistDisplayGridView.Location = new System.Drawing.Point(13, 13);
            this.checklistDisplayGridView.Name = "checklistDisplayGridView";
            this.checklistDisplayGridView.Size = new System.Drawing.Size(413, 495);
            this.checklistDisplayGridView.TabIndex = 0;
            // 
            // newTaskButton
            // 
            this.newTaskButton.Location = new System.Drawing.Point(13, 514);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Size = new System.Drawing.Size(214, 25);
            this.newTaskButton.TabIndex = 1;
            this.newTaskButton.Text = "New Task";
            this.newTaskButton.UseVisualStyleBackColor = true;
            this.newTaskButton.Click += new System.EventHandler(this.NewTaskButton_Click);
            // 
            // removeTaskButton
            // 
            this.removeTaskButton.Location = new System.Drawing.Point(233, 514);
            this.removeTaskButton.Name = "removeTaskButton";
            this.removeTaskButton.Size = new System.Drawing.Size(193, 25);
            this.removeTaskButton.TabIndex = 3;
            this.removeTaskButton.Text = "Remove Selected Task";
            this.removeTaskButton.UseVisualStyleBackColor = true;
            this.removeTaskButton.Click += new System.EventHandler(this.RemoveTaskButton_Click);
            // 
            // ChecklistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 548);
            this.Controls.Add(this.removeTaskButton);
            this.Controls.Add(this.newTaskButton);
            this.Controls.Add(this.checklistDisplayGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChecklistForm";
            this.Text = "Checklist";
            ((System.ComponentModel.ISupportInitialize)(this.checklistDisplayGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView checklistDisplayGridView;
        private System.Windows.Forms.Button newTaskButton;
        private System.Windows.Forms.Button removeTaskButton;
    }
}

