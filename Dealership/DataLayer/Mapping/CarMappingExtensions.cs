using DataLayer.Dtos;
using DataLayer.Entities;

namespace DataLayer.Mapping
{
    public static class CarMappingExtensions
    {
        public static List<CarDto> ToCarDtos(this List<Car> cars)
        {
            var results = cars.Select(e => e.ToCarDto()).ToList();
            return results;
        }

        public static CarDto ToCarDto(this Car car)
        {
            if (car == null) return null;

            var result = new CarDto();
            result.Year = car.Year;
            result.Make = car.Make;
            result.Mileage = car.Mileage;
            result.FuelType = car.FuelType;
            result.EngineSize = car.EngineSize;
            result.Color = car.Color;
            result.Model = car.Model;

            return result;
        }
    }
}