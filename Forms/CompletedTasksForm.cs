using System.Data;
using System.Linq;
using System.Windows.Forms;
using ChecklistProject.ProjectLogic;
using ChecklistProject.Interfaces;


namespace ChecklistProject.Forms
{
    public partial class CompletedTasksForm : Form
    {
        ISQLLogic sqlLogic = new SQLLogic();
        public CompletedTasksForm()
        {
            InitializeComponent();
            completedTasksGridview.DataSource = TaskObjectLogic.masterTaskList.Where(item => item.CompletionStatus == true).ToList();
        }

        private void CompletedTasksGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            completedTasksGridview.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void CompletedTasksGridview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            completedTasksGridview.DataSource = TaskObjectLogic.masterTaskList.Where(item => item.CompletionStatus == true).ToList();
            sqlLogic.SendMasterListToSQLServer();
        }
    }
}

