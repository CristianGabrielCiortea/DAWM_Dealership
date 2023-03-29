using Core.Dtos;
using DataLayer.Dtos;
using DataLayer.Entities;
using DataLayer.Mapping;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class CarService
    {
        private CarRepository carRepository { get; set; }

        public CarService(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public List<Car> GetAll()
        {
            return carRepository.GetAll();
        }

        public CarDto GetById(int carId)
        {
            var car = carRepository.GetById(carId);

            var result = car.ToCarDto();

            return result;
        }

        public bool Add(Car car)
        {
            int id = carRepository.GetAll().Max(x => x.Id);
            car.Id = id++;

            return carRepository.Add(car);
        }

        public Car Delete(int carID)
        {
            return carRepository.Delete(carID);
        }

        public bool EditName(CarUpdateDto payload)
        {
            if (payload == null || payload.Make == null || payload.Model == null)
            {
                return false;
            }

            var result = carRepository.GetById(payload.Id);
            if (result == null) return false;

            result.Model = payload.Model;
            result.Make = payload.Make;

            return true;
        }
    }
}