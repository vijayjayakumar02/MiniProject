using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Repository
{
    public interface IUnitofWork : IDisposable
    {
        IGenericRepository<Blogs> Blogs { get; }

        IGenericRepository<Comments> Comments { get; }

        void Save();
    }
}
