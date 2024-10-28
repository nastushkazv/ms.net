using TravelAgency.Service.Settings;
using Microsoft.EntityFrameworkCore;

namespace TravelAgency.Service.IoC;

public static class DbContextConfigurator
{
    public static void ConfigureService(IServiceCollection services, TravelAgencySettings settings)
    {
        services.AddDbContextFactory<DbContext>(
            options => { options.UseNpgsql(settings.TravelAgencyDbContextConnectionString); },
            ServiceLifetime.Scoped);
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<DbContext>>();
        using var context = contextFactory.CreateDbContext();
        context.Database.Migrate();
    }
}