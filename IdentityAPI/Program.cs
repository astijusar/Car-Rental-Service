using IdentityAPI.Mapping;
using IdentityAPI.Models;
using IdentityAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
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
    Log.Information("Identity API started");

    builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

    builder.Services.AddDbContext<ApplicationDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
    });

    builder.Services.AddControllers();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddAutoMapper(typeof(MappingProfile));

    builder.Services.AddScoped<IAuthenticationManager, AuthenticationManager>();

    var identity = builder.Services.AddIdentityCore<User>(o =>
    {
        o.Password.RequireDigit = true;
        o.Password.RequireLowercase = true;
        o.Password.RequireUppercase = true;
        o.Password.RequireNonAlphanumeric = true;
        o.Password.RequiredLength = 6;
        o.User.RequireUniqueEmail = true;
    });

    identity = new IdentityBuilder(identity.UserType, typeof(IdentityRole), identity.Services);
    identity.AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultTokenProviders();

    builder.Services.AddJwtAuthentication(builder.Configuration);

    builder.Services.AddLogging(builder =>
    {
        builder.ClearProviders();
        builder.AddSerilog(dispose: true);
    });

    var app = builder.Build();

    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;

        var context = services.GetRequiredService<ApplicationDbContext>();

        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
        }
    }

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Identity API terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
