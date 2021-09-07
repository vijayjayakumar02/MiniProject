using Blog.DataAccess.Data;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Repository
{
    public class UnitofWork : IUnitofWork
    {
        private readonly AppDbContext _dbObj;
        private IGenericRepository<Blogs> _blogs;
        private IGenericRepository<Comments> _comments;

        public UnitofWork(AppDbContext dbObj)
        {
            this._dbObj = dbObj;
        }

        public IGenericRepository<Blogs> Blogs => _blogs ??= new GenericRepository<Blogs>(_dbObj);

        public IGenericRepository<Comments> Comments => _comments ??= new GenericRepository<Comments>(_dbObj);

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
