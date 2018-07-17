using System;
using System.Data.Entity;
using MyAccounts.Models.Entity;

namespace MyAccounts.Repository.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork, IDisposable
    {
        private Money _context = null;
        private DbContextTransaction _transaction = null;

        
        private AccountBookRepository _accountbookRepository;
		public AccountBookRepository AccountBookRepository
		{
			get
			{
				return _accountbookRepository ?? (_accountbookRepository = new AccountBookRepository(_context));
			}
		}

        public UnitOfWork()
        {
            _context = new Money();
        }

        /// <summary>
        /// 開始交易
        /// </summary>
        public void StartTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }
    
        /// <summary>
        /// 確認交易
        /// </summary>
        public void Commit()
        {
            if (_transaction == null)
                throw new NotBeginTranException("必須先呼叫 StartTransaction 方法。");

            
            _context.SaveChanges();
            _transaction.Commit();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }

    }
}

