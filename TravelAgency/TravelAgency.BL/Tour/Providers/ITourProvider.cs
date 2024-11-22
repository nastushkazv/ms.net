using TravelAgency.BL.Tour.Entities;
namespace TravelAgency.BL.Tour.Providers;

public class ITourProvider
{
    IEnumerable<TourModel> GetAllTours(TourModelFilter filter = null);
    Task<IEnumerable<TourModel>> GetAllToursAsync(TourModelFilter filter = null);
    TourModel GetTourInfo(int tourId);
    Task<TourModel> GetTourInfoAsync(int tourId);
    
}