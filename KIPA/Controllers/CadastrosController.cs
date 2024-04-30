using KIPA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;

namespace KIPA.Controllers
{
    public class CadastrosController : Controller
    {
        private readonly AppDbContext _context;
        public CadastrosController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()

        {
            var dados = await _context.Cadastros.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]

        public async Task<IActionResult> Create(Cadastro cadastro)
        {
            if (ModelState.IsValid) 
            {
                _context.Cadastros.Add(cadastro);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cadastro);
        }
    }
}


