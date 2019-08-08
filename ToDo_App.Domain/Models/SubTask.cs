using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_App.Domain
{
    public class SubTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
        public int TaskId { get; set; }
    }
}
