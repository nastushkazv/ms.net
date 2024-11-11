using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.DataAccess.Entities;

[Table("ToursTypes")]
public class TourTypeEntity:BaseEntity
{
    public string Name { get; set; }
}