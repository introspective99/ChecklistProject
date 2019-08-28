using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChecklistProject.Forms;
using ChecklistProject.Objects;

namespace ChecklistProject.Forms
{
    public partial class TaskEntryForm : Form
    {
        public TaskEntryForm()
        {
            InitializeComponent();
        }

        private void ConfirmNewTaskButton_Click(object sender, EventArgs e)
        {
            ChecklistTask testTask = new ChecklistTask()
            {
                Description = taskDescriptionTextbox.Text,
                DueDate = dueDateCalendar.SelectionRange.Start,
                CompletionStatus = false,
            };
            ChecklistForm.taskList.Add(testTask);
            this.Close();
        }
        private void CancelNewTaskButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
