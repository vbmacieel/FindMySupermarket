using Microsoft.AspNetCore.Mvc;
using SupermarketAPI.Models.Dtos;
using SupermarketAPI.Service;

namespace SupermarketAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupermarketController : ControllerBase
    {
        private readonly ISupermarketService _service;

        public SupermarketController(ISupermarketService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ReadSupermaketDto readSupermaket = _service.GetFromId(id);
            if (readSupermaket == null)
            {
                return NotFound();
            }
            return Ok(readSupermaket);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateSupermarketDto createSupermarketDto)
        {
            _service.Create(createSupermarketDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateSupermarketDto updateSupermarketDto)
        {
            _service.Update(id, updateSupermarketDto);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
