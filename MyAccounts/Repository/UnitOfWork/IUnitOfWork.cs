namespace MyAccounts.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        void StartTransaction();
        void Commit();
    }
}
