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

namespace ChecklistProject
{
    public partial class OpenTasksForm : Form
    {
        IOpenTasksLogic logic = new Logic();
        public OpenTasksForm()
        {
            InitializeComponent();
            logic.ImportAllData();
            checklistDisplayGridView.DataSource = Logic.taskList;
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
            foreach (DataGridViewCell selectedCell in checklistDisplayGridView.SelectedCells)
            {
                DataGridViewRow selectedRow = new DataGridViewRow();
                selectedRow = checklistDisplayGridView.Rows[selectedCell.RowIndex];
                logic.SendToCompletedTaskList(selectedCell, selectedRow);
            }
        }

        private void ExportTasksButton_Click(object sender, EventArgs e)
        {
            //Logic.ExportAllData();
            //MessageBox.Show("Lists Exported");
            SQLLogic.ClearSQLTable();
            SQLLogic.SendToSQLServer();
            SQLLogic.sqlConnection.Close();
        }
    }
}
