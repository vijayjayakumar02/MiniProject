using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyDots.DataAccess.Data;
using TastyDots.Models;

namespace TastyDots.DataAccess.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly AppDbContext _dbObj;
        public MenuRepository(AppDbContext dbObj)
        {
            this._dbObj = dbObj;
        }
        public void Delete(Menu entity)
        {
            _dbObj.Remove(entity);
        }

        public void Delete(int id)
        {
            var entity = _dbObj.FindAsync<Menu>(id);
            _dbObj.Remove(entity);
        }

        public Menu Get(int id)
        {
            return _dbObj.Set<Menu>().Find(id);
        }

        public IEnumerable<Menu> GetAll()
        {
            return _dbObj.Set<Menu>().ToList();
        }

        public async Task Insert(Menu entity)
        {
            await _dbObj.AddAsync<Menu>(entity);
        }

        public void Update(Menu entity)
        {
            throw new NotImplementedException();
        }
    }
}
