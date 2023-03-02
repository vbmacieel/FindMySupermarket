using SupermarketAPI.Models;
using SupermarketAPI.Models.Dtos;

namespace SupermarketAPI.Service
{
    public interface ISupermarketService
    {
        IEnumerable<Supermarket> GetAll();
        ReadSupermaketDto GetFromId(int id);
        void Create(CreateSupermarketDto createSupermarketDto);
        void Update(int id, UpdateSupermarketDto updateSupermarketDto);
        void Delete(int id);
    }
}
