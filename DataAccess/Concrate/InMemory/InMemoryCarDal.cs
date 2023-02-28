using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        private int categoryId;

        public InMemoryCarDal() 
        {
            _cars = new List<Car>()
            {
                new Car{CarId = 0,CarName = "Opel Vetra", BrandId = 0, ColorId = 0,  ModelYear = 1999, DaityPrice = 15000, Description = "Temiz Araç" },
                new Car{CarId = 1,CarName = "toyota corolla", BrandId = 1, ColorId = 0,  ModelYear = 2000, DaityPrice = 15000, Description = "Temiz Araç" },
                new Car{CarId = 2,CarName = "nissan", BrandId = 2, ColorId = 0,  ModelYear = 2004, DaityPrice = 18000, Description = "Temiz Araç" },
                new Car{CarId = 3,CarName = "BMW A5", BrandId = 3, ColorId = 0,  ModelYear = 2006, DaityPrice = 30000, Description = "Temiz Araç" },
                new Car{CarId = 4,CarName = "Volkswagen Passat", BrandId = 4, ColorId = 0,  ModelYear = 2010, DaityPrice = 25000, Description = "Temiz Araç" }
            }; 
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete =  _cars.SingleOrDefault(c=>c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars.Where(c => c.CategoryId == categoryId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            return _cars.Where( c =>c.CategoryId == categoryId).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarName= car.CarName;  
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DaityPrice = car.DaityPrice;
            carToUpdate.Description = car.Description;
                
        }
    }
}
