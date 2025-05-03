using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace linq.Data;

public class SubTodo
{
  [Key]
  public int Id { get; set; }
  public string Name { get; set; } = "";
  public bool Completed { get; set; }

  [ForeignKey("Todo")]
  public int? IdTodo { get; set; }
  public virtual Todo? Todo { get; set; }
}
