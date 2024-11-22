using AutoMapper;
using TravelAgency.BL.Tour.Entities;
using TravelAgency.BL.Tour.Exceptions;
using TravelAgency.DataAccess.Entities;
using TravelAgency.DataAccess.Repository;

namespace TravelAgency.BL.Tour.Managers;

public class TourManager : ITourManager
{
    private readonly IRepository<TourEntity> _tourRepository;
    private readonly IMapper _mapper;

    public TourManager(IRepository<TourEntity> tourRepository, IMapper mapper)
    {
        _tourRepository = tourRepository;
        _mapper = mapper;
    }

    public TourModel CreateTour(CreateTourModel model)
    {
        var entity = _mapper.Map<TourEntity>(model);
        try
        {
            entity = _tourRepository.Save(entity);
            return _mapper.Map<TourModel>(entity);
        }
        catch (Exception e)
        {
            throw new TourAlreadyExistsException("Tour with this name or other identifying information already exists.");
        }
    }

    public async Task<TourModel> CreateTourAsync(CreateTourModel model)
    {
        var entity = _mapper.Map<TourEntity>(model);
        try
        {
            entity = await _tourRepository.SaveAsync(entity);
            return _mapper.Map<TourModel>(entity);
        }
        catch (Exception e)
        {
            throw new TourAlreadyExistsException("Tour with this name or other identifying information already exists.");
        }
    }

    public void DeleteTour(int tourId)
    {
        var entity = _tourRepository.GetById(tourId);
        if (entity == null)
        {
            throw new TourNotFoundException("Tour not found");
        }
        _tourRepository.Delete(entity);
    }

    public async Task DeleteTourAsync(int tourId)
    {
        var entity = await _tourRepository.GetByIdAsync(tourId);
        if (entity == null)
        {
            throw new TourNotFoundException("Tour not found");
        }
        await _tourRepository.DeleteAsync(entity);
    }
}