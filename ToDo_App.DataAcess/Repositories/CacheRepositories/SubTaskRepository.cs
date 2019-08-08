using System;
using System.Collections.Generic;
using System.Text;
using ToDo_App.Domain;
using System.Linq;

namespace ToDo_App.DataAcess.Repositories.CacheRepositories
{
    public class SubTaskRepository : IRepository<SubTask>
    {
        public void Create(SubTask entity)
        {
            Task task = Db.user.Tasks.FirstOrDefault(t => t.Id == entity.TaskId);
            task.SubTasks.Add(entity);
  
        }

        public void DeleteById(int id)
        {
            SubTask task=Db.user.Tasks.SelectMany(t=>t.SubTasks).FirstOrDefault(st=>st.Id==id);
            List<SubTask> subtasks = Db.user.Tasks.SelectMany(x => x.SubTasks).ToList();
            subtasks.Remove(task);
        }

        public List<SubTask> GetAll()
        {
            return Db.user.Tasks.SelectMany(x => x.SubTasks).ToList();
        }

        public SubTask GetByID(int id)
        {
            SubTask sTask = Db.user.Tasks.SelectMany(x => x.SubTasks).FirstOrDefault(y => y.Id == id);
            return sTask;
        }

        public void Update(SubTask entity)
        {
            SubTask sTask = Db.user.Tasks.SelectMany(x => x.SubTasks).FirstOrDefault(y => y.Id == entity.Id);
            List<SubTask> subtasks = Db.user.Tasks.SelectMany(x => x.SubTasks).ToList();
            if (sTask != null)
            {
                int index = subtasks.IndexOf(sTask);
                subtasks[index] = entity;
            }
        }
    }
}
