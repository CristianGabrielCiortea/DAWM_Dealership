using DataLayer.Dtos;
using DataLayer.Entities;
using DataLayer.Mapping;

namespace DataLayer.Repositories
{
    public class CarRepository
    {
        public List<Car> GetAll()
        {
            var result = DbContext.Cars;

            return result;
        }

        public Car GetById(int carId)
        {
            var result = DbContext.Cars
                .Where(x => x.Id == carId)
                .FirstOrDefault();

            return result;
        }

        public bool Add(Car car)
        {
            DbContext.Cars.Add(car);

            return true;
        }

        public Car Delete(int carId)
        {
            var result = GetById(carId);

            if (result == null) return null;

            DbContext.Cars.Remove(result);
            return result;
        }
    }
}