using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Moring0630ASPCore.Data;
using Moring0630ASPCore.Models;
using Moring0630ASPCore.Services;

namespace Moring0630ASPCore.Controllers
{
    public class FloorsController : Controller
    {

        private readonly IFloorService _service;
        public FloorsController(IFloorService service)
        {
            _service = service;
        }
        // GET: FloorsController
        public ActionResult Index()
        {
            //get your data ready for view
            List<Floor> model = _service.GetFloors();
            return View(model);
        }

        // GET: FloorsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FloorsController/Create
        public ActionResult Create()
        {
            ViewBag.BuildingId = new SelectList(_service.GetBuildings(), "Id", "Name");
            return View();
        }

        // POST: FloorsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Floor model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _service.Add(model);
                    return RedirectToAction(nameof(Index));
                }
                ViewBag.BuildingId = new SelectList(_service.GetBuildings(), "Id", "Name");
                return View(model);
            }
            catch
            {
                return View();
            }
        }

        // GET: FloorsController/Edit/5
        public ActionResult Edit(int id)
        {
            //find object to edit

            ViewBag.BuildingId = new SelectList(_service.GetBuildings(), "Id", "Name");
            var model = _service.FindFloor(id);
            return View(model);
        }

        // POST: FloorsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Floor model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _service.Update(model);

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.BuildingId = new SelectList(_service.GetBuildings(), "Id", "Name");
                    return View(model);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: FloorsController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _service.FindFloor(id);
            return View(model);
        }

        // POST: FloorsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Floor model)
        {
            try
            {
                if (id == model.Id)
                {
                    _service.Delete(id);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View();
            }
        }
    }


}
