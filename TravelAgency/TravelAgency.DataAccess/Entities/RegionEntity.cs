using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.DataAccess.Entities;

[Table("Regions")]
public class RegionEntity : BaseEntity
{
    public string Name { get; set; }
    
    public int CountryId { get; set; }
    public CountryEntity Country { get; set; }
    
    public virtual ICollection<CityEntity> Cities { get; set; }
}