namespace TravelAgency.BL.Tour.Entities;

public class TourModelFilter
{
    public string? NamePart { get; set; }
    public string? DestinationPart { get; set; }
    public int? MinPrice { get; set; }
    public int? MaxPrice { get; set; }
    public int? MinDurationDays { get; set; }
    public int? MaxDurationDays { get; set; }
    public string? TourOperatorPart { get; set; }
    public string? TransportationPart { get; set; }
    public string? AccommodationPart { get; set; }
    
}