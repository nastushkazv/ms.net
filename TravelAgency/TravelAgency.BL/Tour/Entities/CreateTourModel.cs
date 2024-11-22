namespace TravelAgency.BL.Tour.Entities;

public class CreateTourModel
{
    public string Name { get; set; }
    public string Genre { get; set; }
    public int Price { get; set; }
    public int? MinAge { get; set; }
    public string Publisher { get; set; }
    public string Description { get; set; }
}