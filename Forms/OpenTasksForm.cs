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
using ChecklistProject.Interfaces;
using ChecklistProject.Objects;
using ChecklistProject.ProjectLogic;
using System.Data.EntityClient;

namespace ChecklistProject
{
    public partial class OpenTasksForm : Form
    {
        ISQLLogic sqlLogic = new SQLLogic();
        public OpenTasksForm()
        {
            InitializeComponent();
            sqlLogic.ReadMasterListFromSQL();
            checklistDisplayGridView.DataSource = TaskObjectLogic.masterTaskList.Where(item => item.CompletionStatus == false).ToList();
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
                TaskObjectLogic.RemoveTask(dataRow);
            }
            sqlLogic.SendMasterListToSQLServer();
            checklistDisplayGridView.DataSource = TaskObjectLogic.masterTaskList.Where(item => item.CompletionStatus == false).ToList();
        }
        private void CompleteTasksButton_Click(object sender, EventArgs e)
        {
            CompletedTasksForm completedTasksForm = new CompletedTasksForm();
            completedTasksForm.ShowDialog();
        }
        private void ChecklistDisplayGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                checklistDisplayGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void ChecklistDisplayGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            checklistDisplayGridView.DataSource = TaskObjectLogic.masterTaskList.Where(item => item.CompletionStatus == false).ToList();
            sqlLogic.SendMasterListToSQLServer();
        }

        private void OpenTasksForm_Activated(object sender, EventArgs e)
        {
            checklistDisplayGridView.DataSource = TaskObjectLogic.masterTaskList.Where(item => item.CompletionStatus == false).ToList();
        }
    }
}
