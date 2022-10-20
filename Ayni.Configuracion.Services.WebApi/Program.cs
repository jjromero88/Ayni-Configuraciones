using Ayni.Configuracion.Services.WebApi.Modules.Mapper;
using Ayni.Configuracion.Services.WebApi.Modules.Feature;
using Ayni.Configuracion.Services.WebApi.Modules.Injection;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddMapper();
builder.Services.AddControllers();
builder.Services.AddFeature(configuration);
builder.Services.AddInjection(configuration);

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

app.UseCors(x =>
{
    x.AllowAnyOrigin();
    x.AllowAnyHeader();
    x.AllowAnyMethod();
});

//app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
