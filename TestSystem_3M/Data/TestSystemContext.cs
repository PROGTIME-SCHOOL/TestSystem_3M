using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;   // EF
using TestSystem_3M.Models;

namespace TestSystem_3M.Data
{
    public class TestSystemContext : DbContext
    {
        // tables
        public DbSet<Question> Question { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<User> User { get; set; }

        // cofig
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string dbName = "testSystem.db";
            string fullPath = path + dbName;

            optionsBuilder.UseSqlite($"Data Source={fullPath}");
        }
    }
}
