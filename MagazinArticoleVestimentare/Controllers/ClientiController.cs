using MagazinArticoleVestimentare.Data;
using Microsoft.AspNetCore.Mvc;

namespace MagazinArticoleVestimentare.Controllers
{
    public class ClientiController : Controller
    {
        private readonly AppDbContext _context;
        public ClientiController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var totiClientii = _context.Clienti.ToList();
            return View(totiClientii);
        }
    }
}
