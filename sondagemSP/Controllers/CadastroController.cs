using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sondagemSP.Repositories.Interfaces;
using sondagemSP.Models;
using sondagemSP.Context;

namespace sondagemSP.Controllers
{
    public class CadastroController : Controller
    {
        private readonly ICadastroRepository _cadastroRepository;
        private readonly AppDbContext _context;
        public CadastroController(ICadastroRepository cadastroRepository, AppDbContext context)
        {
            _cadastroRepository = cadastroRepository;
            _context = context;
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
            //Cria uma lista de subtrecho para preencher no combox
            ViewBag.SubtrechoList = new SelectList(new List<string> { "020", "030", "20", "30" }, cadastroSelecionado.First().Subtrecho);

            return View(cadastroSelecionado);
        }

        [HttpPost]
        public IActionResult Save(Cadastro cadastroAtualizar)
        {
            /*
             login='', km='', metro='', trecho='', observacao='', entrega='', data_modificacao='', data_cadastro=''
             */
            cadastroAtualizar.Login = (cadastroAtualizar.Login == null) ? "" : cadastroAtualizar.Login;
            cadastroAtualizar.Metro = (cadastroAtualizar.Metro == null) ? "" : cadastroAtualizar.Metro;
            cadastroAtualizar.Data_Cadastro = (cadastroAtualizar.Data_Cadastro == null) ? "" : cadastroAtualizar.Data_Cadastro;
            cadastroAtualizar.Km = (cadastroAtualizar.Km == null) ? "" : cadastroAtualizar.Km;
            cadastroAtualizar.Area = (cadastroAtualizar.Area == null) ? "" : cadastroAtualizar.Area;
            cadastroAtualizar.Observacao = (cadastroAtualizar.Observacao == null) ? "" : cadastroAtualizar.Observacao;
            cadastroAtualizar.Trecho = (cadastroAtualizar.Trecho == null) ? "" : cadastroAtualizar.Trecho;
            cadastroAtualizar.Entrega = (cadastroAtualizar.Entrega == null) ? "" : cadastroAtualizar.Entrega;

            cadastroAtualizar.Camadas = cadastroAtualizar.Camada1 + ";" + cadastroAtualizar.Camada2 + ";" + cadastroAtualizar.Camada3 + ";" + cadastroAtualizar.Camada4 + ";";
            cadastroAtualizar.Espessuras = cadastroAtualizar.Espessura1 + ";" + cadastroAtualizar.Espessura2 + ";" + cadastroAtualizar.Espessura3 + ";" + cadastroAtualizar.Espessura4 + ";";
            cadastroAtualizar.Fotos = cadastroAtualizar.Fotos;

            cadastroAtualizar.Data_Modificacao = DateTime.Now.ToString("ddMMyyyy_HHmmssfff");
            _context.Cadastro.Update(cadastroAtualizar);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
