using MagazinArticoleVestimentare.Data;
using Microsoft.AspNetCore.Mvc;

namespace MagazinArticoleVestimentare.Controllers
{
    public class ProdusComandatController : Controller
    {
        private readonly AppDbContext _context;
        public ProdusComandatController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var produseComandate = _context.ProdusComandat.ToList();
            return View();
        }
    }
}
