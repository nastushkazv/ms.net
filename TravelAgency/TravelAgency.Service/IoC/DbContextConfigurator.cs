using TravelAgency.Service.Settings;
using Microsoft.EntityFrameworkCore;
using TravelAgency.DataAccess;

namespace TravelAgency.Service.IoC;

public static class DbContextConfigurator
{
    public static void ConfigureService(IServiceCollection services, TravelAgencySettings settings)
    {
        services.AddDbContextFactory<TravelAgencyDbContext>(
            options => { options.UseNpgsql(settings.TravelAgencyDbContextConnectionString); },
            ServiceLifetime.Scoped);
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<TravelAgencyDbContext>>();
        using var context = contextFactory.CreateDbContext();
        context.Database.Migrate();
    }
}