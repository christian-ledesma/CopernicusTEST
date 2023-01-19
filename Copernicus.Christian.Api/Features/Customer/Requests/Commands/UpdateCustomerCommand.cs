using Copernicus.Christian.Api.DTOs.Customer;
using MediatR;

namespace Copernicus.Christian.Api.Features.Customer.Requests.Commands
{
    public class UpdateCustomerCommand : IRequest<CustomerDto>
    {
        public UpdateCustomerDto Customer { get; set; }
    }
}
