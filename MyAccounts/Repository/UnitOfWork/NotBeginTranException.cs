using System;

namespace MyAccounts.Repository.UnitOfWork
{
    /// <summary>
    /// 交易失敗相關 Exception.
    /// </summary>
    public class NotBeginTranException : Exception
    {
        public NotBeginTranException(string message) : base(message) { }
    }
}
