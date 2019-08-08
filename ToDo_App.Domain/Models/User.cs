using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_App.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal FreeTime { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
