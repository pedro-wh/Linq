using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace linq.Data;

public class Todo
{
  [Key]
  public int Id { get; set; }
  public string Name { get; set; } = "";
  public bool Completed { get; set; }
  public virtual List<SubTodo>? SubTodos { get; set; }
}
