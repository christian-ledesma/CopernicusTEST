using AutoMapper;
using Copernicus.Christian.Api.DTOs.Customer;
using Copernicus.Christian.Domain.Entities;

namespace Copernicus.Christian.Api.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Customer
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Customer, CreateCustomerDto>().ReverseMap();
            CreateMap<Customer, UpdateCustomerDto>().ReverseMap();
            #endregion
        }
    }
}
