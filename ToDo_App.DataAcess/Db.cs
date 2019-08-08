using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo_App.Domain;
using Task = ToDo_App.Domain.Task;

namespace ToDo_App
{
    public static class Db
    {
        public static User user;
        public static List<User> users;
        static Db()
        {
            user = new User()
            {
                Id=1,
                FirstName = "John",
                LastName = "Doe",
                Age = 22,
                FreeTime = 10.5M,
                Tasks = new List<Task>
                    {
                         new Task()
                         {
                               Id=1,
                               Title = "Homework",
                               Description = "Description",
                               Importance = TaskImportance.Important,
                               Status = Domain.TaskStatus.Done,
                               Type = TaskType.Work,
                               SubTasks = new List<SubTask>()
                               {
                                  new SubTask()
                                  {
                                        Id=1,
                                        TaskId=1,
                                        Title="Learn MVC",
                                        Description="Description",
                                        Done=true
                                  },
                                  new SubTask()
                                  {
                                        Id=2,
                                        TaskId=1,
                                        Title="Make MVC Application",
                                        Description="Description",
                                        Done=true
                                  }
                               }
                         },
                         new Task()
                         {
                               Id=2,
                               Title = "Sport",
                               Description = "Description",
                               Importance = TaskImportance.MediumImportance,
                               Status = Domain.TaskStatus.NotDone,
                               Type = TaskType.Hoby,
                               SubTasks = new List<SubTask>()
                               {
                                    new SubTask()
                                    {
                                            Id=3,
                                            TaskId=2,
                                            Title="Football",
                                            Description="Description",
                                            Done=true
                                    },
                                    new SubTask()
                                    {
                                            Id=4,
                                            TaskId=2,
                                            Title="Basketball",
                                            Description="description",
                                            Done=false
                                    },
                               }
                         },
                         new Task()
                         {
                               Id=3,
                               Title = "Work",
                               Description = "Description",
                               Importance = TaskImportance.Important,
                               Status = Domain.TaskStatus.Done,
                               Type = TaskType.Work,
                               SubTasks = new List<SubTask>()
                               {
                                   new SubTask()
                                   {
                                        Id=5,
                                        TaskId=3,
                                        Title="Make React Project",
                                        Description="Description",
                                        Done=true
                                   }
                               }

                         }

                }
            };
            users.Add(user);
        }
        
    }
}
