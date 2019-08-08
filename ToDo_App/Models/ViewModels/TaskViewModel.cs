using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo_App.Models.DomainModels;
using Task = ToDo_App.Models.DomainModels.Task;

namespace ToDo_App.Models.ViewModels
{
    public class TaskViewModel
    {
        public List<Task> Tasks { get; set; }
    }
}
