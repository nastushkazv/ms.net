using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.DataAccess.Entities;

[Table("Roles")] 
public class RoleEntity : BaseEntity
{
    public string Name { get; set; }
    
    public virtual ICollection<UserEntity> Users { get; set; }

}