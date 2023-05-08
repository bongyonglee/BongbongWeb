using BongbongWeb.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;

namespace Bulky.DataAccess.Repository
{
    public class ReservationStatusRepository : Repository<ReservationStatus>, IReservationStatusRepository

    {
        private readonly ApplicationDbContext _db;
        public ReservationStatusRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ReservationStatus obj)
        {
            _db.ReservationStatuses.Update(obj);
        }
    }
}
