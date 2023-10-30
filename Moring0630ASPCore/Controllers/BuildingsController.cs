using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moring0630ASPCore.Models;
using Moring0630ASPCore.Services;

namespace Moring0630ASPCore.Controllers
{
    public class BuildingsController : Controller
    {
        private readonly IBuildingService _service;

        public BuildingsController(IBuildingService service)
        {
            _service = service;
        }
        // GET: BuildingsController
        public ActionResult Index()
        {
            var model = _service.ToList();
            return View(model);
        }

        // GET: BuildingsController/Details/5
        public ActionResult Details(int id)
        {
            var model = _service.Find(id);
            return View(model);
        }

        // GET: BuildingsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BuildingsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name")] Building model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int result = _service.Add(model);
                    if (result > 0)
                    {
                        TempData["message"] = $"{model.Name} was created.";
                        return RedirectToAction(nameof(Index));
                    }
                }
                return View(model);

            }
            catch
            {
                return View();
            }
        }

        // GET: BuildingsController/Edit/5
        public ActionResult Edit(int id)
        {

            var model = _service.Find(id);
            return View(model);
        }

        // POST: BuildingsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Name")] Building model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                  int result=  _service.Update(model);
                    if (result>0)
                    {
                        TempData["message"] = $"{model.Name} is updated.";
                        return RedirectToAction(nameof(Index));
                    }
                }

                return View(model);

            }
            catch
            {
                return View();
            }
        }

        // GET: BuildingsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BuildingsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                TempData["message"] = $"Deleted.";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
