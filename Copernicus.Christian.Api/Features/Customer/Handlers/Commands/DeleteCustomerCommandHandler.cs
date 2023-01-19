using AutoMapper;
using Copernicus.Christian.Api.Features.Customer.Requests.Commands;
using Copernicus.Christian.Domain.Interfaces;
using MediatR;

namespace Copernicus.Christian.Api.Features.Customer.Handlers.Commands
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, bool>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public DeleteCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetAsync(request.Id);
            await _customerRepository.DeleteAsync(customer);
            return true;
        }
    }
}
