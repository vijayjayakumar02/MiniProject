using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyDots.DataAccess.Data;
using TastyDots.Models;

namespace TastyDots.DataAccess.Repository
{
    public class UnitofWork : IUnitofWork
    {
        private readonly AppDbContext _dbObj;
        private IGenericRepository<Menu> _menuList;
        private IGenericRepository<Order> _orders;
        private IGenericRepository<Cart> _itemList;


        public UnitofWork( AppDbContext dbObj)
        {
            this._dbObj = dbObj;
        }

        public IGenericRepository<Menu> MenuList => _menuList ??=new GenericRepository<Menu>(_dbObj);

        public IGenericRepository<Order> Orders => _orders ??= new GenericRepository<Order>(_dbObj);

        public IGenericRepository<Cart> ItemList => _itemList ??= new GenericRepository<Cart>(_dbObj);

        public void Dispose()
        {
            _dbObj.Dispose();
        }

        public void Save()
        {
            _dbObj.SaveChanges();
        }
    }
}
