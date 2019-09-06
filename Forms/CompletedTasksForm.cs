using ChecklistProject.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
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

