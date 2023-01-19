using Copernicus.Christian.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Copernicus.Christian.Infrastructure.Data
{
    public class CopernicusContext : DbContext
    {
        public CopernicusContext(DbContextOptions<CopernicusContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
