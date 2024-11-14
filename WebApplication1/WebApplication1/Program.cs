using WebApplication1.Clases;

Pelicula p1 = new Pelicula("ojawsdfcnaoupfn.com", "El Grinch 1997", 120, 5 );

// Crear una cuenta con un correo electrónico
Cuenta cuenta = new Cuenta("cuenta@correo.com");

// Crear usuarios con el mismo correo electrónico
Usuario usuario1 = new Usuario(1232, "Usuario 1", DateOnly.FromDateTime(DateTime.Now), "cuenta@correo.com");
Usuario usuario2 = new Usuario(123, "Usuario 2", DateOnly.FromDateTime(DateTime.Now), "cuenta@correo.com");
Usuario usuario3 = new Usuario(1232, "Usuario 3", DateOnly.FromDateTime(DateTime.Now), "cuenta@correo.com");
Usuario usuario4 = new Usuario(123323, "Usuario 4", DateOnly.FromDateTime(DateTime.Now), "cuenta@correo.com");
Usuario usuario5 = new Usuario(123112, "Usuario 5", DateOnly.FromDateTime(DateTime.Now), "cuenta@correo.com");
Usuario usuario6 = new Usuario(12323, "Usuario 6", DateOnly.FromDateTime(DateTime.Now), "cuenta@correo.com");

cuenta.AgregarUsuario(usuario1);
cuenta.AgregarUsuario(usuario2);
cuenta.AgregarUsuario(usuario3);
cuenta.AgregarUsuario(usuario4);
cuenta.AgregarUsuario(usuario5);
cuenta.AgregarUsuario(usuario6);

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
