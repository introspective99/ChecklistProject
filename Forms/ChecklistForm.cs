using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChecklistProject.Forms;
using ChecklistProject.Objects;

namespace ChecklistProject
{
    public partial class ChecklistForm : Form
    {
        public static BindingList<ChecklistTask> taskList = new BindingList<ChecklistTask>();

        public ChecklistForm()
        {
            InitializeComponent();
            checklistDisplayGridView.DataSource = taskList;
        }
        private void NewTaskButton_Click(object sender, EventArgs e)
        {
            TaskEntryForm taskEntryForm = new TaskEntryForm();
            taskEntryForm.Show();
        }
        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dataRow in this.checklistDisplayGridView.SelectedRows)
            {
                checklistDisplayGridView.Rows.RemoveAt(dataRow.Index);
            }
        }
    }
}
