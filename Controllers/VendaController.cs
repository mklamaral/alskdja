using Microsoft.AspNetCore.Mvc;

namespace AulaDeASPNet.Controllers
{
    public class VendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
