using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDevOps.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext()
        {
        }

        public TodoContext(DbContextOptions<TodoContext> options): base(options)
        {
        }

        public DbSet<TodoItem> TodoItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=88.99.153.130,1533;Database=CoreDevOpsDB;User ID=sa;Password=LWMu(9j%HcZ64;Integrated Security=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem() { Id = 1, Name = "Meeting with management", IsComplete = true, Description = "In Meeting need to discuss some points." },
                new TodoItem() { Id = 2, Name = "Go for shooping", IsComplete = false, Description = "List of this this item buy." },
                new TodoItem() { Id = 3, Name = "Call to some one for do some task", IsComplete = true, Description = "Here is task to ask to do on call." });
        }
    }
}
