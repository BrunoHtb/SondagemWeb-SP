using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sondagemSP.Context;

namespace sondagemSP.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioDbContext _context;

        public UsuarioController(UsuarioDbContext context)
        {
            _context = context;
        }

        //Get: Usuario
        public async Task<IActionResult> Index()
        {
            var list = _context.UserLogins.ToList();
            //Console.WriteLine(list. + " ----- " + list.Password);
            return View(await _context.Usuarios.ToListAsync());
        }

    }
}
