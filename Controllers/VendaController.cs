using Microsoft.AspNetCore.Mvc;

namespace AulaDeASPNet.Controllers
{
    public class VendaController : Controller
    {
        public IActionResult CadastroVenda()
        {
            return View();
        }
    }
}
