using ChecklistProject.Interfaces;
using ChecklistProject.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Data.SqlClient;

namespace ChecklistProject.ProjectLogic
{
    internal class Logic : ICompletedTasksLogic, IOpenTasksLogic
    {
        public static BindingList<OpenTasks> taskList = new BindingList<OpenTasks>();
        public static BindingList<CompletedTask> completedTasks = new BindingList<CompletedTask>();

        public void SendToCompletedTaskList (DataGridViewCell selectedCell, DataGridViewRow selectedRow)
        {
                if (selectedCell.Value.Equals(true))
                {
                    OpenTasks selectedOpenTask = (OpenTasks)selectedRow.DataBoundItem;
                    CompletedTask completedTask = new CompletedTask()
                    {
                        Description = selectedOpenTask.Description,
                        DueDate = selectedOpenTask.DueDate,
                        CompletionStatus = true,
                    };
                    completedTasks.Add(completedTask);
                    taskList.Remove(selectedOpenTask);
                }
        }
        public void SendToTaskList(DataGridViewCell selectedCompletedCell, DataGridViewRow selectedCompletedRow)
        {
            if (selectedCompletedCell.Value.Equals(false))
            {
                CompletedTask completedTask = (CompletedTask)selectedCompletedRow.DataBoundItem;
                OpenTasks selectedOpenTask = new OpenTasks()
                {
                    Description = completedTask.Description,
                    DueDate = completedTask.DueDate,
                    CompletionStatus = false,
                };
                taskList.Add(selectedOpenTask);
                completedTasks.Remove(completedTask);
            }
        }
        public void GetTaskFromInputData (String taskDescription, DateTime dueDate)
        {
            OpenTasks newOpenTask = new OpenTasks()
            {
                Description = taskDescription,
                DueDate = dueDate,
                CompletionStatus = false,
            };
            taskList.Add(newOpenTask);
        }
        public static void ExportAllData()
        {
            var openTasksJson = JsonConvert.SerializeObject(taskList);
            File.WriteAllText("opentasks.json", openTasksJson);
            var completedTasksJson = JsonConvert.SerializeObject(completedTasks);
            File.WriteAllText("completedtasks.json", completedTasksJson);
        }
        public void ImportAllData()
        {
            var openTasksFile = File.ReadAllText("opentasks.json");
            BindingList<OpenTasks> startupOpenTasks = JsonConvert.DeserializeObject<BindingList<OpenTasks>>(openTasksFile);
            foreach (OpenTasks openTask in startupOpenTasks)
            {
                taskList.Add(openTask);
            }

            var completedTasksFile = File.ReadAllText("completedtasks.json");
            BindingList<CompletedTask> startupCompletedTasks = JsonConvert.DeserializeObject<BindingList<CompletedTask>>(completedTasksFile);
            foreach (CompletedTask completedTask in startupCompletedTasks)
            {
                completedTasks.Add(completedTask);
            }
        }

    }
}
