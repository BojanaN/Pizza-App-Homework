using System;
using System.Collections.Generic;
using System.Text;
using ToDo_App.Domain;
using System.Linq;

namespace ToDo_App.DataAcess.Repositories.CacheRepositories
{
    public class TaskRepository : IRepository<Task>
    {
        public void Create(Task entity)
        {
            Db.user.Tasks.Add(entity);
        }

        public void DeleteById(int id)
        {
            Task task = Db.user.Tasks.FirstOrDefault(t => t.Id == id);
            Db.user.Tasks.Remove(task);
        }

        public List<Task> GetAll()
        {
            return Db.user.Tasks;
        }
  
        public Task GetByID(int id)
        {
            return Db.user.Tasks.FirstOrDefault(t => t.Id == id);
        }

        public void Update(Task entity)
        {
            Task task = Db.user.Tasks.FirstOrDefault(t => t.Id == entity.Id);
            if (task != null)
            {
                int index = Db.user.Tasks.IndexOf(task);
                Db.user.Tasks[index] = entity;
            }
        }

    }
}
