using MediatR;
using Microsoft.AspNetCore.Mvc;
using Payment_APP.UseCases.Transaction;

namespace Payment_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TransactionController(IMediator _mediator) : ControllerBase
    {

        [HttpPost("Transfer")]
        public async Task<IActionResult> TransactionTransferAsync([FromQuery] TransferTransactionQuery query) => Ok(await _mediator.Send(query));
    }
}
