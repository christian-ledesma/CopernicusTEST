namespace Copernicus.Christian.Api.DTOs.Customer
{
    public class CreateCustomerDto
    {
        public string Email { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
    }
}
