using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChecklistProject.Forms;
using ChecklistProject.Objects;

namespace ChecklistProject
{
    public partial class ChecklistForm : Form
    {
        public static BindingList<ChecklistTask> taskList = new BindingList<ChecklistTask>();
        public static BindingList<CompletedTask> completedTasks = new BindingList<CompletedTask>();

        public ChecklistForm()
        {
            InitializeComponent();
            checklistDisplayGridView.DataSource = taskList;
        }
        private void NewTaskButton_Click(object sender, EventArgs e)
        {
            TaskEntryForm taskEntryForm = new TaskEntryForm();
            taskEntryForm.ShowDialog();
        }
        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dataRow in this.checklistDisplayGridView.SelectedRows)
            {
                checklistDisplayGridView.Rows.RemoveAt(dataRow.Index);
            }
        }

        private void CompleteTasksButton_Click(object sender, EventArgs e)
        {
            CompletedTasksForm completedTasksForm = new CompletedTasksForm();
            completedTasksForm.ShowDialog();

        }

        private void ChecklistDisplayGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in checklistDisplayGridView.SelectedCells)
            {
                if (cell.Value.Equals(true))
                {
                    DataGridViewRow selectedRow = new DataGridViewRow();
                    selectedRow = checklistDisplayGridView.Rows[cell.RowIndex];
                    ChecklistTask selectedChecklistTask = (ChecklistTask)selectedRow.DataBoundItem;
                    CompletedTask compTask = new CompletedTask()
                    {
                        Description = selectedChecklistTask.Description,
                        DueDate = selectedChecklistTask.DueDate,
                        CompletionStatus = true,
                    };
                    completedTasks.Add(compTask);
                    taskList.Remove(selectedChecklistTask);
                }
            }
        }
    }
}
