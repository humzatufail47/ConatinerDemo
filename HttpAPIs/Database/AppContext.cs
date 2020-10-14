using HttpAPIs.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace HttpAPIs.Database
{
    public class AppContext:DbContext,IAppContext
    {

        public AppContext(DbContextOptions<AppContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User {FirstName="Humza",LastName="Tufail",Age=25,Gender="Male",Id=Guid.NewGuid() },
                new User { FirstName = "Salman", LastName = "AK", Age = 25, Gender = "Male", Id = Guid.NewGuid() },
                new User { FirstName = "Hadid", LastName = "Bushra", Age = 25, Gender = "Male", Id = Guid.NewGuid() },
                new User { FirstName = "Zeeshan", LastName = "Maaao", Age = 25, Gender = "Male", Id = Guid.NewGuid() },
                new User { FirstName = "Amaid", LastName = "Haider", Age = 25, Gender = "Male", Id = Guid.NewGuid() }

            );
                base.OnModelCreating(modelBuilder);
        }
    }
}
