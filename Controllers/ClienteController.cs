using Microsoft.AspNetCore.Mvc;

namespace AulaDeASPNet.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult CadastroCliente()
        {
            return View();
        }
    }
}
