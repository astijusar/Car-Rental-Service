using JWT;
using Microsoft.EntityFrameworkCore;
using Serilog;
using VehicleCatalogAPI.Models;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .CreateLogger();

Serilog.Debugging.SelfLog.Enable(Console.Error);

try
{
    Log.Information("Vehicle Catalog API started");

    builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

    builder.Services.AddDbContext<ApplicationDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
    });

    builder.Services.AddControllers();

    builder.Services.AddJwtAuthentication(builder.Configuration);

    builder.Services.AddLogging(builder =>
    {
        builder.ClearProviders();
        builder.AddSerilog(dispose: true);
    });

    var app = builder.Build();

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();

    app.MigrateDatabase();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Vehicle Catalog API terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
