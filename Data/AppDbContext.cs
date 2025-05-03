using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace linq.Data;

public class AppDbContext : DbContext
{
    public DbSet<Todo> Todos { get; set; }

    public DbSet<SubTodo> SubTodos { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      options.LogTo(message => Debug.WriteLine(message), LogLevel.Information);
      options.UseNpgsql("Host=127.0.0.1;Port=5432;Database=mydb;Username=postgres");
    }
}
