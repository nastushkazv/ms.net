using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.DataAccess.Entities;

[Table("Employees")] 
public class EmployeeEntity: BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public int PassportData { get; set; }
    public DateTime DateOfBirth { get; set; }
    
    public int UserId { get; set; }
    public UserEntity User { get; set; }
}