using TravelAgency.Service.IoC;
using TravelAgency.Service.Settings;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false)
    .Build();

var settings = TravelAgencySettingsReader.Read(configuration);

var builder = WebApplication.CreateBuilder(args);

SerilogConfigurator.ConfigureService(builder);
DbContextConfigurator.ConfigureService(builder.Services, settings);
SwaggerConfigurator.ConfigureServices(builder.Services);

var app = builder.Build();

SerilogConfigurator.ConfigureApplication(app);
DbContextConfigurator.ConfigureApplication(app);
SwaggerConfigurator.ConfigureApplication(app);

app.UseHttpsRedirection();

app.Run();