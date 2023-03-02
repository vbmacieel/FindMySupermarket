using SupermarketAPI.Data;
using SupermarketAPI.Models;

namespace SupermarketAPI.Repository.Impl
{
    public class SupermarketRepository : ISupermarketRepository
    {
        private readonly SupermarketContext _context;

        public SupermarketRepository(SupermarketContext context)
        {
            _context = context;
        }

        public void Create(Supermarket supermarket)
        {
            _context.Supermarkets.Add(supermarket);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Supermarket? supermarket = GetSupermarketFromId(id);
            if (supermarket != null)
            {
                _context.Supermarkets.Remove(supermarket);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Supermarket> GetAll()
        {
            return _context.Supermarkets.ToList();
        }

        public Supermarket GetFromId(int id)
        {
            Supermarket? supermarket = GetSupermarketFromId(id);
            if (supermarket != null)
            {
                return supermarket;
            }
            return null;
        }

        public void Update(int id, Supermarket newSupermarket)
        {
            Supermarket supermarket = GetSupermarketFromId(id);
            if (supermarket != null)
            {
                supermarket.Name = newSupermarket.Name;
                supermarket.State = newSupermarket.State;
                supermarket.City = newSupermarket.City;
                supermarket.HasVeganProducts = newSupermarket.HasVeganProducts;
                supermarket.HasSugarFreeProducts = newSupermarket.HasSugarFreeProducts;
                supermarket.HasGlutenFreeProducts = newSupermarket.HasGlutenFreeProducts;
                supermarket.HasLactoseFreeProducts = newSupermarket.HasLactoseFreeProducts;
                _context.SaveChanges();
            }
        }

        private Supermarket? GetSupermarketFromId(int id)
        {
            return _context.Supermarkets.FirstOrDefault(supermarket => supermarket.Id == id);
        }
    }
}
