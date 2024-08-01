using Microsoft.AspNetCore.Mvc;

namespace AulaDeASPNet.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult CadastroProduto()
        {
            return View();
        }
    }
}
