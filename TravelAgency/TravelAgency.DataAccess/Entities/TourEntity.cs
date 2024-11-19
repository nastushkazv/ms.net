using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.DataAccess.Entities;

[Table("Tours")]
public class TourEntity: BaseEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Price { get; set; }  
    public string Insurance{ get; set; } 
    public string Hotel { get; set; } 
    
    public int TourTypeId { get; set; }
    public TourTypeEntity TourType { get; set; }
    public virtual ICollection<PurchaseTour> PurchaseTours { get; set; } 
}