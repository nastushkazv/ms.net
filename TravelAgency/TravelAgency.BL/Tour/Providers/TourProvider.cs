using AutoMapper;
using TravelAgency.BL.Tour.Entities;
using TravelAgency.BL.Tour.Exceptions;
using TravelAgency.DataAccess.Entities;
using TravelAgency.DataAccess.Repository;

namespace TravelAgency.BL.Tour.Providers;

public class TourProvider : ITourProvider
{
    private readonly IRepository<TourEntity> _tourRepository;
    private readonly IMapper _mapper;

    public TourProvider(IRepository<TourEntity> tourRepository, IMapper mapper)
    {
        _tourRepository = tourRepository;
        _mapper = mapper;
    }

    public IEnumerable<TourModel> GetAllTours(TourModelFilter filter = null)
    {
        var namePart = filter?.NamePart;
        var destinationPart = filter?.DestinationPart;
        var minPrice = filter?.MinPrice;
        var maxPrice = filter?.MaxPrice;
        var minDurationDays = filter?.MinDurationDays;
        var maxDurationDays = filter?.MaxDurationDays;
        var tourOperatorPart = filter?.TourOperatorPart;
        var transportationPart = filter?.TransportationPart;
        var accommodationPart = filter?.AccommodationPart;

        var tours = _tourRepository.GetAll(t =>
            (namePart == null || t.Name.Contains(namePart)) &&
            (destinationPart == null || t.Destination.Contains(destinationPart)) &&
            (minPrice == null || t.Price >= minPrice) &&
            (maxPrice == null || t.Price <= maxPrice) &&
            (minDurationDays == null || t.DurationDays >= minDurationDays) &&
            (maxDurationDays == null || t.DurationDays <= maxDurationDays) &&
            (tourOperatorPart == null || t.TourOperator.Contains(tourOperatorPart)) &&
            (transportationPart == null || t.Transportation.Contains(transportationPart)) &&
            (accommodationPart == null || t.Accommodation.Contains(accommodationPart)));

        return _mapper.Map<IEnumerable<TourModel>>(tours);
    }

    public async Task<IEnumerable<TourModel>> GetAllToursAsync(TourModelFilter filter = null)
    {
        var namePart = filter?.NamePart;
        var destinationPart = filter?.DestinationPart;
        var minPrice = filter?.MinPrice;
        var maxPrice = filter?.MaxPrice;
        var minDurationDays = filter?.MinDurationDays;
        var maxDurationDays = filter?.MaxDurationDays;
        var tourOperatorPart = filter?.TourOperatorPart;
        var transportationPart = filter?.TransportationPart;
        var accommodationPart = filter?.AccommodationPart;

        var tours = await _tourRepository.GetAllAsync(t =>
            (namePart == null || t.Name.Contains(namePart)) &&
            (destinationPart == null || t.Destination.Contains(destinationPart)) &&
            (minPrice == null || t.Price >= minPrice) &&
            (maxPrice == null || t.Price <= maxPrice) &&
            (minDurationDays == null || t.DurationDays >= minDurationDays) &&
            (maxDurationDays == null || t.DurationDays <= maxDurationDays) &&
            (tourOperatorPart == null || t.TourOperator.Contains(tourOperatorPart)) &&
            (transportationPart == null || t.Transportation.Contains(transportationPart)) &&
            (accommodationPart == null || t.Accommodation.Contains(accommodationPart)));

        return _mapper.Map<IEnumerable<TourModel>>(tours);
    }

    public TourModel GetTourInfo(int tourId)
    {
        var tour = _tourRepository.GetById(tourId) ?? throw new TourNotFoundException("Tour not found");
        return _mapper.Map<TourModel>(tour);
    }

    public async Task<TourModel> GetTourInfoAsync(int tourId)
    {
        var tour = await _tourRepository.GetByIdAsync(tourId) ?? throw new TourNotFoundException("Tour not found");
        return _mapper.Map<TourModel>(tour);
    }
}
