using Copernicus.Christian.Domain.Base;

namespace Copernicus.Christian.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Email { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Company { get; set; }
        public DateTime Created_at { get; set; }
        public string Country { get; set; }
    }
}
