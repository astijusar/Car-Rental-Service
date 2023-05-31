using IdentityAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication();

var identity = builder.Services.AddIdentityCore<User>(o =>
{
    o.Password.RequireDigit = true;
    o.Password.RequireLowercase = true;
    o.Password.RequireUppercase = true;
    o.Password.RequireNonAlphanumeric = true;
    o.Password.RequiredLength = 6;
    o.User.RequireUniqueEmail = true;
    o.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ@";
});

identity = new IdentityBuilder(identity.UserType, typeof(IdentityRole), identity.Services);
identity.AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();


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

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
