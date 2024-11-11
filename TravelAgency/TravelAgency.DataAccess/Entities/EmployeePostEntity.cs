using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.DataAccess.Entities;

[Table("EmployeesPosts")]
public class EmployeePostEntity:BaseEntity
{
    public DateTime StartDatePost { get; set; }
    public DateTime EndDatePost { get; set; }
    
    public int EmployeeId { get; set; }
    public EmployeeEntity Employee { get; set; }
    
    public int PostId { get; set; }
    public PostEntity Post { get; set; }
}