using DataLayer.Entities;

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
    }
}