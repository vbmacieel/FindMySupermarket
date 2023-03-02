using AutoMapper;
using SupermarketAPI.Models;
using SupermarketAPI.Models.Dtos;
using SupermarketAPI.Repository;

namespace SupermarketAPI.Service.Impl
{
    public class SupermarketService : ISupermarketService
    {
        private readonly ISupermarketRepository _repository;
        private readonly IMapper _mapper;

        public SupermarketService(ISupermarketRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(CreateSupermarketDto createSupermarketDto)
        {
            Supermarket supermarket = _mapper.Map<Supermarket>(createSupermarketDto);
            _repository.Create(supermarket);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Supermarket> GetAll()
        {
            return _repository.GetAll();
        }

        public ReadSupermaketDto GetFromId(int id)
        {
            Supermarket supermarket = _repository.GetFromId(id);
            return _mapper.Map<ReadSupermaketDto>(supermarket);
        }

        public void Update(int id, UpdateSupermarketDto updateSupermarketDto)
        {
            Supermarket supermarket = _mapper.Map<Supermarket>(updateSupermarketDto);
            _repository.Update(id, supermarket);
        }
    }
}
