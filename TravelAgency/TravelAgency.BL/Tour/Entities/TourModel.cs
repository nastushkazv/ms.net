namespace TravelAgency.BL.Tour.Entities;

public class TourModel
{
    public int Id { get; set; }
    public Guid ExternalId { get; set; }
    public DateTime CreationTime { get; set; }
    public DateTime ModificationTime { get; set; }
    public string Name { get; set; }
    public string Destination { get; set; }
    public int Price { get; set; }
    public int DurationDays { get; set; }
    public string TourOperator { get; set; }
    public string Description { get; set; }
    public string Transportation { get; set; }
    public string Accommodation { get; set; }
}