using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestingProject.DTOs;
using TestingProject.IServices;

namespace TestingProject.Api.Controllers
{
    [Route("api/car")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarDTO>>> Get()
        {
            return Ok(await _carService.Get());
        }

        [HttpGet("{id}", Name = "GetCar")]
        public async Task<ActionResult<CarDTO>> GetCar(int id)
        {
            CarDTO car = await _carService.Get(id);
            if (car is NullCarDTO)
                return NotFound();

            return Ok(car);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarDTO DTO)
        {
            int id = await _carService.Create(DTO);

            //return CreatedAtRoute(nameof(GetCar), new { id }, DTO);
            return Ok(id);
        }
    }
}
