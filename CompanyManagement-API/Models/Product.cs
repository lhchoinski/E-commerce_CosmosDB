namespace CompanyManagement_API.Models
{
    public class Product
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public double? Value { get; set; }

    }
}
