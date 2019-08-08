using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_App.Models.DomainModels
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Importance Importance { get; set; }
        public Status Status { get; set; }
        public Type Type { get; set; }
        public List<SubTask> SubTasks { get; set; }
    }
    public enum Importance
    {
        Important = 1,
        MediumImportance,
        NotImportant
    }
    public enum Status
    {
        NotDone,
        InProgress,
        Done
    }
    public enum Type
    {
        Work,
        Personal,
        Hoby
    }
}
