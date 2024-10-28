namespace TravelAgency.Service.Settings
{
    public static class TravelAgencySettingsReader
    {
        public static TravelAgencySettings Read(IConfiguration configuration)
        {
            return new TravelAgencySettings()
            {
                TravelAgencyDbContextConnectionString = configuration.GetValue<string>("TravelAgencyDbContext")
            };
        }
    }
}