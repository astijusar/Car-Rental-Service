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
using Microsoft.AspNetCore.Mvc;
using IdentityAPI.Filters;

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
    builder.Services.AddScoped<ValidationFilterAttribute>();

    builder.Services.Configure<ApiBehaviorOptions>(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });

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

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();

    app.MigrateDatabase();

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
