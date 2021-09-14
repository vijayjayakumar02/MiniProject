using Microsoft.EntityFrameworkCore;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Blogs> Blogs { get; set; }

        public DbSet<Comments> Comments { get; set; }
    }
}
