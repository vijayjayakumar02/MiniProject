using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyDots.DataAccess.Data;
using TastyDots.Models;

namespace TastyDots.DataAccess.Repository
{
    class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _dbObj;
        public OrderRepository(AppDbContext dbObj)
        {
            this._dbObj = dbObj;
        }
        public void Delete(Order entity)
        {
            _dbObj.Remove(entity);
        }

        public void Delete(int id)
        {
            var entity = _dbObj.FindAsync<Order>(id);
            _dbObj.Remove(entity);
        }

        public Order Get(int T)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            return _dbObj.Set<Order>().ToList();
        }

        public async Task Insert(Order entity)
        {
            await _dbObj.AddAsync<Order>(entity);
        }
    }
}
