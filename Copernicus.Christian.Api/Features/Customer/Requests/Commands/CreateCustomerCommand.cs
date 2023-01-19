using Copernicus.Christian.Api.DTOs.Customer;
using MediatR;

namespace Copernicus.Christian.Api.Features.Customer.Requests.Commands
{
    public class CreateCustomerCommand : IRequest<CustomerDto>
    {
        public CreateCustomerDto Customer { get; set; }
    }
}
