using Payment_APP.DTOs.Transaction;
using Payment_APP.Queries;

namespace Payment_APP.UseCases.Transaction
{
    internal class TransferTransactionQueryHandler : IQueryHandler<TransferTransactionQuery, TransferDto>
    {
        public Task<TransferDto> Handle(TransferTransactionQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
