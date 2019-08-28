using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecklistProject.Interfaces
{
    interface IOpenTasksLogic
    {
        void SendToCompletedTaskList(DataGridViewCell selectedCell, DataGridViewRow selectedRow);

        void GetTaskFromInputData(String taskDescription, DateTime dueDate);

        void ImportAllData();

    }


}
