using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantApp.Models;

namespace RestaurantApp.DataAccess.Data
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Menu> MenuList { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Cart> cartItems { get; set; }
    }
}
