

using BtkAkademiMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademiMVC.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Aplications;
            return View(model);
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //her form gönderiminde benzersiz bir token (anahtar) oluşturur ve bu token’ı sunucu tarafında doğrular.Güvenliği arttırır.
        public IActionResult Apply([FromForm] Candidate candidate)
        {//mail kontolu yaparak kayıt sorugulanıyor
            if (Repository.Aplications.Any(c => c.Email.Equals(candidate.Email)))
            {
                ModelState.AddModelError("", "Daha önce kayit yaptiniz.");
            }
            if (ModelState.IsValid)//Alanlar doluysa kayıt et
            {
                Repository.Add(candidate);
                return View("Feedback", candidate);
            }

            return View();


        }
    }
}
