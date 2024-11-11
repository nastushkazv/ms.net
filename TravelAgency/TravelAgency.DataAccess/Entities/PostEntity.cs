using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.DataAccess.Entities;

[Table("Posts")]
public class PostEntity: BaseEntity
{
    public string Name { get; set; }
}