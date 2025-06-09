using System.ComponentModel.DataAnnotations;
using static Linq.Data.Enums;

namespace Linq.Data;

public class Etiqueta
{
  [Key]
  public int Id { get; set; }

  public string Name { get; set; } = "";

  public Colores Color { get; set; }

  public virtual List<EtiquetaTodo>? EtiquetaTodos { get; set; }
}
