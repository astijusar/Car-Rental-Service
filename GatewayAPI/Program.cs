using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System.Text;
using JWT;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .CreateLogger();

Serilog.Debugging.SelfLog.Enable(Console.Error);

try
{
    Log.Information("API Gateway started");

    builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
    builder.Services.AddOcelot(builder.Configuration);

    builder.Services.AddJwtAuthentication(builder.Configuration);

    builder.Services.AddLogging(builder =>
    {
        builder.ClearProviders();
        builder.AddSerilog(dispose: true);
    });

    var app = builder.Build();

    app.UseAuthentication();
    app.UseAuthorization();

    app.UseOcelot();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "API Gateway terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}