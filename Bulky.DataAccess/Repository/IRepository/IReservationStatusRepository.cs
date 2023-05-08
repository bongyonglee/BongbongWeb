using Bulky.Models;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IReservationStatusRepository : IRepository<ReservationStatus>
    {
        void Update(ReservationStatus obj);

    }
}
