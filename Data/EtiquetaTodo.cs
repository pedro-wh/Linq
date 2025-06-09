
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using linq.Data;

namespace Linq.Data;

/// <summary>
/// Esta es una relación N:N
/// </summary>
public class EtiquetaTodo
{
  [Key]
  public int Id { get; set; }

  [ForeignKey("Todo")]
  public int IdTodo { get; set; }
  public virtual Todo? Todo { get; set; }


  [ForeignKey("Etiqueta")]
  public int IdEtiqueta { get; set; }
  public virtual Etiqueta? Etiqueta { get; set; }
}
