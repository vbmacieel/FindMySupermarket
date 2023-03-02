using SupermarketAPI.Models;
using SupermarketAPI.Models.Dtos;

namespace SupermarketAPI.Repository
{
    public interface ISupermarketRepository
    {
        IEnumerable<Supermarket> GetAll();
        Supermarket GetFromId(int id);
        void Create(Supermarket supermarket);
        void Update(int id, Supermarket newSupermarket);
        void Delete(int id);
    }
}
