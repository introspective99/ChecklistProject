using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChecklistProject.Objects
{
    public class OpenTasks
    {
        [DisplayName("Task Description")]
        public string Description { get; set; }
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }
        [DisplayName("Completion Check")]
        public bool CompletionStatus { get; set; }
    }
}
