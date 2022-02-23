using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VasuthalozatCommonLibrary.Model;

namespace VasuthalozatCommonLibrary.Repository
{
    public class UserDbContext : DbContext
    {
        private static UserDbContext instance = null;

        public DbSet<User> Users { get; set; }

        public static UserDbContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDbContext();
                }
                return instance;
            }
        }

        private UserDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
