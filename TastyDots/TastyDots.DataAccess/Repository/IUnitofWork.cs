using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyDots.Models;

namespace TastyDots.DataAccess.Repository
{
    public interface IUnitofWork: IDisposable
    {
        IGenericRepository<Menu> MenuList { get; }
        IGenericRepository<Order> Orders { get; }

        IGenericRepository<Cart> ItemList { get; }


        void Save();
    }
}
