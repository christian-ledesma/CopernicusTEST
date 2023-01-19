using MediatR;

namespace Copernicus.Christian.Api.Features.Customer.Requests.Commands
{
    public class DeleteCustomerCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
