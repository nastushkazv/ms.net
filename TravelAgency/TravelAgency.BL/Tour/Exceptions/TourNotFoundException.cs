namespace TravelAgency.BL.Tour.Exceptions;

public class TourNotFoundException : Exception
{
    public TourNotFoundException() { }
    public TourNotFoundException(string? message) : base(message) { }
}