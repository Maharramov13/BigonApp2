using Microsoft.AspNetCore.Mvc;

namespace BigonApp2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
