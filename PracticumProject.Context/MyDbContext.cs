
using Microsoft.EntityFrameworkCore;
using PracticumProject.Repositories.Entities;
using PracticumProject.Repositories.Interfaces;

namespace PracticumProject.Context
{
    public class MyDbContext : DbContext, IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ChildUser> Children { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PracticumDB;Trusted_Connection=True");
        }
    }
}