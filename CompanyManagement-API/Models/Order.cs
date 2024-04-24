namespace CompanyManagement_API.Models;

public class Order
{
    public string? Id { get; set; }
    public DateTime? OrderDate { get; set; }
    public string? EmployeeId { get; set;}
    public string? CustomerId { get; set;}
    public string? ProductId { get; set; }

}