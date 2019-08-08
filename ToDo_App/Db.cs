using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo_App.Models.DomainModels;
using Task = ToDo_App.Models.DomainModels.Task;

namespace ToDo_App
{
    public static class Db
    {
        public static User user;

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
                               Importance = Importance.Important,
                               Status = Status.Done,
                               Type = Models.DomainModels.Type.Work,
                               SubTasks = new List<SubTask>()
                               {
                                  new SubTask()
                                  {
                                        Id=1,
                                        Title="Learn MVC",
                                        Description="Description",
                                        Done=true
                                  },
                                  new SubTask()
                                  {
                                        Id=2,
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
                               Importance = Importance.MediumImportance,
                               Status = Status.NotDone,
                               Type = Models.DomainModels.Type.Hoby,
                               SubTasks = new List<SubTask>()
                               {
                                    new SubTask()
                                    {
                                            Id=3,
                                            Title="Football",
                                            Description="Description",
                                            Done=true
                                    },
                                    new SubTask()
                                    {
                                            Id=4,
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
                               Importance = Importance.Important,
                               Status = Status.Done,
                               Type = Models.DomainModels.Type.Work,
                               SubTasks = new List<SubTask>()
                               {
                                   new SubTask()
                                   {
                                        Id=5,
                                        Title="Make React Project",
                                        Description="Description",
                                        Done=true
                                   }
                               }

                         }

                }
            };
        }
    }
}
