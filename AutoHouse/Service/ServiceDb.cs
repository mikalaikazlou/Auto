using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Service
{
    public class ServiceDb : IService
    {
        CarContext context = new CarContext();

        public List<Car> GetList()
        {
            List<Car> cars = new List<Car>();
            foreach (Car item in context.Cars)
            {
                cars.Add(item);
            }
            return cars;
        }
        public void Create(Car car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleteCar = context.Cars.Find(id);
            context.Cars.Remove(deleteCar);
            context.SaveChanges();
        }

        public Car Details(int id)
        {
            var getCar = context.Cars.Find(id);
            return getCar;
        }

        public void Update(Car car)
        {
            var updateCar = context.Cars.Find(car.CarId);
            updateCar.Model = car.Model;
            updateCar.Name = car.Name;
            updateCar.Price = car.Price;
            context.SaveChanges();
        }

        public void Dispose()
        {
            
        }
    }
}