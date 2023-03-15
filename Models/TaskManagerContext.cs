using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace AplikacjaWebowa.Models
{
    public class TaskManagerContext : DbContext 
    {
        public TaskManagerContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<TaskModel> Tasks { get; set; }
    }
}
