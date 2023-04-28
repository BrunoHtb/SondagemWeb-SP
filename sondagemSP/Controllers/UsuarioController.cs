using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sondagemSP.Context;
using sondagemSP.Services;

namespace sondagemSP.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioDbContext _context;
        private IMapper _mapper;

        public UsuarioController(UsuarioDbContext context, IMapper mapper)
        {
            _mapper = mapper; 
            _context = context;

        }

        //Get: Usuario
        public async Task<IActionResult> Index()
        {
            var list = _context.UserLogins.ToList();
            //Console.WriteLine(list. + " ----- " + list.Password);
            return View(await _context.UserLogins.ToListAsync());
        }
        /*
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(LoginUsuarioDto dto)
        {
            var token = await _usuarioService.Login(dto);
            return Ok(token);
        }
        */

    }
}
