using MagazinArticoleVestimentare.Models;

namespace MagazinArticoleVestimentare.Data.Services
{
    public interface IProduseServices
    {

        Task<IEnumerable<Produse>> GetAll();

        Produse GetById(int id);

        void Add(Produse produs);

        Produse Update(int id, Produse newProdus);

        void Delete(int id);
    }
}
