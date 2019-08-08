using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_App.DataAcess.Repositories
{
    public interface IRepository<T>
    {
        T GetByID(int id);
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void DeleteById(int id);
    }
}
