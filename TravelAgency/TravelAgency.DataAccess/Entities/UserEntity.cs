using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.DataAccess.Entities;

[Table("Users")] 
public class UserEntity: BaseEntity
{
    public string Login { get; set; }
    public string PasswordHash { get; set; }
    
    public int RoleId { get; set; }
    public RoleEntity Role { get; set; }
}