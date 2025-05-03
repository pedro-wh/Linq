
using Microsoft.EntityFrameworkCore;
using todosapp.Data;

//Context
using var _context = new AppDbContext();
await AppDbSeeder.SeedAsync(_context);


Console.WriteLine("Hello, World!");
