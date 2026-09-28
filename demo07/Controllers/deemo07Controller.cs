using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using demo07.Models;
namespace demo07.Controllers
{
    public class deemo07Controller : Controller
    {
        private static List<deemo07> TaiKhoan = new List<deemo07>();
        // GET: deemo07Controller1
        public ActionResult Index()
        {
            return View(TaiKhoan);
        }

        // GET: deemo07Controller1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: deemo07Controller1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: deemo07Controller1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(deemo07 taikhoan)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(taikhoan);
                }

                TaiKhoan.Add(taikhoan);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(taikhoan);
            }
        }

        // GET: deemo07Controller1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: deemo07Controller1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: deemo07Controller1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: deemo07Controller1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
