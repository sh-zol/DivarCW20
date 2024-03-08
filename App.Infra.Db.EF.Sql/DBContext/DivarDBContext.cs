using App.Domain.Core.Advertise.Entities;
using App.Domain.Core.User.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.EF.Sql.DBContext
{
    public class DivarDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DL0I6I3\SHZSQLEXPRESSDB;Integrated Security=true;Database=DivarCw20;TrustServerCertificate=True;");
        }

        DbSet<Advertise> Advertises { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EntityConfigs.AdvertiseConfigs());
            modelBuilder.ApplyConfiguration(new EntityConfigs.CategoryConfigs());
            modelBuilder.ApplyConfiguration(new EntityConfigs.CityConfigs());
            modelBuilder.ApplyConfiguration(new EntityConfigs.UserConfigs());
        }
        
    }
}
