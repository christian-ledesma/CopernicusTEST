using AutoMapper;
using Copernicus.Christian.Api.DTOs.Customer;
using Copernicus.Christian.Api.Features.Customer.Requests.Queries;
using Copernicus.Christian.Domain.Interfaces;
using MediatR;

namespace Copernicus.Christian.Api.Features.Customer.Handlers.Queries
{
    public class GetCustomerRequestHandler : IRequestHandler<GetCustomerRequest, CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomerRequestHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<CustomerDto> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
        {
            var response = await _customerRepository.GetAsync(request.Id);
            return _mapper.Map<CustomerDto>(response);
        }
    }
}
