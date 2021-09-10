using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        Task Add(T entity);

        void Delete(T entity);

        Task Delete(int id);

        void Update(T entity);
    }
}
