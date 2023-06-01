using JWT;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddJwtAuthentication(builder.Configuration);

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
