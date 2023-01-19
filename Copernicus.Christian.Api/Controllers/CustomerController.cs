using Copernicus.Christian.Api.DTOs.Customer;
using Copernicus.Christian.Api.Features.Customer.Requests.Commands;
using Copernicus.Christian.Api.Features.Customer.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Copernicus.Christian.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _mediator.Send(new GetCustomerRequest() { Id = id });
            return Ok(response);
        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetCustomerListRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateCustomerDto createCustomerDto)
        {
            var response = await _mediator.Send(new CreateCustomerCommand() { Customer = createCustomerDto });
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]UpdateCustomerDto updateCustomerDto)
        {
            var response = await _mediator.Send(new UpdateCustomerCommand() { Customer = updateCustomerDto });
            return Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteCustomerCommand() { Id = id });
            return Ok(response);
        }
    }
}
