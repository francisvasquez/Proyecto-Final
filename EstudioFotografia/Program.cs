using EstudioFotografia.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Registrar DbContext
builder.Services.AddDbContext<EstudioContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Agregar controladores (OBLIGATORIO para migrations)
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
