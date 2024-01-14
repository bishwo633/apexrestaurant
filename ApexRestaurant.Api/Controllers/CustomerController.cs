using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SCustomer;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller;

[Route("api/customer")]
public class CustomerAsyncController : ControllerBase
{
    private readonly ICustomerServiceAsync _customerService;

    public CustomerAsyncController(ICustomerServiceAsync customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        var customer = await _customerService.GetById(id);

        if (customer == null)
            return NotFound();

        return Ok(customer);
    }

    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetAll()
    {
        var customers = await _customerService.GetAll();
        return Ok(customers);
    }

    [HttpPost]
    [Route("")]
    public async Task<IActionResult> Post([FromBody] Customer model)
    {
        await _customerService.Insert(model);
        return Ok();
    }

    [HttpPut]
    [Route("")]
    public async Task<IActionResult> Put([FromBody] Customer model)
    {
        await _customerService.Update(model);
        return Ok();
    }

    [HttpDelete]
    [Route("")]
    public async Task<IActionResult> Delete([FromBody] Customer model)
    {
        await _customerService.Delete(model);
        return Ok();
    }

}