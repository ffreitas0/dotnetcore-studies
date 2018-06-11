using Microsoft.EntityFrameworkCore;

namespace Todo.Model
{
    public class TodoContext : DbContext
    {
        public TodoContext (DbContextOptions<TodoContext> options) : base (options)
        {

        }

        public DbSet<Todo.Model.TodoItem> TodoItems { get; set; }
    }
}
