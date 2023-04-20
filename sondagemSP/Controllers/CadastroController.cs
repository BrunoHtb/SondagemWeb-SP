using Microsoft.AspNetCore.Mvc;
using sondagemSP.Repositories.Interfaces;

namespace sondagemSP.Controllers
{
    public class CadastroController : Controller
    {
        private readonly ICadastroRepository _cadastroRepository;

        public CadastroController(ICadastroRepository cadastroRepository)
        {
            _cadastroRepository = cadastroRepository;
        }

        public IActionResult Index()
        {
            var listCadastro = _cadastroRepository.Cadastros;
            return View(listCadastro);
        }
    }
}
