using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Controllers
{
    [Authorize(Roles = "Employee")]
    public class OperationController : Controller
    {
        // GET: TestController
        public IActionResult Index()
        {
            return View();
        }

        // GET: TestController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: TestController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TestController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
