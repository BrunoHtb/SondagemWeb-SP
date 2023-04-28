using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            var listCadastro = _cadastroRepository.Cadastros.OrderBy(p => p.Nome);
            return View(listCadastro);
        }

        public IActionResult Edit(int id)
        {
            var cadastroSelecionado = _cadastroRepository.Cadastros.ToList().Where(i => i.ID == id);

            //Cria uma lista de Regionais para preencher no combox
            ViewBag.RegionalList = new SelectList(new List<string> { "DR-3", "DR-4" }, cadastroSelecionado.First().Regional);

            return View(cadastroSelecionado);
        }
    }
}
