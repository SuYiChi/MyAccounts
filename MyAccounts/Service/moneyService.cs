using System;
using System.Collections.Generic;
using System.Linq;
using MyAccounts.Enum;
using MyAccounts.Models.Entity;
using MyAccounts.Models.ViewModel;
using MyAccounts.Repository.UnitOfWork;

namespace MyAccounts.Service
{
public class MoneyService
    {
        private readonly UnitOfWork _db;

        public MoneyService()
        {
            this._db = new UnitOfWork();
        }

        public IEnumerable<MoneyViewModel> GetAllMoneyReport()
        {
            return this._db.AccountBookRepository.SelectAll().Select(s =>
                new MoneyViewModel()
                {
                    Amount = s.Amounttt,
                    Category = s.Categoryyy == 0 ? Balance.Expend : Balance.Income,
                    Date = s.Dateee,
                    Description = s.Remarkkk
                }).OrderByDescending(s => s.Date);
        }

        public void InsertAccount(MoneyViewModel model)
        {
            this._db.StartTransaction();
            this._db.AccountBookRepository.Insert(new AccountBook()
            {
                Id = Guid.NewGuid(),
                Categoryyy = (int)model.Category - 1,
                Amounttt = model.Amount,
                Dateee = model.Date,
                Remarkkk = model.Description
            });
            this._db.Commit();
        }
    }
}