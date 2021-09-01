using Microsoft.EntityFrameworkCore;
using TastyDots.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyDots.DataAccess.Data
{
    class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Menu> MyProperty { get; set; }
    }
}
