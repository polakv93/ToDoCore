using Microsoft.EntityFrameworkCore;

namespace ToDoCore.Model
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
            
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
