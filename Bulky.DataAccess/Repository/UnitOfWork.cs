using BongbongWeb.Data;
using Bulky.DataAccess.Repository.IRepository;

namespace Bulky.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IReservationStatusRepository ReservationStatus { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ReservationStatus = new ReservationStatusRepository(_db);       //ReservationStatus를 Controller에 주입시킬수있음
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
