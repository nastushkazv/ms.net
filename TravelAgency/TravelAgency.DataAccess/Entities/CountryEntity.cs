using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.DataAccess.Entities;

[Table("Countries")]
public class CountryEntity : BaseEntity
{
    public string Name { get; set; }
}