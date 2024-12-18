using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.DataAccess.Entities;

[Table("Tours")]
public class TourEntity: BaseEntity
{
    public string Name { get; set; }
    public string Destination { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Price { get; set; }  
    public string Insurance{ get; set; } 
    public string Hotel { get; set; } 
    public int DurationDays { get; set; }
    public int TourTypeId { get; set; }
    public TourTypeEntity TourType { get; set; }
    public virtual ICollection<PurchaseTourEntity> PurchaseTours { get; set; } 
}