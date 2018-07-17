using System.Collections.Generic;
using System.Linq;
using MyAccounts.Enum;
using MyAccounts.Models.Entity;
using MyAccounts.Models.ViewModel;
using MyAccounts.Repository;

namespace MyAccounts.Service
{
public class MoneyService
    {
        private AccountBookRepository _moneyRepository;

        public MoneyService()
        {
            this._moneyRepository = new AccountBookRepository(new Money());
        }

        public IEnumerable<MoneyViewModel> GetAllMoneyReport()
        {
            return this._moneyRepository.SelectAll().Select(s =>
                new MoneyViewModel()
                {
                    Amount = s.Amounttt,
                    Category = s.Categoryyy == 0 ? Balance.Expend : Balance.Income,
                    Date = s.Dateee,
                    Description = s.Remarkkk
                });
        }
    }
}