using System;
using System.Windows.Forms;
using ChecklistProject.Interfaces;
using ChecklistProject.ProjectLogic;

namespace ChecklistProject.Forms
{
    public partial class TaskEntryForm : Form
    {
        ITaskObjectLogic logic = new TaskObjectLogic();
        ISQLLogic sqlLogic = new SQLLogic();
        public TaskEntryForm()
        {
            InitializeComponent();
        }

        private void ConfirmNewTaskButton_Click(object sender, EventArgs e)
        {
            logic.GetTaskFromInputData(taskDescriptionTextbox.Text, dueDateCalendar.SelectionRange.Start);
            sqlLogic.SendMasterListToSQLServer();
            this.Dispose();
        }
        private void CancelNewTaskButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
