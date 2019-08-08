using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo_App.Models.DomainModels;
using Task = ToDo_App.Models.DomainModels.Task;

namespace ToDo_App.Controllers
{
    [Route("User/[action]")]
    public class UserController : Controller
    {     
        
        public IActionResult Index()
        {
            User john = Db.user;
            return View(john);         
        }
        public IActionResult Statistic()
        {
            return View();
        }
        public IActionResult CreateTask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTask(Task newTask)
        {
            Db.user.Tasks.Add(newTask);
            if (newTask.Status == Status.Done)
            {
                return RedirectToAction("DoneTasks", "Task");
            }
            else  if (newTask.Status == Status.InProgress)
            {
                return RedirectToAction("InProgress", "Task");
            }
            else
            {
                return RedirectToAction("NotDone", "Task");
            }
        }
        
    }
}