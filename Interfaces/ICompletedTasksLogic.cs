using ChecklistProject.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecklistProject.Interfaces
{
    interface ICompletedTasksLogic
    {
        void SendToTaskList(DataGridViewCell selectedCompletedCell, DataGridViewRow selectedCompletedRow);
    }
}
