using System;

namespace ChecklistProject.Interfaces
{
    interface ITaskObjectLogic
    {
        void GetTaskFromInputData(String taskDescription, DateTime dueDate);
    }


}
