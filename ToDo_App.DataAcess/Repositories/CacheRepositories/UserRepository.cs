using System;
using System.Collections.Generic;
using System.Text;
using ToDo_App.Domain;
using System.Linq;

namespace ToDo_App.DataAcess.Repositories.CacheRepositories
{
    public class UserRepository : IRepository<User>
    {
        public void Create(User entity)
        {
            Db.users.Add(entity);
        }

        public void DeleteById(int id)
        {
            User user = Db.users.FirstOrDefault(u => u.Id == id);
            Db.users.Remove(user);
        }

        public List<User> GetAll()
        {
            return Db.users;
        }

        public User GetByID(int id)
        {
            User user = Db.users.FirstOrDefault(u => u.Id == id);
            return user;
        }

        public void Update(User entity)
        {
            User user = Db.users.FirstOrDefault(u => u.Id == entity.Id);
            if (user != null)
            {
                int index = Db.users.IndexOf(user);
                Db.users[index] = entity;
            }
        }
    }

}
