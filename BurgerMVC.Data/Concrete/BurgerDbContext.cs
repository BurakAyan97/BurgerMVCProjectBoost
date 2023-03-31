using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.DataLayer.Concrete
{
    public class BurgerDbContext : IdentityDbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-S2C7UGO;Database=BurgerMVCProjectDB;User ID=sa;Password=arkadas1")
            base.OnConfiguring(optionsBuilder);
        }
    }
}
