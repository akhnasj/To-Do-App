using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class AppDbContext : DbContext

    {
        public DbSet<TodoTasks> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=todo_db;Username=postgres;Password=toor");
        }
        
    }
}


// Install - Package Microsoft.EntityFrameworkCore.Tools
// Install-Package Npgsql.EntityFrameworkCore.PostgreSQL 