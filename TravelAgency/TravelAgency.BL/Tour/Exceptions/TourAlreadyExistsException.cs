namespace TravelAgency.BL.Tour.Exceptions;

public class TourAlreadyExistsException : Exception
{
    public TourAlreadyExistsException() { }
    public TourAlreadyExistsException(string? message) : base(message) { }
}