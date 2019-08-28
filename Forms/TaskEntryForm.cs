using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChecklistProject.Forms;
using ChecklistProject.Interfaces;
using ChecklistProject.Objects;
using ChecklistProject.ProjectLogic;

namespace ChecklistProject.Forms
{
    public partial class TaskEntryForm : Form
    {
        IOpenTasksLogic logic = new Logic();
        public TaskEntryForm()
        {
            InitializeComponent();
        }

        private void ConfirmNewTaskButton_Click(object sender, EventArgs e)
        {
            var taskDescription = taskDescriptionTextbox.Text;
            var dueDate = dueDateCalendar.SelectionRange.Start;
            logic.GetTaskFromInputData(taskDescription, dueDate);
            this.Close();
        }
        private void CancelNewTaskButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
