using Microsoft.EntityFrameworkCore;
using Infrastructure;
using IoC;
using System.Diagnostics;
using System.Runtime.InteropServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { 
        Title = "Ecommerce API", 
        Version = "v1",
        Description = "API para sistema de E-commerce"
    });
});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Context>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddDistributedMemoryCache();


builder.Services.AddApplicationServices();

builder.Services.AddDbContext<Context>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 21))
    )
);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ecommerce API v1");
    c.RoutePrefix = "swagger"; 
});

if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();

app.MapControllers();


if (app.Environment.IsDevelopment())
{
    var urls = app.Urls.ToArray();
    if (urls.Length == 0)
    {
        urls = ["http://localhost:5005"]; 
    }
    
    var swaggerUrl = $"{urls[0]}/swagger";
    
    _ = Task.Run(async () =>
    {
        await Task.Delay(2000);
        OpenBrowser(swaggerUrl);
    });
}

app.Run();

static void OpenBrowser(string url)
{
    try
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            Process.Start("open", url);
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            Process.Start("xdg-open", url);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Não foi possível abrir o navegador automaticamente: {ex.Message}");
        Console.WriteLine($"Acesse manualmente: {url}");
    }
}