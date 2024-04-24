namespace CompanyManagement_API.Models;

public class Employee
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Cpf { get; set; }
    public DateTime? BirthDate { get; set; }
    public DateTime? HireDate { get; set; }
    public string? Address { get; set; }
    
}