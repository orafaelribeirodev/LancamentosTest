using Microsoft.OpenApi.Models;
using Projeto.Application.Services;
using Projeto.Domain.Interfaces;
using Projeto.Infrastructure.Data;
using Projeto.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configura��o do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Fluxo de Caixa",
        Version = "v1",
        Description = "API para controle de lan�amentos e consolida��o di�ria do fluxo de caixa",
        Contact = new OpenApiContact
        {
            Name = "Seu Nome",
            Email = "seuemail@email.com",
            Url = new Uri("https://github.com/seu-repositorio")
        }
    });
});

// Configurar servi�os da aplica��o
builder.Services.AddScoped<ILancamentoRepository, LancamentoRepository>();
builder.Services.AddScoped<LancamentoService>();
builder.Services.AddDbContext<ApplicationDbContext>();

builder.Services.AddControllers(); 

var app = builder.Build();

// Configura��o do Swagger no pipeline da aplica��o
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API de Fluxo de Caixa V1");
        c.RoutePrefix = string.Empty; 
    });
}

// Middleware padr�o
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllers(); 

app.Run();
