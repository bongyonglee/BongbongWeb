namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IReservationStatusRepository ReservationStatus { get; }
        void Save();
    }
}
