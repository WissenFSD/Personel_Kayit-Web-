using Microsoft.AspNetCore.Mvc;

namespace Personel_Kayit.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
