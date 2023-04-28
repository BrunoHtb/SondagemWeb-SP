using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using sondagemSP.Context;
using sondagemSP.Models;
using sondagemSP.Repositories;
using sondagemSP.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllersWithViews();

//Configura string de conex�o do banco
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<UsuarioDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

//Configura a inje��o de container de dependencia
builder.Services.AddTransient<ICadastroRepository, CadastroRepository>();

//Configura��o para utilizar o IDENTITY
builder.Services.AddIdentity<Usuario, IdentityRole>().
    AddEntityFrameworkStores<UsuarioDbContext>()
.AddDefaultTokenProviders();

//Configurando o AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
