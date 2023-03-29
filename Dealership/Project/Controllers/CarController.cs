using Core.Dtos;
using Core.Services;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [ApiController]
    [Route("api/cars")]
    public class CarController : ControllerBase
    {
        private CarService _carService { get; set; }

        public CarController(CarService carService)
        {
            _carService = carService;
        }

        [HttpGet("/get-all")]
        public ActionResult<List<Car>> GetAll()
        {
            var result = _carService.GetAll();

            return Ok(result);
        }

        [HttpGet("/get/{carId}")]
        public ActionResult<Car> GetById(int carId) 
        {
            var result = _carService.GetById(carId);

            if(result == null)
            {
                return BadRequest("Car not found!");
            }

            return Ok(result);
        }

        [HttpDelete("/delete/{carId}")]
        public ActionResult<Car> Delete(int carId) 
        {
            var result = _carService.Delete(carId);

            if(result == null )
            {
                return BadRequest("Car not found!");
            }
            return Ok(result);
        }

        [HttpPost("/add")]
        public ActionResult<Car> Add(Car car)
        {
            var result = _carService.Add(car);

            if(!result)
            {
                return BadRequest("Car could not be added!");
            }

            return Ok(result);
        }

        [HttpPatch("/edit-name")]
        public ActionResult<bool> GetById([FromBody] CarUpdateDto carUpdateDto)
        {
            var result = _carService.EditName(carUpdateDto);

            if(!result)
            {
                return BadRequest("Car could not be updated!");
            }

            return result;
        }
    }
}
