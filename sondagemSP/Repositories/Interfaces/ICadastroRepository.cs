using sondagemSP.Models;

namespace sondagemSP.Repositories.Interfaces
{
    public interface ICadastroRepository
    {
        IEnumerable<Cadastro> Cadastros { get; }
    }
}
