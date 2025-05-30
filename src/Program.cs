using Application.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyApp.Resources; // <- Assumindo que MessagesHelper.cs está em Resources
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Injeção de dependência da aplicação
builder.Services.AddApplicationServices();

var app = builder.Build();

// Ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// HTTPS
app.UseHttpsRedirection();

// 📌 Definindo a cultura (en ou pt-BR)
CultureInfo.CurrentUICulture = new CultureInfo("en"); // Você pode trocar para "pt-BR" se quiser

// ✅ Teste da tradução
app.MapGet("/hello", () => MessagesHelper.Hello);
app.MapGet("/bye", () => MessagesHelper.Goodbye);
app.MapGet("/welcome", () => MessagesHelper.Welcome);

// Rota de previsão do tempo (original)
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

// 🔽 Record da previsão
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
