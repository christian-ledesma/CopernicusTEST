using AutoMapper;
using Copernicus.Christian.Api.DTOs.Customer;
using Copernicus.Christian.Api.Features.Customer.Requests.Commands;
using Copernicus.Christian.Domain.Interfaces;
using MediatR;

namespace Copernicus.Christian.Api.Features.Customer.Handlers.Commands
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<CustomerDto> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Domain.Entities.Customer>(request.Customer);
            var response = await _customerRepository.AddAsync(customer);
            return _mapper.Map<CustomerDto>(response);
        }
    }
}
