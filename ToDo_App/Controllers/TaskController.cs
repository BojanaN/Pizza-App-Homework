using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo_App.Models.DomainModels;
using Task = ToDo_App.Models.DomainModels.Task;

namespace ToDo_App.Controllers
{
    [Route("Task/[action]")]
    public class TaskController : Controller
    {

        public IActionResult DoneTasks()
        {
            User goce = Db.user;
            
            return View(goce);
        }
        public IActionResult NotDone()
        {
            User goce = Db.user;
        
            return View(goce);
        }
        public IActionResult InProgress()
        {
            User goce = Db.user;

            return View(goce);
        }
    }
}