using MagazinArticoleVestimentare.Models;

namespace MagazinArticoleVestimentare.Data.Services
{
    public interface IProduseServices
    {

        Task<IEnumerable<Produse>> GetAllAsync();

        Task<Produse> GetByIdAsync(int id);

        Task AddAsync(Produse produs);

        Task<Produse> UpdateAsync(int id, Produse newProdus);

        void Delete(int id);
    }
}
