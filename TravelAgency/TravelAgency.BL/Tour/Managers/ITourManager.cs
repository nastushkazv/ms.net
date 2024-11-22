using TravelAgency.BL.Tour.Entities;
namespace TravelAgency.BL.Tour.Managers;

public interface ITourManager
{
    TourModel CreateTour(CreateTourModel model);
    Task<TourModel> CreateTourAsync(CreateTourModel model);
    void DeleteTour(int tourId);
    Task DeleteTourAsync(int tourId);
}