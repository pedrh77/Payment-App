using MediatR;
using Microsoft.AspNetCore.Mvc;
using Payment_APP.UseCases.User;

namespace Payment_API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IMediator _mediator) : ControllerBase
{
    [HttpPost("Register")]
    public async Task<IActionResult> RegisterUserAsync([FromQuery] RegisterUserQuery query) => Ok(await _mediator.Send(query));

}
