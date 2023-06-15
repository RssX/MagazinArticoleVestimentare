using MagazinArticoleVestimentare.Models;
using Microsoft.EntityFrameworkCore;

namespace MagazinArticoleVestimentare.Data.Services
{
    public class ProduseServices : IProduseServices
    {
        private readonly AppDbContext _context;
        public ProduseServices(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Produse produs)
        {
            _context.Produse.Add(produs);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Produse>> GetAll()
        {
            var result = await _context.Produse.ToListAsync();
            return result;
        }

        public Produse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Produse Update(int id, Produse newProdus)
        {
            throw new NotImplementedException();
        }
    }
}
