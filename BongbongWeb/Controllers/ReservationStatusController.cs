using BongbongWeb.Data;
using Bulky.DataAccess.Repository;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;

namespace BongbongWeb.Controllers
{
    public class ReservationStatusController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;                      //필드선언
        public ReservationStatusController(IUnitOfWork unitOfWork)     //생성자
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<ReservationStatus> reservations = _unitOfWork.ReservationStatus.GetAll().ToList();
            // List<REservationStatus> 대신 var로 사용가능
            return View(reservations);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ReservationStatus obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ReservationStatus.Add(obj);
                _unitOfWork.Save();
                TempData["Success"] = "생성 성공";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            ReservationStatus? FromDb = _unitOfWork.ReservationStatus.Get(u => u.Id == id);
            if (FromDb == null)
            {
                return NotFound();
            }
            return View(FromDb);
        }
        [HttpPost]
        public IActionResult Edit(ReservationStatus obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ReservationStatus.Update(obj);
                _unitOfWork.Save();
                TempData["Success"] = "생성 성공";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            ReservationStatus? FromDb = _unitOfWork.ReservationStatus.Get(u => u.Id == id);
            if (FromDb == null)
            {
                return NotFound();
            }
            return View(FromDb);

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            ReservationStatus? obj = _unitOfWork.ReservationStatus.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.ReservationStatus.Remove(obj);
            _unitOfWork.Save();
            TempData["Success"] = "생성 성공";
            return RedirectToAction("Index");

        }
    }
}
