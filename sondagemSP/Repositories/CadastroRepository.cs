using sondagemSP.Context;
using sondagemSP.Models;
using sondagemSP.Repositories.Interfaces;

namespace sondagemSP.Repositories
{
    public class CadastroRepository : ICadastroRepository
    {
        private readonly AppDbContext _context;

        public CadastroRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cadastro> Cadastros => _context.Cadastro;
    }
}
