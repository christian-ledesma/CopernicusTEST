using Copernicus.Christian.Domain.Entities;
using Copernicus.Christian.Domain.Interfaces;
using Copernicus.Christian.Infrastructure.Data;

namespace Copernicus.Christian.Infrastructure.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CopernicusContext context) : base(context)
        {

        }
    }
}
