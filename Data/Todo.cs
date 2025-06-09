using System.ComponentModel.DataAnnotations;
using Linq.Data;

namespace linq.Data;

/// <summary>
/// Esto es una relación 1:N
/// </summary>
public class Todo
{
  [Key]
  public int Id { get; set; }
  public string Name { get; set; } = "";
  public bool Completed { get; set; }
  public virtual List<SubTodo>? SubTodos { get; set; }

  public virtual List<EtiquetaTodo>? EtiquetaTodos { get; set; }
}
