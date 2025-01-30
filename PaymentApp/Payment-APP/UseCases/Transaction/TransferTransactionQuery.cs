using Payment_APP.DTOs.Transaction;
using Payment_APP.Queries;

namespace Payment_APP.UseCases.Transaction
{
    public class TransferTransactionQuery : IQuery<TransferDto>
    {
        public int SenderID { get; set; }
        public int ReciverID { get; set; }
        public Decimal Amount { get; set; }
        public DateTime DateTime { get; set; }
    }
}
