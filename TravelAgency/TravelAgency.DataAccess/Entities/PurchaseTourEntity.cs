using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.DataAccess.Entities;

[Table("PurchaseTours")]

public class PurchaseTour:BaseEntity
{
    public DateTime Data { get; set; }
    public int  Payment { get; set; }
    public int  NumberContract { get; set; }
    
    public int TourId { get; set; }
    public TourEntity Tour { get; set; }
    
    public int EmployeeId { get; set; }
    public EmployeeEntity Employee { get; set; }
    
    public int ClientId { get; set; }
    public ClientEntity Client { get; set; }
}