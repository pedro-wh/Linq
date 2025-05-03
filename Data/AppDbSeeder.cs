namespace linq.Data;

public class AppDbSeeder
{
  public static async Task SeedAsync(AppDbContext _context)
  {
    if (!_context.Todos.Any())
    {
      var todo1 = new Todo
      {
        Name = "Ir al Gym"
      };
      var todo2 = new Todo
      {
        Name = "Comprar leche"
      };
      var todo3 = new Todo
      {
        Name = "Ser perrito"
      };
      var todo4 = new Todo
      {
        Name = "Pagarle al SAT",
        SubTodos = [
          new() {Name = "Pagar parcialidad 1", Completed=true},
          new() {Name = "Pagar parcialidad 2"},
          new() {Name = "Pagar parcialidad 3"},
        ]
      };
      var todo5 = new Todo
      {
        Name = "Desinstalar Python",
        Completed = true
      };
      var todo6 = new Todo
      {
        Name = "Tarea Diez Mil",
        SubTodos = [
          new() {Name = "SubTodo 1"},
          new() {Name = "SubTodo 2", Completed=true},
          new() {Name = "SubTodo 3", Completed=true},
        ]
      };

      _context.Todos.Add(todo1);
      _context.Todos.Add(todo2);
      _context.Todos.Add(todo3);
      _context.Todos.Add(todo4);
      _context.Todos.Add(todo5);
      _context.Todos.Add(todo6);
      await _context.SaveChangesAsync();
    }
  }
}
