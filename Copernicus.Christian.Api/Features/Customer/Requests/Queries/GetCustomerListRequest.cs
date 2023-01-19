using Copernicus.Christian.Api.DTOs.Customer;
using MediatR;

namespace Copernicus.Christian.Api.Features.Customer.Requests.Queries
{
    public class GetCustomerListRequest : IRequest<IReadOnlyList<CustomerDto>>
    {
    }
}
