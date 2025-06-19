using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using SiliconWebbApi.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("NextJsApp", policy =>
    {
        policy.WithOrigins("http://localhost:3000", // Next.js en desarrollo
                          "https://tudominio.com") // Producción
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterSwagger();
builder.Services.RegisterJwt(builder.Configuration);
builder.Services.AddDbContext<Datacontext>(x =>
      x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));




var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(x => x.SwaggerEndpoint("/swagger/v1/swagger.json", "silicon web Api v1"));
app.UseHttpsRedirection();
app.UseCors(x => x.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
app.UseAuthentication();
app.UseAuthorization();
app.UseCors("NextJsApp");
app.MapControllers();
app.Run();
