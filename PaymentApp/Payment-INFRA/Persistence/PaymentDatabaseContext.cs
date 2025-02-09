using Microsoft.EntityFrameworkCore;

namespace Payment_INFRA.Persistence
{
    public class PaymentDatabaseContext : DbContext
    {
        public PaymentDatabaseContext(DbContextOptions<PaymentDatabaseContext> opt) : base(opt) { }



    }
}
