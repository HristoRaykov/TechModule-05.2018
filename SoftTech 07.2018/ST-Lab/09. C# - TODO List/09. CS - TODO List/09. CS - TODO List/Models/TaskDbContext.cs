using Microsoft.EntityFrameworkCore;

namespace TODOList.Models
{
    public class TaskDbContext:DbContext
    {
        public DbSet<System.Threading.Tasks.Task> Tasks { get; set; }



    }
}
