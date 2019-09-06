using ChecklistProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecklistProject.Interfaces
{
    interface ITaskObjectLogic
    {
        void GetTaskFromInputData(String taskDescription, DateTime dueDate);
    }


}
