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
        public async Task AddAsync(Produse produs)
        {
            await _context.Produse.AddAsync(produs);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Produse>> GetAllAsync()
        {
            var result = await _context.Produse.ToListAsync();
            return result;
        }

        public async Task<Produse> GetByIdAsync(int id)
        {
            var result = await _context.Produse.FirstOrDefaultAsync(n => n.ProdusId == id);
            return result;
        }

        public async Task<Produse> UpdateAsync(int id, Produse newProdus)
        {
            _context.Update(newProdus);
            await _context.SaveChangesAsync();
            return newProdus;
        } 
    }
}
