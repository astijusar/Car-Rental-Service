using Microsoft.EntityFrameworkCore;
using Serilog;

namespace IdentityAPI.Models
{
    public static class MigrationManager
    {
        public static WebApplication MigrateDatabase(this WebApplication webApp)
        {
            using (var scope = webApp.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
                {
                    try
                    {
                        var pendingMigrations = appContext.Database.GetPendingMigrations();

                        if (pendingMigrations.Any())
                        {
                            appContext.Database.Migrate();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            return webApp;
        }
    }
}
