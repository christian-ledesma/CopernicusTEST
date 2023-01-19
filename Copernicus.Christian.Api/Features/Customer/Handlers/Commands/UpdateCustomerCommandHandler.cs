using AutoMapper;
using Copernicus.Christian.Api.DTOs.Customer;
using Copernicus.Christian.Api.Features.Customer.Requests.Commands;
using Copernicus.Christian.Domain.Interfaces;
using MediatR;

namespace Copernicus.Christian.Api.Features.Customer.Handlers.Commands
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public UpdateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<CustomerDto> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetAsync(request.Customer.Id);
            _mapper.Map(request.Customer, customer);
            var response = await _customerRepository.EditAsync(customer);
            return _mapper.Map<CustomerDto>(response);
        }
    }
}
