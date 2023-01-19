using AutoMapper;
using Copernicus.Christian.Api.DTOs.Customer;
using Copernicus.Christian.Api.Features.Customer.Requests.Queries;
using Copernicus.Christian.Domain.Interfaces;
using MediatR;

namespace Copernicus.Christian.Api.Features.Customer.Handlers.Queries
{
    public class GetCustomerListRequestHandler : IRequestHandler<GetCustomerListRequest, IReadOnlyList<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomerListRequestHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        public async Task<IReadOnlyList<CustomerDto>> Handle(GetCustomerListRequest request, CancellationToken cancellationToken)
        {
            var response = await _customerRepository.GetAllAsync();
            return _mapper.Map<IReadOnlyList<CustomerDto>>(response);
        }
    }
}
