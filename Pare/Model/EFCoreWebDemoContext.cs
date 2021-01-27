using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using Pare;
// using Pomelo.EntityFrameworkCore.MySql;
namespace Pare
{
    
    public class EFCoreWebDemoContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            // string connectionString="server=localhost,3306;database=Paretice;uid=root,Pwd=animalcracker";

            // string DB_URL = "server=.;database=PacmanScore;User Id=root;Password=animalcracker";

            //create db 
            string test = "server=localhost, 3360;Database=PareDB;User Id=root;Password=animalcracker";
            //password: animalcracker
            // Server=127.0.0.1;Port=3306;Database=Paretice;Uid=root;Pwd=animalcracker;
            // @"Server=.\;Database=EFCoreWebDemo;Trusted_Connection=True;MultipleActiveResultSets=true"
            optionsBuilder.UseMySql(                        // Replace with your connection string.
                        test,
                        // Replace with your server version and type.
                        // For common usages, see pull request #1233.
                        new MySqlServerVersion(new Version(8, 0, 21)), // use MariaDbServerVersion for MariaDB
                         options=> options.EnableRetryOnFailure())
                    // Everything from this point on is optional but helps with debugging.
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            
            // optionsBuilder
            // .UseSqlServer(
            // @test,
            // options => options.EnableRetryOnFailure());
        }
    }
}