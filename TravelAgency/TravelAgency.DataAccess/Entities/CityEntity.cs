using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.DataAccess.Entities;

[Table("Cities")]
public class CityEntity : BaseEntity
{
    public string Name { get; set; }

    public int RegionId { get; set; }
    public RegionEntity Region { get; set; }
}