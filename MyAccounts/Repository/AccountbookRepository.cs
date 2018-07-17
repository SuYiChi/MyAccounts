
using MyAccounts.Models.Entity;

namespace MyAccounts.Repository
{
    public class AccountBookRepository: GenericRepository<AccountBook>
    {
        public AccountBookRepository(Money context)
            : base(context)
        {

        }
    }
}
