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
        ICompletedTasksLogic logic = new Logic();
        public CompletedTasksForm()
        {
            InitializeComponent();
            completedTasksGridview.DataSource = Logic.completedTasks;
        }

        private void CompletedTasksGridview_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewCell selectedCompletedCell in completedTasksGridview.SelectedCells)
            {
                DataGridViewRow selectedCompletedRow = new DataGridViewRow();
                selectedCompletedRow = completedTasksGridview.Rows[selectedCompletedCell.RowIndex];
                logic.SendToTaskList(selectedCompletedCell, selectedCompletedRow);
            }
        }
    }
}

