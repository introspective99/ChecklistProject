﻿using ChecklistProject.Interfaces;
using ChecklistProject.Objects;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ChecklistProject.ProjectLogic
{
    internal class TaskObjectLogic : ITaskObjectLogic
    {
        public static BindingList<TaskObject> masterTaskList = new BindingList<TaskObject>();
        public void GetTaskFromInputData (String taskDescription, DateTime dueDate)
        {
            TaskObject newOpenTask = new TaskObject()
            {
                Description = taskDescription,
                DueDate = dueDate,
                CompletionStatus = false,
            };
            masterTaskList.Add(newOpenTask);
        }
        public static void RemoveTask(DataGridViewRow dataRow)
        {
            var index = Convert.ToString(dataRow.Cells[0].Value);

            foreach(TaskObject task in masterTaskList.ToList())
            {
                if(task.Description == index)
                {
                    masterTaskList.Remove(task);
                }
            }

        }
    }
}
