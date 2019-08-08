using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_App.Domain
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskImportance Importance { get; set; }
        public TaskStatus Status { get; set; }
        public TaskType Type { get; set; }
        public List<SubTask> SubTasks { get; set; }
    }
}
