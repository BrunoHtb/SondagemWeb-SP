using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sondagemSP.Models;
using System.Reflection.Emit;

namespace sondagemSP.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cadastro> Cadastro { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
    public class UsuarioDbContext : IdentityDbContext<Usuario>
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options) { }
    }
}
