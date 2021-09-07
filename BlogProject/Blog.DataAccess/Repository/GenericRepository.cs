using Blog.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _dbObj;
        public GenericRepository(AppDbContext dbObj)
        {
            this._dbObj = dbObj;
        }

        public async Task Add(T entity)
        {
            await _dbObj.AddAsync<T>(entity);
        }

        public void Delete(T entity)
        {
            _dbObj.Remove(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await _dbObj.FindAsync<T>(id);
            _dbObj.Remove(entity);
        }

        public T Get(int id)
        {
            return _dbObj.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbObj.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _dbObj.Update(entity);
        }
    }
}
