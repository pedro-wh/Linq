
using linq.Data;

//Context
using var _context = new AppDbContext();
await AppDbSeeder.SeedAsync(_context);






Console.WriteLine("Hello, World!");
