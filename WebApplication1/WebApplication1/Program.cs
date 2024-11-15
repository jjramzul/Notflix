using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Aspectos;
using WebApplication1.Clases;
using WebApplication1.Interfaces; 

var builder = WebApplication.CreateBuilder(args);

// Configurar CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirFrontendLocal", builder =>
    {
        builder.WithOrigins("http://localhost:3000")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

// Agregar servicios al contenedor de dependencias
builder.Services.AddControllers();


builder.Services.AddSingleton<IAuthService>();

// Crear el generador de proxies

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuración de Swagger para la documentación API
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// Aplicar la política de CORS
app.UseCors("PermitirFrontendLocal");
app.UseAuthorization();
app.MapControllers();

app.Run();
