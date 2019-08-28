namespace ChecklistProject.Forms
{
    partial class TaskEntryForm
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
            this.confirmNewTaskButton = new System.Windows.Forms.Button();
            this.cancelNewTaskButton = new System.Windows.Forms.Button();
            this.dueDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.taskDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmNewTaskButton
            // 
            this.confirmNewTaskButton.Location = new System.Drawing.Point(12, 271);
            this.confirmNewTaskButton.Name = "confirmNewTaskButton";
            this.confirmNewTaskButton.Size = new System.Drawing.Size(111, 37);
            this.confirmNewTaskButton.TabIndex = 0;
            this.confirmNewTaskButton.Text = "Confirm";
            this.confirmNewTaskButton.UseVisualStyleBackColor = true;
            this.confirmNewTaskButton.Click += new System.EventHandler(this.ConfirmNewTaskButton_Click);
            // 
            // cancelNewTaskButton
            // 
            this.cancelNewTaskButton.Location = new System.Drawing.Point(129, 271);
            this.cancelNewTaskButton.Name = "cancelNewTaskButton";
            this.cancelNewTaskButton.Size = new System.Drawing.Size(110, 37);
            this.cancelNewTaskButton.TabIndex = 1;
            this.cancelNewTaskButton.Text = "Cancel";
            this.cancelNewTaskButton.UseVisualStyleBackColor = true;
            this.cancelNewTaskButton.Click += new System.EventHandler(this.CancelNewTaskButton_Click);
            // 
            // dueDateCalendar
            // 
            this.dueDateCalendar.Location = new System.Drawing.Point(12, 97);
            this.dueDateCalendar.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dueDateCalendar.MaxSelectionCount = 1;
            this.dueDateCalendar.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dueDateCalendar.Name = "dueDateCalendar";
            this.dueDateCalendar.TabIndex = 2;
            // 
            // taskDescriptionTextbox
            // 
            this.taskDescriptionTextbox.Location = new System.Drawing.Point(12, 25);
            this.taskDescriptionTextbox.Multiline = true;
            this.taskDescriptionTextbox.Name = "taskDescriptionTextbox";
            this.taskDescriptionTextbox.Size = new System.Drawing.Size(227, 47);
            this.taskDescriptionTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Task Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pick a due date";
            // 
            // TaskEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskDescriptionTextbox);
            this.Controls.Add(this.dueDateCalendar);
            this.Controls.Add(this.cancelNewTaskButton);
            this.Controls.Add(this.confirmNewTaskButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TaskEntryForm";
            this.Text = "Enter Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmNewTaskButton;
        private System.Windows.Forms.Button cancelNewTaskButton;
        private System.Windows.Forms.MonthCalendar dueDateCalendar;
        private System.Windows.Forms.TextBox taskDescriptionTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}